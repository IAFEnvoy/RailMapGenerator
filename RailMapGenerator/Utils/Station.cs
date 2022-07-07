﻿using Newtonsoft.Json;
using System;
using System.Drawing;

namespace RailMapGenerator {
    public class Station {
        public static readonly float sqrt2div2 = (float)(Math.Sqrt(2) / 2);
        public Point location;
        public string name;
        [JsonIgnore]
        public bool enable;
        [JsonIgnore]
        public int[] lineCnt = new int[8];
        [JsonIgnore]
        public int[] renderedCnt = new int[8];
        [JsonIgnore]
        private Pair<Direction, Direction> textDir = new Pair<Direction, Direction>(Direction.EMPTY, Direction.EMPTY);

        public Station(string name, int x = 0, int y = 0) {
            this.name = name;
            location = new Point(x, y);
        }

        public Point GetOffset(Direction dir) {
            if (renderedCnt[dir.GetId()] == lineCnt[dir.GetId()])
                throw new IndexOutOfRangeException("请求次数过多");
            int totalWidth = (lineCnt[dir.GetId()] - 1) * Setting.INSTANCE.lineWidth.Value;
            int offset = renderedCnt[dir.GetId()] * Setting.INSTANCE.lineWidth.Value - totalWidth / 2;
            renderedCnt[dir.GetId()]++;
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
                lineCnt[i] = 0;
                renderedCnt[i] = 0;
            }
            textDir = new Pair<Direction, Direction>(Direction.EMPTY, Direction.EMPTY);
        }

        public void AnalyzeTextLocation() {
            int min = int.MaxValue;
            bool[] check = new bool[8];
            for (int i = 0; i < 8; i++)
                min = Math.Min(min, lineCnt[i]);
            for (int i = 0; i < 8; i++)
                check[i] = lineCnt[i] - min > 0;
            Pair<int, int> dir = GetDirPair(check);
            int f = dir.first, s = dir.second;
            while (f > s) s += 8;
            while (f < s - 1) { f++; s--; f %= 8; s %= 8; while (f > s) s += 8; }
            textDir = new Pair<Direction, Direction>(Direction.GetById(f % 8), Direction.GetById(s % 8));
        }

        public void AnalyzeEnabled(RailMap map,int thisIndex) {
            enable = false;
            foreach (Line line in map.lines)
                for (int i = 0; i < line.stations.Count; i++)
                    if (line.stations[i] == thisIndex)
                        enable |= line.status[i] == StationStatus.Enable;
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
                } else
                    lennow++;
            if (ret == null)
                return new Pair<int, int>(0, 0);
            return ret;
        }

        public Pair<Direction, Direction> GetTextDirection() {
            if (textDir.first == Direction.EMPTY || textDir.second == Direction.EMPTY)
                throw new NullReferenceException("调用太早，应在AnalyzeTextLocation()后调用");
            return textDir;
        }
    }
}
