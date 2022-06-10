using System;
using System.Collections.Generic;
using System.Drawing;

namespace RailMapGenerator {
    public class RailMap {
        public static Font font = null;
        public List<Node> stops = new List<Node>();
        public List<Line> lines = new List<Line>();
        private static int margin = 20;
        private static int stopRadium = 10;
        private static int lineWidth = 6;

        public RailMap() { }

        private void AnalyzeNode() {
            foreach (Node node in stops)
                node.ClearCnt();
            foreach (Line line in lines) {
                if (line.stops.Count <= 1) continue;
                Direction d = Direction.EMPTY;
                for (int i = 1; i < line.stops.Count; i++)
                    d = Render.ToNextNode(stops[line.stops[i - 1]], stops[line.stops[i]], d);
            }
            foreach (Node node in stops)
                node.AnalyzeTextLocation();
        }

        public Bitmap RenderMap(float zoom = 1, bool showStopName = true, bool showGrid = false) {
            //Check all stops' line count in 8 directions
            AnalyzeNode();
            //Get the bitmap's size
            int maxx = int.MinValue, maxy = int.MinValue;
            foreach (Node node in stops) {
                maxx = Math.Max(maxx, node.location.X);
                maxy = Math.Max(maxy, node.location.Y);
            }
            maxx += stopRadium * 4; maxy += stopRadium * 4;
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
                if (line.stops.Count <= 1) continue;
                Pen pen = new Pen(line.color, lineWidth * zoom);
                Direction dir = Direction.EMPTY;
                for (int i = 1; i < line.stops.Count; i++)
                    dir = Render.DrawLineSection(stops[line.stops[i - 1]], stops[line.stops[i]], dir, g, pen, zoom);
            }
            //Draw Stops
            foreach (Node node in stops)
                Render.DrawStop(g, node, font, showStopName, stopRadium, zoom);
            //Add margin
            Bitmap ret = new Bitmap(bitmap.Width + margin * 2, bitmap.Height + margin * 2);
            Graphics gr = Graphics.FromImage(ret);
            gr.Clear(Color.White);
            gr.DrawImage(bitmap, margin, margin);
            return ret;
        }

        public bool IsEmpty() {
            return lines.Count == 0 && stops.Count == 0;
        }

        public static Bitmap GetEmpty() {
            return new Bitmap(margin * 2, margin * 2);
        }
    }
}
