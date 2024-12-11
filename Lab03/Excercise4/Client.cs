using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Excercise4
{
    public partial class Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 8080);

                stream = client.GetStream();

                string connectMessage = $"CONNECT:{txtName.Text.Trim()}";
                byte[] buffer = Encoding.UTF8.GetBytes(connectMessage);
                stream.Write(buffer, 0, buffer.Length);

                Task.Run(() => ReceiveMessages());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect: {ex.Message}");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (stream != null && stream.CanWrite)
            {
                string message = $"{txtName.Text}: {txtMessage.Text}";
                byte[] buffer = Encoding.UTF8.GetBytes(message);

                // Hiển thị tin nhắn của chính Client trên txtMessages
                txtMessages.AppendText(message + Environment.NewLine);

                // Gửi tin nhắn đến Server
                stream.Write(buffer, 0, buffer.Length);

                // Xóa nội dung trong txtMessage
                txtMessage.Clear();
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int byteCount;

            while ((byteCount = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, byteCount);

                if (message.StartsWith("CLIENTLIST:"))
                {
                    string clientList = message.Replace("CLIENTLIST:", "").Trim();
                    string[] clients = clientList.Split(';')
                                                 .Where(c => !string.IsNullOrWhiteSpace(c))
                                                 .ToArray();

                    Invoke((Action)(() =>
                    {
                        lstClients.Items.Clear();
                        foreach (var clientInfo in clients)
                        {
                            lstClients.Items.Add(clientInfo);
                        }
                    }));
                }
                else
                {
                    Invoke((Action)(() =>
                    {
                        txtMessages.AppendText(message + Environment.NewLine);
                    }));
                }
            }
        }

        private void btnSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn Enter tạo dòng mới trong TextBox
                btnSend.PerformClick();    // Kích hoạt sự kiện Click của btnSend
            }
        }
        private void btnSendPrivate_Click(object sender, EventArgs e)
        {
            if (stream != null && stream.CanWrite && lstClients.SelectedItem != null)
            {
                string selectedClient = lstClients.SelectedItem.ToString().Split('(')[0].Trim(); // Lấy tên Client
                string message = $"PRIVATE:{selectedClient}:{txtMessage.Text}";

                byte[] buffer = Encoding.UTF8.GetBytes(message);

                // Gửi tin nhắn đến Server
                stream.Write(buffer, 0, buffer.Length);

                // Hiển thị tin nhắn trong txtMessages (chỉ phía mình thấy)
                txtMessages.AppendText($"[Private to {selectedClient}] {txtMessage.Text}{Environment.NewLine}");

                // Xóa nội dung trong txtMessage
                txtMessage.Clear();
            }
            else
            {
                MessageBox.Show("Please select a client from the list or ensure you are connected.");
            }
        }

    }
}

