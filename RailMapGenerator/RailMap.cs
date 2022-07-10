using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RailMapGenerator {
    public class RailMap {
        public List<Station> stations = new List<Station>();
        public List<Line> lines = new List<Line>();
        public Legend legend = new Legend();
        public Font font = Control.DefaultFont;
        public int margin = 20;
        [JsonIgnore]
        public readonly Render render;

        public RailMap() {
            render = new Render(this);
        }

        public Bitmap RenderMap(float zoom = 1, bool showStopName = true, bool showGrid = false, bool showLegend = true) {
            foreach (Station station in stations)
                station.ClearCnt();
            foreach (Line line in lines) {
                if (line.stations.Count <= 1) continue;
                Direction d = Direction.EMPTY;
                for (int i = 1; i < line.stations.Count; i++)
                    d = render.ToNextNode(line.stations[i - 1], line.stations[i], d, line.lineWidth);
            }
            foreach (Station station in stations)
                if (station.autoTextPos)
                    station.AnalyzeTextLocation();
            //Get the bitmap's size
            int maxx = int.MinValue, maxy = int.MinValue;
            foreach (Station station in stations) {
                maxx = Math.Max(maxx, station.location.X);
                maxy = Math.Max(maxy, station.location.Y);
            }
            maxx += 10 * 4 + 25;
            maxy += 10 * 4 + 25;
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
                Pen pen = new Pen(line.color, line.lineWidth * zoom);
                Direction dir = Direction.EMPTY;
                for (int i = 1; i < line.stations.Count; i++) {
                    Pen pen1 = line.sectionEnabled[i - 1] ? pen : new Pen(Color.FromArgb(185, 185, 185), line.lineWidth * zoom);
                    dir = render.DrawLineSection(line.stations[i - 1], line.stations[i], dir, g, pen1, line.lineWidth, zoom);
                }
            }
            //Draw Stops
            for (int i = 0; i < stations.Count; i++)
                render.DrawStop(g, i, showStopName, stations[i].radium, zoom);
            //Draw Legend
            if (showLegend)
                RenderLegend(g, legend.location, zoom);
            //Add margin
            Bitmap ret = new Bitmap(bitmap.Width + margin * 2, bitmap.Height + margin * 2);
            Graphics gr = Graphics.FromImage(ret);
            gr.Clear(Color.White);
            gr.DrawImage(bitmap, margin, margin);
            return ret;
        }

        public void RenderLegend(Graphics g, Point location, float zoom) {
            int c = (int)Math.Ceiling(1.0 * lines.Count / legend.count);
            for (int i = 0; i < lines.Count; i++) {
                int x = i % c, y = i / c;
                if (legend.isHorizon) (x, y) = (y, x);
                Render.FillRectangle(g, new SolidBrush(lines[i].color), location, x * 120 + 10, y * 20 + 7.5f, 50, 10, zoom);
                Render.DrawString(g, lines[i].name, legend.font, Brushes.Black, Render.AddPoint(location, new Point(x * 120 + 65, y * 20 + 5)), zoom);
            }
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
