using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RailMapGenerator {
    internal class LocalServer {
        static bool RequestStop = false;

        public static void StartServer() {
            TcpListener server = new(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8989));
            server.Start();
            new Thread(() => {
                while (!RequestStop)
                    if (server.Pending()) {
                        TcpClient client = server.AcceptTcpClient();
                        new Thread(() => Serve(client, "")).Start();
                    }
                server.Stop();
            }).Start();
        }

        static void Serve(TcpClient client, string baseAddress) {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[512];
            stream.Read(buffer);
            string str = Encoding.ASCII.GetString(buffer);
            string firstLine = str.Split("\r\n").First();
            string urlFull = firstLine.Split(" ")[1];
            string url = urlFull.Split("?")[0], args = "";
            if (url != urlFull) args = urlFull[(url.Length + 1)..];
            if (url == "/"||url=="") {
                stream.Write(Encoding.UTF8.GetBytes("HTTP/1.1 200 OK\r\n"));
                stream.Write(Encoding.UTF8.GetBytes("Content-Type: text/plain\r\n"));
                stream.Write(Encoding.UTF8.GetBytes("Connection: close\r\n"));
                stream.Write(Encoding.UTF8.GetBytes("\r\n"));
                stream.Write(Encoding.UTF8.GetBytes("Test Message"));
            }
            stream.Close();
            client.Close();
        }

        public static void Stop() {
            RequestStop = true;
        }
    }
}
