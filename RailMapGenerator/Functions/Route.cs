using System;
using System.Collections.Generic;

namespace RailMapGenerator {
    internal class Route {
        private int shortest = int.MaxValue;
        private readonly List<List<IRoutable>> ansPath = new();
        private readonly List<bool> visited = new();
        private readonly RailMap railMap;
        private readonly int stationWeight;
        private readonly int transferWeight;
        public Route(RailMap railMap, int stationWeight, int transferWeight) {
            this.railMap = railMap;
            for (int i = 0; i < this.railMap.stations.Count; i++) this.visited.Add(false);
            this.stationWeight = stationWeight;
            this.transferWeight = transferWeight;
        }

        private static List<int> GetNeighborElement(List<int> list, int target) {//TODO: 去重
            List<int> ret = new();
            if (list[0] == target) ret.Add(list[1]);
            if (list[^1] == target) ret.Add(list[^2]);
            for (int i = 1; i <= list.Count - 2; i++)
                if (list[i] == target) {
                    ret.Add(list[i - 1]);
                    ret.Add(list[i + 1]);
                }
            return ret;
        }

        private static List<IRoutable> Package(List<IRoutable> list, IRoutable item1, IRoutable item2) {
            List<IRoutable> newList = new();
            list.ForEach(newList.Add);
            newList.Add(item1);
            newList.Add(item2);
            return newList;
        }

        private static List<IRoutable> RemoveSameNear(List<IRoutable> list) {
            List<IRoutable> newList = new() { list[0] };
            for (int i = 1; i <= list.Count - 3; i += 2) {
                if (list[i] != list[i + 2]) {
                    newList.Add(list[i]);
                    newList.Add(list[i + 1]);
                }
            }
            newList.Add(list[^2]);
            newList.Add(list[^1]);
            return newList;
        }

        private void GetShortest(int nowStationIndex, int endStationIndex, int score, Line lastLine, List<IRoutable> path) {
            if (score > this.shortest) return;
            if (nowStationIndex == endStationIndex) {
                if (this.shortest > score) {
                    this.shortest = score;
                    this.ansPath.Clear();
                    this.ansPath.Add(RemoveSameNear(path));
                } else if (this.shortest == score)
                    this.ansPath.Add(RemoveSameNear(path));
                return;
            }
            List<Pair<Line, List<int>>> neighborStation = new();
            foreach (Line line in this.railMap.lines) {
                List<int> l = GetNeighborElement(line.stations, nowStationIndex);
                if (l.Count > 0) neighborStation.Add(new(line, l));
            }
            foreach (Pair<Line, List<int>> p in neighborStation) {
                if (p.first == lastLine) {
                    foreach (int i in p.second) {
                        if (!this.visited[i]) {
                            this.visited[i] = true;
                            this.GetShortest(i, endStationIndex, score + this.stationWeight, p.first, Package(path, p.first, this.railMap.stations[i]));
                            this.visited[i] = false;
                        }
                    }
                } else {
                    foreach (int i in p.second) {
                        if (!this.visited[i]) {
                            this.visited[i] = true;
                            this.GetShortest(i, endStationIndex, score + this.stationWeight + this.transferWeight, p.first, Package(path, p.first, this.railMap.stations[i]));
                            this.visited[i] = false;
                        }
                    }
                }
            }
        }

        public static List<List<IRoutable>> GetShortestPath(RailMap railMap, int startStationIndex, int endStationIndex, int stationWeight, int transferWeight) {
            Route route = new(railMap, stationWeight, transferWeight);
            route.GetShortest(startStationIndex, endStationIndex, 0, null, new() { railMap.stations[startStationIndex] });
            return route.ansPath;
        }
    }
}
