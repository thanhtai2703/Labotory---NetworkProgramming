using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise1
{
    public partial class Server : Form
    {
        private UdpClient server;
        private Thread serverThread;
        public Server()
        {
            InitializeComponent();
        }
        private void ReceiveData()
        {
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0); // Địa chỉ IP và cổng bất kỳ
                while (true)
                {
                    byte[] data = server.Receive(ref remoteEP); // Nhận dữ liệu
                    string message = Encoding.UTF8.GetString(data); // Giải mã dữ liệu

                    // Tạo thông điệp hiển thị
                    string displayMessage = $"{remoteEP.Address}: {message} {Environment.NewLine}";

                    // Hiển thị thông điệp trên giao diện
                    Invoke(new Action(() =>
                    {
                        richTextBox1.Text += displayMessage;
                    }));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }));
            }
        }
        private void StartServer()
        {
            try
            {
                int port = int.Parse(txtPort.Text); // Lấy cổng từ textbox
                server = new UdpClient(port); // Tạo UDP server
                serverThread = new Thread(new ThreadStart(ReceiveData)); // Khởi chạy luồng
                serverThread.IsBackground = true;
                serverThread.Start();
                MessageBox.Show("Server is listening on port " + port, "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Hàm nhận dữ liệu
        private void btnListen_Click(object sender, EventArgs e)
        {
            StartServer();
        }

    }
}
