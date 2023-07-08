using System.Collections.Generic;

namespace RailMapGenerator {
    internal class Route {
        private int shortest = int.MaxValue;
        private readonly List<List<IRoutable>> ansPath = new();
        private readonly List<bool> visited = new();
        private readonly RailMap railMap;
        private readonly int stationWeight;
        private readonly int transferWeight;
        private readonly bool includeIncomplete;

        public Route(RailMap railMap, int stationWeight, int transferWeight, bool includeIncomplete) {
            this.railMap = railMap;
            for (int i = 0; i < this.railMap.stations.Count; i++) this.visited.Add(false);
            this.stationWeight = stationWeight;
            this.transferWeight = transferWeight;
            this.includeIncomplete = includeIncomplete;
        }

        private HashSet<int> GetNeighborElement(Line line, int target) {
            HashSet<int> ret = new();
            if (line.stations[0] == target && (line.sectionEnabled[0] || this.includeIncomplete)) ret.Add(line.stations[1]);
            if (line.stations[^1] == target && (line.sectionEnabled[^2] || this.includeIncomplete)) ret.Add(line.stations[^2]);
            for (int i = 1; i <= line.stations.Count - 2; i++)
                if (line.stations[i] == target) {
                    if (line.sectionEnabled[i - 1] || this.includeIncomplete)
                        ret.Add(line.stations[i - 1]);
                    if (line.sectionEnabled[i] || this.includeIncomplete)
                        ret.Add(line.stations[i + 1]);
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
            for (int i = 1; i <= list.Count - 3; i += 2)
                if (list[i] != list[i + 2]) {
                    newList.Add(list[i]);
                    newList.Add(list[i + 1]);
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
            List<Pair<Line, HashSet<int>>> neighborStation = new();
            foreach (Line line in this.railMap.lines) {
                HashSet<int> l = this.GetNeighborElement(line, nowStationIndex);
                if (l.Count > 0) neighborStation.Add(new(line, l));
            }
            foreach (Pair<Line, HashSet<int>> p in neighborStation)
                foreach (int i in p.second)
                    if (!this.visited[i]) {
                        this.visited[i] = true;
                        this.GetShortest(i, endStationIndex, score + this.stationWeight + (p.first == lastLine ? 0 : this.transferWeight), p.first, Package(path, p.first, this.railMap.stations[i]));
                        this.visited[i] = false;
                    }
        }

        public static List<List<IRoutable>> GetShortestPath(RailMap railMap, int startStationIndex, int endStationIndex, int stationWeight, int transferWeight, bool includeIncomplete = false) {
            Route route = new(railMap, stationWeight, transferWeight, includeIncomplete);
            route.GetShortest(startStationIndex, endStationIndex, 0, null, new() { railMap.stations[startStationIndex] });
            return route.ansPath;
        }
    }
}
