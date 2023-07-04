using System;
using System.Windows.Forms;

namespace RailMapGenerator.Utils.Server {
    public partial class ServerHud : Form {
        private readonly RailMap map;
        public ServerHud(RailMap map) {
            this.InitializeComponent();
            this.map = map;
        }

        private void ServerHud_Load(object sender, EventArgs e) {
            LocalServer.StartServer(this.map, (message) => {
                this.textBox1.Invoke(() => {
                    this.textBox1.Text += message + "\r\n";
                });
            });
        }

        private void ServerHud_FormClosing(object sender, FormClosingEventArgs e) {
            LocalServer.server.Stop();
        }
    }
}
