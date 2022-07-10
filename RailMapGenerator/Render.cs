using System;
using System.Drawing;

namespace RailMapGenerator {
    public class Render {
        private readonly RailMap railMap;
        public Render(RailMap railMap) {
            this.railMap = railMap;
        }
        public Pair<Direction, Direction> GetDirectionPair(int start, int end, Direction last) {
            int x = railMap.stations[end].location.X - railMap.stations[start].location.X;
            int y = railMap.stations[end].location.Y - railMap.stations[start].location.Y;
            Direction d = Direction.EMPTY;
            if (x == 0 && y == 0)
                return new Pair<Direction, Direction>(last, last);
            else if (x == 0)
                d = y > 0 ? Direction.PositiveY : Direction.NegativeY;
            else if (y == 0)
                d = x > 0 ? Direction.PositiveX : Direction.NegativeX;
            else if (x == y)
                d = x > 0 ? Direction.PXPY : Direction.NXNY;
            else if (x == -y)
                d = x > 0 ? Direction.PXNY : Direction.NXPY;
            if (d != Direction.EMPTY)
                return new Pair<Direction, Direction>(d, d);
            Direction d1, d2;
            if (x > y)
                d1 = x + y > 0 ? Direction.PositiveX : Direction.NegativeY;
            else
                d1 = x + y > 0 ? Direction.PositiveY : Direction.NegativeX;
            if (x > 0)
                d2 = y > 0 ? Direction.PXPY : Direction.PXNY;
            else
                d2 = y > 0 ? Direction.NXPY : Direction.NXNY;
            if (last == Direction.EMPTY)
                return new Pair<Direction, Direction>(d1, d2);
            int r1 = Math.Abs(last.GetId() - d1.GetId());
            if (r1 > 4) r1 = 8 - r1;
            int r2 = Math.Abs(last.GetId() - d2.GetId());
            if (r2 > 4) r2 = 8 - r2;
            if (r1 > r2)
                (d2, d1) = (d1, d2);
            if (d1 == Direction.Reverse(last))
                (d2, d1) = (d1, d2);
            return new Pair<Direction, Direction>(d1, d2);
        }

        public Direction ToNextNode(int start, int end, Direction last, int lineWidth) {
            var dirPair = GetDirectionPair(start, end, last);
            Direction d1 = dirPair.first, d2 = dirPair.second;
            railMap.stations[start].totalWidth[d1.GetId()] += lineWidth;
            railMap.stations[end].totalWidth[Direction.Reverse(d2).GetId()] += lineWidth;
            return d2;
        }

        public Direction DrawLineSection(int start, int end, Direction last, Graphics g, Pen pen, float zoom = 1) {
            var dirPair = GetDirectionPair(start, end, last);
            Direction d1 = dirPair.first, d2 = dirPair.second;
            Point startOffset = railMap.stations[start].GetOffset(d1, (int)pen.Width), endOffset = railMap.stations[end].GetOffset(Direction.Reverse(d2), (int)pen.Width);
            Point startPoint = AddPoint(railMap.stations[start].location, startOffset), endPoint = AddPoint(railMap.stations[end].location, endOffset);
            if (d1 == d2)
                DrawLines(g, pen, new Point[] { startPoint, endPoint }, zoom);
            else {
                int dis = Math.Abs(Math.Abs(endPoint.X - startPoint.X) - Math.Abs(endPoint.Y - startPoint.Y));
                Point mid = d1.IsMainDirection() ? d1.GetDelta(startPoint, dis) : d2.GetDelta(endPoint, dis, true);
                DrawLines(g, pen, new Point[] { startPoint, mid, endPoint }, zoom);
            }
            return d2;
        }

        public void DrawStop(Graphics g, int node, Font font = null, bool renderName = true, int radium = 10, float zoom = 1) {
            FillEllipse(g, railMap.stations[node].enable ? Brushes.Black : Brushes.Gray, railMap.stations[node].location.X - radium, railMap.stations[node].location.Y - radium, radium * 2, radium * 2, zoom);
            int iRadium = radium - 2;
            FillEllipse(g, Brushes.White, railMap.stations[node].location.X - iRadium, railMap.stations[node].location.Y - iRadium, iRadium * 2, iRadium * 2, zoom);
            if (!renderName) return;
            string text = railMap.stations[node].name;
            int length = text.Length;
            Pair<Direction, Direction> dir = railMap.stations[node].GetTextDirection();
            double degree = (dir.first.GetDegree() + dir.second.GetDegree()) / 2 * Math.PI / 180;
            double x = Math.Cos(degree) * radium * length + railMap.stations[node].location.X, y = Math.Sin(degree) * radium * 2 + railMap.stations[node].location.Y;
            SizeF size = g.MeasureString(railMap.stations[node].name, font);
            x -= size.Width / 2;
            y -= size.Height / 2;
            DrawString(g, text, font, railMap.stations[node].enable ? Brushes.Black : Brushes.Gray, new Point((int)x, (int)y), zoom);
        }

        public static Point AddPoint(Point p1, Point p2) {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static void DrawLines(Graphics g, Pen pen, Point[] p, float zoom) {
            for (int i = 0; i < p.Length; i++)
                p[i] = new Point((int)(p[i].X * zoom), (int)(p[i].Y * zoom));
            g.DrawLines(pen, p);
        }

        public static void FillEllipse(Graphics g, Brush brush, int x, int y, int width, int height, float zoom) {
            g.FillEllipse(brush, x * zoom, y * zoom, width * zoom, height * zoom);
        }

        public static void DrawString(Graphics g, string text, Font font, Brush brush, PointF p, float zoom) {
            g.DrawString(text, new Font(font.FontFamily, font.Size * zoom, font.Style, font.Unit), brush, new PointF(p.X * zoom, p.Y * zoom));
        }
    }
}
