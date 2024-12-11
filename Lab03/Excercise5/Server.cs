using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Excercise5
{
    public partial class Server : Form
    {
        private Socket serverSocket = null;
        private bool listening = false;
        private bool started = false;
        private int _port = 11000;
        private static int _buff_size = 2048;
        private byte[] _buffer = new byte[_buff_size];
        private Thread serverThread = null;
        private List<Socket> clientSockets = new List<Socket>();
        private readonly Button[] button;
        private readonly List<(int, string)> owner = new List<(int, string)> { };
        private int num = 30;
        public Server()
        {
            InitializeComponent();
            serverSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            button = new Button[30];
            for (int i = 0; i < button.Length; i++)
            {

                // Tạo button
                Button btn = new Button();

                // Thiết lập thuộc tính
                btn.Text = $"{i}";
                btn.Font = new Font("Arial", 16, FontStyle.Bold);
                btn.Size = new System.Drawing.Size(100, 100); // Kích thước: Rộng 80, Cao 30

                // Đặt vị trí: X và Y được tính toán để xếp các button thành lưới
                int x = 250 + (i % 6) * 100;
                int y = 50 + (i / 6) * 100;
                btn.Location = new System.Drawing.Point(x, y);
                // Gắn sự kiện Click
                button[i] = btn;
                button[i].Tag = i;
                // Thêm button vào form
                this.Controls.Add(btn);
            }

            for (int i = 0; i < button.Length; i++)
            {
                owner.Add((i, "None"));
            }

        }
        private void listenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (started)
                {
                    // Dừng lắng nghe và đóng các socket client
                    started = false;
                    listening = false;

                    // Đóng tất cả các client sockets
                    foreach (var client in clientSockets)
                    {
                        client.Shutdown(SocketShutdown.Both);
                        client.Close();
                    }
                    clientSockets.Clear();

                    // Đóng socket server
                    if (serverSocket != null)
                    {
                        serverSocket.Close();
                    }

                    // Cập nhật nút Listen
                    listenBtn.Invoke((MethodInvoker)delegate
                    {
                        listenBtn.Text = "LISTEN";
                        listenBtn.BackColor = System.Drawing.Color.White;
                    });
                }
                else
                {
                    serverThread = new Thread(() => this.listen());
                    serverThread.IsBackground = true;
                    serverThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listen()
        {
            try
            {
                // Tạo socket server và bắt đầu lắng nghe
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, _port));
                serverSocket.Listen(20);

                started = true;
                listening = true;

                // Cập nhật trạng thái nút Listen
                listenBtn.Invoke((MethodInvoker)delegate
                {
                    listenBtn.Text = "Đang lắng nghe kết nối";
                    listenBtn.BackColor = System.Drawing.Color.Blue;
                });

                while (listening)
                {
                    try
                    {
                        Socket client = serverSocket.Accept();
                        clientSockets.Add(client);

                        Thread clientThread = new Thread(() => this.readingClientSocket(client));
                        clientThread.IsBackground = true;
                        clientThread.Start();
                    }
                    catch (SocketException se)
                    {
                        // Kiểm tra nếu server đã đóng và bỏ qua lỗi
                        if (se.SocketErrorCode != SocketError.Interrupted)
                        {
                            MessageBox.Show(se.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readingClientSocket(Socket client)
        {
            byte[] buffer = new byte[_buff_size];
            try
            {
                while (client.Connected)
                {
                    if (client.Available > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        while (client.Available > 0)
                        {
                            int bRead = client.Receive(buffer, _buff_size, SocketFlags.None);
                            sb.Append(Encoding.UTF8.GetString(buffer, 0, bRead));
                        }

                        string receivedStr = sb.ToString();
                        string[] parts = receivedStr.Split(';');
                        if (parts[0] == "Connect")
                        {
                            string update = "Update" + ";";
                            foreach (var item in owner)
                            {
                                if (item.Item2 != "None")
                                    update = update + item.Item1.ToString() + "." + item.Item2.ToString() + ":";
                            }
                            if (update != "Update;")
                            {
                                foreach (Socket s in clientSockets)
                                {
                                    s.Send(Encoding.UTF8.GetBytes(update));
                                }
                            }
                            Thread.Sleep(50);
                            string update2 = "Update 2;";
                            foreach (var item in button)
                            {
                                if (item.BackColor == Color.Blue)
                                {
                                    update2 = update2 + item.Tag + ":";
                                }
                            }
                            if (update2 != "Update 2;")
                            {
                                foreach (Socket s in clientSockets)
                                {
                                    s.Send(Encoding.UTF8.GetBytes(update2));
                                }
                            }
                        }
                        else if (parts[0] == "Cancel")
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                button[Convert.ToInt32(parts[1])].Text = parts[1];
                                button[Convert.ToInt32(parts[1])].BackColor = Color.White;
                                button[Convert.ToInt32(parts[1])].Enabled = true;
                                owner[Convert.ToInt32(parts[1])] = (Convert.ToInt32(parts[1]), "None");
                            });
                            foreach (Socket s in clientSockets)
                            {
                                s.Send(Encoding.UTF8.GetBytes(receivedStr));
                            }
                        }
                        else if (parts[0] == "Choose")
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                label2.Text = (30 - num).ToString();
                                label4.Text = num.ToString();
                                button[Convert.ToInt32(parts[2])].Text = parts[1];
                                button[Convert.ToInt32(parts[2])].BackColor = System.Drawing.Color.Blue;
                                button[Convert.ToInt32(parts[2])].Enabled = false;

                            });

                            foreach (Socket s in clientSockets)
                            {
                                s.Send(Encoding.UTF8.GetBytes(receivedStr));
                            }
                        }
                        else if (parts[0] == "Disconnected")
                        {
                            client.Shutdown(SocketShutdown.Both);
                            client.Close();
                            clientSockets.Remove(client);
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                num--;
                                label2.Text = (30 - num).ToString();
                                label4.Text = num.ToString();
                                button[Convert.ToInt32(parts[1])].Text = parts[0];
                                button[Convert.ToInt32(parts[1])].Enabled = false;
                                button[Convert.ToInt32(parts[1])].BackColor = Color.Gray;
                                owner[Convert.ToInt32(parts[1])] = (Convert.ToInt32(parts[1]), parts[0]);

                            });

                            foreach (Socket s in clientSockets)
                            {
                                s.Send(Encoding.UTF8.GetBytes(receivedStr));
                            }
                        }
                    }
                }
            }
            catch (SocketException se)
            {
                // Kiểm tra lỗi khi client ngắt kết nối
                if (se.SocketErrorCode != SocketError.Interrupted)
                {
                    MessageBox.Show(se.Message);
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
