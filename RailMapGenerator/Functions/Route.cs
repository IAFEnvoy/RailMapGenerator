using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailMapGenerator {
    internal class Route {
        public static string GetShortestRoute(List<Station> stations, List<Line> routes, int startStationIndex, int endStationIndex) {
            Dictionary<int, int> distances = new();
            Dictionary<int, int> previousStations = new();
            List<int> unvisitedStations = new();

            for (int i = 0; i < stations.Count; i++) {
                if (i == startStationIndex) {
                    distances[i] = 0;
                } else {
                    distances[i] = int.MaxValue;
                }

                previousStations[i] = -1;
                unvisitedStations.Add(i);
            }

            while (unvisitedStations.Count > 0) {
                int currentStationIndex = -1;
                int shortestDistance = int.MaxValue;

                foreach (int stationIndex in unvisitedStations) {
                    if (distances[stationIndex] < shortestDistance) {
                        currentStationIndex = stationIndex;
                        shortestDistance = distances[stationIndex];
                    }
                }

                if (currentStationIndex == endStationIndex) {
                    string route = "";
                    int stationIndex = endStationIndex;

                    while (previousStations[stationIndex] != -1) {
                        Line routeObject = routes.FirstOrDefault(r => r.stations.Contains(stationIndex) && r.stations.Contains(previousStations[stationIndex]));
                        if (routeObject != null) {
                            route = routeObject.name + "-" + stations[stationIndex].name + "-" + route;
                            stationIndex = previousStations[stationIndex];
                        } else {
                            return "没有可行的线路";
                        }
                    }

                    route = stations[startStationIndex].name + "-" + route;
                    while (route.EndsWith("-")) route = route[..^1];
                    return route;
                }

                unvisitedStations.Remove(currentStationIndex);

                foreach (Line route in routes) {
                    if (route.stations.Contains(currentStationIndex)) {
                        foreach (int stationIndex in route.stations) {
                            if (unvisitedStations.Contains(stationIndex)) {
                                int distance = distances[currentStationIndex] + 1;

                                if (distance < distances[stationIndex]) {
                                    distances[stationIndex] = distance;
                                    previousStations[stationIndex] = currentStationIndex;
                                }
                            }
                        }
                    }
                }
            }
            return "没有可行的线路";
        }

        public static string GetRoute(List<Station> stations, List<Line> routes, int startStationIndex, int endStationIndex) {
            List<int> visitedStations = new() { startStationIndex };
            List<int> currentRoute = new() { startStationIndex };

            while (currentRoute.Count > 0) {
                int currentStationIndex = currentRoute[^1];
                if (currentStationIndex == endStationIndex) {
                    string route = "";
                    for (int i = 0; i < currentRoute.Count - 1; i++) {
                        int stationIndex = currentRoute[i];
                        int nextStationIndex = currentRoute[i + 1];
                        Line routeObject = routes.FirstOrDefault(r => r.stations.Contains(stationIndex) && r.stations.Contains(nextStationIndex));
                        if (routeObject != null) {
                            route += stations[stationIndex].name + "-" + routeObject.name + "-";
                        } else {
                            return "没有可行的线路";
                        }
                    }
                    route += stations[endStationIndex].name;
                    return route;
                }
                bool foundNextStation = false;
                foreach (Line route in routes) {
                    if (route.stations.Contains(currentStationIndex)) {
                        foreach (int stationIndex in route.stations) {
                            if (!visitedStations.Contains(stationIndex)) {
                                visitedStations.Add(stationIndex);
                                currentRoute.Add(stationIndex);
                                foundNextStation = true;
                                break;
                            }
                        }
                    }
                    if (foundNextStation) {
                        break;
                    }
                }
                if (!foundNextStation) {
                    currentRoute.RemoveAt(currentRoute.Count - 1);
                }
            }
            return "没有可行的线路";
        }
    }
}
