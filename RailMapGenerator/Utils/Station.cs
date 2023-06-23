using Newtonsoft.Json;
using System;
using System.Drawing;

namespace RailMapGenerator {
    public class Station {
        public static readonly float sqrt2div2 = (float)(Math.Sqrt(2) / 2);
        public Point location;
        public string name;
        public bool enable;
        public int radium;
        public bool autoTextPos = true;
        public double textOffsetX, textOffsetY;
        [JsonIgnore]
        public int[] totalWidth = new int[8];
        [JsonIgnore]
        public int[] renderWidth = new int[8];

        public Station(string name, int x = 0, int y = 0, bool enable = true, int radium = 10) {
            this.name = name;
            this.location = new Point(x, y);
            this.enable = enable;
            this.radium = radium;
        }

        public Point GetOffset(Direction dir, int lineWidth) {
            if (this.totalWidth[dir.GetId()] == this.renderWidth[dir.GetId()])
                throw new IndexOutOfRangeException("请求次数过多");
            int offset = this.renderWidth[dir.GetId()] + lineWidth / 2 - this.totalWidth[dir.GetId()] / 2;
            this.renderWidth[dir.GetId()] += lineWidth;
            if (dir == Direction.PositiveX || dir == Direction.NegativeX)
                return new Point(0, offset);
            if (dir == Direction.PositiveY || dir == Direction.NegativeY)
                return new Point(offset, 0);
            if (dir == Direction.PXPY || dir == Direction.NXNY)
                return new Point((int)(offset * sqrt2div2), (int)(-offset * sqrt2div2));
            if (dir == Direction.PXNY || dir == Direction.NXPY)
                return new Point((int)(offset * sqrt2div2), (int)(offset * sqrt2div2));
            throw new ArgumentException("错误的Direction变量，ID为" + dir.GetId().ToString());
        }

        public void ClearCnt() {
            for (int i = 0; i < 8; i++) {
                this.totalWidth[i] = 0;
                this.renderWidth[i] = 0;
            }
        }

        public void AnalyzeTextLocation() {
            int min = int.MaxValue;
            bool[] check = new bool[8];
            for (int i = 0; i < 8; i++)
                min = Math.Min(min, this.totalWidth[i]);
            for (int i = 0; i < 8; i++)
                check[i] = this.totalWidth[i] - min > 0;
            Pair<int, int> dir = this.GetDirPair(check);
            int f = dir.first, s = dir.second;
            while (f > s) s += 8;
            while (f < s - 1) { f++; s--; f %= 8; s %= 8; while (f > s) s += 8; }
            int length = this.name.Length;
            double degree = (Direction.GetById(f % 8).GetDegree() + Direction.GetById(s % 8).GetDegree()) / 2 * Math.PI / 180;
            this.textOffsetX = Math.Cos(degree) * this.radium * (length + 0.5) + this.location.X;
            this.textOffsetY = Math.Sin(degree) * this.radium * 2 + this.location.Y;
        }

        private Pair<int, int> GetDirPair(bool[] b) {
            int maxlen = 0, lennow = 0;
            Pair<int, int> ret = null;
            for (int i = 0; i < 16; i++)
                if (b[i % 8]) {
                    if (lennow >= maxlen) {
                        maxlen = lennow;
                        ret = new Pair<int, int>((i - lennow) % 8, (i - 1) % 8);
                    }
                    lennow = 0;
                }
                else
                    lennow++;
            if (ret == null)
                return new Pair<int, int>(0, 0);
            return ret;
        }
    }
}
