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
        public Size mapSize = new Size(100, 100);
        [JsonIgnore]
        public readonly Render render;

        public RailMap() {
            this.render = new Render(this);
        }

        public Bitmap RenderMap(float zoom = 1, bool showStopName = true, bool showGrid = false, bool showLegend = true) {
            foreach (Station station in this.stations)
                station.ClearCnt();
            foreach (Line line in this.lines) {
                if (line.stations.Count <= 1) continue;
                Direction d = Direction.EMPTY;
                for (int i = 1; i < line.stations.Count; i++)
                    d = this.render.ToNextNode(line.stations[i - 1], line.stations[i], d, line.lineWidth);
            }
            foreach (Station station in this.stations)
                if (station.autoTextPos)
                    station.AnalyzeTextLocation();
            //Get the bitmap's size
            int maxx = int.MinValue, maxy = int.MinValue;
            foreach (Station station in this.stations) {
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
            foreach (Line line in this.lines) {
                //If there is only 1 stop, ignore it
                if (line.stations.Count <= 1) continue;
                Pen pen = new Pen(line.color, line.lineWidth * zoom);
                Direction dir = Direction.EMPTY;
                for (int i = 1; i < line.stations.Count; i++) {
                    Pen pen1 = line.sectionEnabled[i - 1] ? pen : new Pen(Color.FromArgb(185, 185, 185), line.lineWidth * zoom);
                    dir = this.render.DrawLineSection(line.stations[i - 1], line.stations[i], dir, g, pen1, line.lineWidth, zoom);
                }
            }
            //Draw Stops
            for (int i = 0; i < this.stations.Count; i++)
                this.render.DrawStop(g, i, showStopName, this.stations[i].radium, zoom);
            //Draw Legend
            if (showLegend) {
                Bitmap l = this.RenderLegend(this.legend.zoom * zoom);
                g.DrawImage(l, this.legend.location.X * zoom, this.legend.location.Y * zoom);
            }
            //Add margin
            Bitmap ret = new Bitmap(bitmap.Width + this.margin * 2, bitmap.Height + this.margin * 2);
            Graphics gr = Graphics.FromImage(ret);
            gr.Clear(Color.White);
            gr.DrawImage(bitmap, this.margin, this.margin);
            return ret;
        }

        public Bitmap RenderLegend(float zoom) {
            int c = (int)Math.Ceiling(1.0 * this.lines.Count / this.legend.count);
            int w = (int)Math.Ceiling(1.0 * this.lines.Count / this.legend.count), h = this.legend.count;
            if (this.legend.isHorizon) (w, h) = (h, w);
            Bitmap ret = new Bitmap((int)((w * 120 + 20) * zoom), (int)((h * 20 + 15) * zoom));
            Graphics g = Graphics.FromImage(ret);
            for (int i = 0; i < this.lines.Count; i++) {
                int x = i % c, y = i / c;
                if (this.legend.isHorizon) (x, y) = (y, x);
                Render.FillRectangle(g, new SolidBrush(this.lines[i].color), new Point(0, 0), x * 120 + 10, y * 20 + 7.5f, 50, 10, zoom);
                Render.DrawString(g, this.lines[i].name, this.legend.font, Brushes.Black, new Point(x * 120 + 65, y * 20 + 5), zoom);
            }
            return ret;
        }

        public bool IsEmpty() {
            return this.lines.Count == 0 && this.stations.Count == 0;
        }

        public void MoveAll(int x, int y) {
            foreach (Station node in this.stations)
                node.location.Offset(x, y);
        }
    }
}
