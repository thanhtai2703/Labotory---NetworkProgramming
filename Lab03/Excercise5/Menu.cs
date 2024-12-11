using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise5
{
    public partial class Menu : Form
    {
        private Client client;
        private Server server;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new Client();
            client.Show();
        }

        private void opServer_Click(object sender, EventArgs e)
        {
            server = new Server();
            server.Show();
        }
    }
}
