using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace RailMapGenerator {
    public class RailMap {
        public List<Station> stations = new List<Station>();
        public List<Line> lines = new List<Line>();
        [JsonIgnore]
        public readonly Render render;

        public RailMap() {
            render = new Render(this);
        }

        public Bitmap RenderMap(float zoom = 1, bool showStopName = true, bool showGrid = false) {
            foreach (Station station in stations)
                station.ClearCnt();
            foreach (Line line in lines) {
                if (line.stations.Count <= 1) continue;
                Direction d = Direction.EMPTY;
                for (int i = 1; i < line.stations.Count; i++)
                    d = render.ToNextNode(line.stations[i - 1], line.stations[i], d);
            }
            for (int i = 0; i < stations.Count; i++) {
                stations[i].AnalyzeTextLocation();
                stations[i].AnalyzeEnabled(this, i);
            }
            //Get the bitmap's size
            int maxx = int.MinValue, maxy = int.MinValue;
            foreach (Station station in stations) {
                maxx = Math.Max(maxx, station.location.X);
                maxy = Math.Max(maxy, station.location.Y);
            }
            maxx += Setting.INSTANCE.stopRadium.Value * 4 + 25;
            maxy += Setting.INSTANCE.stopRadium.Value * 4 + 25;
            //Create bitmap
            Bitmap bitmap = new Bitmap((int)(maxx * zoom), (int)(maxy * zoom));
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            //Draw background web
            if (showGrid) {
                Pen gray = new Pen(Color.FromArgb(185, 185, 185));
                for (int i = 1; i <= bitmap.Width / 50 / zoom; i++)
                    g.DrawLine(gray, i * 50 * zoom, 0, i * 50 * zoom, bitmap.Height);
                for (int i = 1; i <= bitmap.Height / 50 / zoom; i++)
                    g.DrawLine(gray, 0, i * 50 * zoom, bitmap.Width, i * 50 * zoom);
            }
            //Draw line
            foreach (Line line in lines) {
                //If there is only 1 stop, ignore it
                if (line.stations.Count <= 1) continue;
                Pen pen = new Pen(line.color, Setting.INSTANCE.lineWidth.Value * zoom);
                Direction dir = Direction.EMPTY;
                for (int i = 1; i < line.stations.Count; i++) {
                    bool enable = line.status[i - 1] != StationStatus.Disable && line.status[i] != StationStatus.Disable;
                    Pen pen1 = enable ? pen : new Pen(Color.FromArgb(185, 185, 185), Setting.INSTANCE.lineWidth.Value * zoom);
                    dir = render.DrawLineSection(line.stations[i - 1], line.stations[i], dir, g, pen1, zoom);
                }
            }
            //Draw Stops
            for (int i = 0; i < stations.Count; i++)
                render.DrawStop(g, i, Setting.INSTANCE.font, showStopName, Setting.INSTANCE.stopRadium.Value, zoom);
            //Add margin
            Bitmap ret = new Bitmap(bitmap.Width + Setting.INSTANCE.margin.Value * 2, bitmap.Height + Setting.INSTANCE.margin.Value * 2);
            Graphics gr = Graphics.FromImage(ret);
            gr.Clear(Color.White);
            gr.DrawImage(bitmap, Setting.INSTANCE.margin.Value, Setting.INSTANCE.margin.Value);
            return ret;
        }

        public bool IsEmpty() {
            return lines.Count == 0 && stations.Count == 0;
        }

        public void MoveAll(int x, int y) {
            foreach (Station node in stations)
                node.location.Offset(x, y);
        }
    }
}
