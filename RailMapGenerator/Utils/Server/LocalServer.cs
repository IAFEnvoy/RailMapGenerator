using PeanutButter.SimpleHTTPServer;
using System.Collections.Generic;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Web;

namespace RailMapGenerator {
    internal class LocalServer {
        private static RailMap railMap = null;
        public static HttpServer server = null;

        public static void StartServer(RailMap map, LogServerMessage handler) {
            railMap = map;
            server = new(8989, handler.Invoke);
            server.AddHandler((processor, stream) => {
                if (processor.Path == "favicon.ico") return HttpServerPipelineResult.NotHandled;
                else if (processor.Path == "/")
                    processor.WriteSuccess("text/plain", Encoding.UTF8.GetBytes("Ping Message"));
                else if (processor.Path == "/route") {
                    Dictionary<string, string> form = processor.UrlParameters;
                    if (form != null && form.ContainsKey("start") && form.ContainsKey("end")) {
                        int start = railMap.GetStationByName(HttpUtility.UrlDecode(form["start"])), end = railMap.GetStationByName(HttpUtility.UrlDecode(form["end"]));
                        if (start == -1 || end == -1) processor.WriteFailure(HttpStatusCode.NotAcceptable, "Not Acceptable", "Station Not Found");
                        else {
                            List<List<IRoutable>> res = Route.GetShortestPath(railMap, start, end, 1, 1, false);
                            if (res.Count == 0) processor.WriteFailure(HttpStatusCode.NotFound, "Not Found", "Route Not Found");
                            else {
                                List<string> newList = new();
                                res[0].ForEach(i => newList.Add(i.GetName()));
                                processor.WriteSuccess("text/plain; charset=UTF-8", Encoding.UTF8.GetBytes(string.Join("-", newList)));
                            }
                        }
                    } else
                        processor.WriteFailure(HttpStatusCode.BadRequest, "Bad Request", "Missing one of the fields. [start,end]");
                }
                return HttpServerPipelineResult.HandledExclusively;
            });
            server.Start();
        }
    }

    delegate void LogServerMessage(string message);
}
