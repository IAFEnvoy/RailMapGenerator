using System.Drawing;

namespace RailMapGenerator {
    public class Direction {
        public readonly static Direction EMPTY = new(-1, 0, 0, 0);
        public readonly static Direction PositiveX = new(0, 1, 0, 0);
        public readonly static Direction PXPY = new(1, 1, 1, 45);//Positive X Positive Y
        public readonly static Direction PositiveY = new(2, 0, 1, 90);
        public readonly static Direction NXPY = new(3, -1, 1, 135);//Negative X Positive Y
        public readonly static Direction NegativeX = new(4, -1, 0, 180);
        public readonly static Direction NXNY = new(5, -1, -1, 225);//Negative X Negative Y
        public readonly static Direction NegativeY = new(6, 0, -1, 270);
        public readonly static Direction PXNY = new(7, 1, -1, 315);//Positive X Negative Y
        private readonly int id, dx, dy;
        private readonly double degree;

        private Direction(int id, int dx, int dy, double degree) {
            this.id = id;
            this.dx = dx;
            this.dy = dy;
            this.degree = degree;
        }

        public int GetId() => this.id;

        public double GetDegree() => this.degree;

        public bool IsMainDirection() {
            return this.dx == 0 || this.dy == 0;
        }

        public Point GetDelta(Point point, int length, bool sub = false) {
            if (sub)
                return new Point(point.X - length * this.dx, point.Y - length * this.dy);
            return new Point(point.X + length * this.dx, point.Y + length * this.dy);
        }

        public static Direction Reverse(Direction dir) {
            if (dir == PositiveX) return NegativeX;
            if (dir == PositiveY) return NegativeY;
            if (dir == NegativeX) return PositiveX;
            if (dir == NegativeY) return PositiveY;
            if (dir == PXPY) return NXNY;
            if (dir == PXNY) return NXPY;
            if (dir == NXPY) return PXNY;
            if (dir == NXNY) return PXPY;
            return EMPTY;
        }

        public static Direction GetById(int id) {
            switch (id) {
                case 0: return PositiveX;
                case 1: return PXPY;
                case 2: return PositiveY;
                case 3: return NXPY;
                case 4: return NegativeX;
                case 5: return NXNY;
                case 6: return NegativeY;
                case 7: return PXNY;
                default: return EMPTY;
            }
        }
    }
}
