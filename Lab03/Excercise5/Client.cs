using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise5
{
    public partial class Client : Form
    {
        private readonly System.Windows.Forms.Button[] button;//Mảng lưu các ô
        private Socket clientSocket = null;
        private static int _buff_size = 2048;
        private Thread recvThread = null;
        private int pos;
        private string name;
        private bool isClicked = false;
        public Client()
        {
            InitializeComponent();
            button = new Button[30];
            for (int i = 0; i < button.Length; i++)
            {

                // Tạo button
                Button btn = new Button();

                // Thiết lập thuộc tính
                btn.Font = new Font("Arial", 16, FontStyle.Bold);
                btn.Text = $"{i}";
                btn.Size = new System.Drawing.Size(100, 100); // Kích thước: Rộng 80, Cao 30

                // Đặt vị trí: X và Y được tính toán để xếp các button thành lưới
                int x = 200 + (i % 6) * 100;
                int y = 50 + (i / 6) * 100;
                btn.Location = new System.Drawing.Point(x, y);
                // Gắn sự kiện Click
                btn.Click += button_Click;
                button[i] = btn;
                button[i].Tag = i;
                // Thêm button vào form
                this.Controls.Add(btn);
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {

                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.Connect(IPAddress.Parse(textBox1.Text), 11000);
                recvThread = new Thread(() => this.readingClientSocket());
                recvThread.Start();
                string message = "Connect";
                clientSocket.Send(Encoding.UTF8.GetBytes(message));
                connectBtn.Text = "Connected";
                connectBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void readingClientSocket()
        {
            byte[] buffer = new byte[_buff_size];
            while (clientSocket != null && clientSocket.Connected)
            {
                if (clientSocket.Available > 0)
                {
                    StringBuilder sb = new StringBuilder();

                    while (clientSocket.Available > 0)
                    {
                        int bRead = clientSocket.Receive(buffer, _buff_size, SocketFlags.None);
                        sb.Append(Encoding.UTF8.GetString(buffer, 0, bRead));

                    }

                    string receivedStr = sb.ToString();
                    string[] parts = receivedStr.Split(';');
                    if (parts[0] == "Update")
                    {
                        string[] temp = parts[1].Split(':');
                        foreach (var item in temp)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                if (item != "")
                                {
                                    string[] info = item.Split('.');
                                    button[Convert.ToInt32(info[0])].Enabled = false;
                                    button[Convert.ToInt32(info[0])].BackColor = Color.Gray;
                                    button[Convert.ToInt32(info[0])].Text = info[1];
                                }
                            });

                        }

                    }
                    else if (parts[0] == "Update 2")
                    {
                        string[] temp = parts[1].Split(':');
                        foreach (var item in temp)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                if (item != "")
                                {
                                    button[Convert.ToInt32(item)].Enabled = false;
                                    button[Convert.ToInt32(item)].BackColor = Color.Blue;
                                    button[Convert.ToInt32(item)].Text = item;
                                }
                            });

                        }
                    }
                    else if (parts[0] == "Choose")
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            button[Convert.ToInt32(parts[2])].Text = parts[1];
                            button[Convert.ToInt32(parts[2])].Enabled = false;
                            button[Convert.ToInt32(parts[2])].BackColor = Color.Blue;
                        });
                    }
                    else if (parts[0] == "Cancel")
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            button[Convert.ToInt32(parts[1])].Text = parts[1];
                            button[Convert.ToInt32(parts[1])].Enabled = true;
                            button[Convert.ToInt32(parts[1])].BackColor = Color.White;
                        });
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            button[Convert.ToInt32(parts[1])].Text = parts[0];
                            button[Convert.ToInt32(parts[1])].BackColor = Color.Gray;
                            button[Convert.ToInt32(parts[1])].Enabled = false;
                        });
                    }
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                MessageBox.Show("plesae enter your name");
                return;
            }
            if (isClicked == false)
            {
                isClicked = true;
                Button clicked = sender as Button;
                name = nameTxt.Text.ToString();
                pos = (int)clicked.Tag;
                string message = "Choose" + ";" + name + ";" + pos.ToString();
                clientSocket.Send(Encoding.UTF8.GetBytes(message));
            }
            else
            {
                string message = "Cancel" + ";" + pos.ToString();
                clientSocket.Send(Encoding.UTF8.GetBytes(message));
                Button clicked = sender as Button;
                name = nameTxt.Text.ToString();
                pos = (int)clicked.Tag;
                message = "Choose" + ";" + name + ";" + pos.ToString();
                clientSocket.Send(Encoding.UTF8.GetBytes(message));
            }

        }

        private void Book_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == null)
            {
                MessageBox.Show("plesae enter your name");
                return;
            }
            isClicked = false;
            try
            {
                name = nameTxt.Text.ToString();
                string message = name + ";" + pos.ToString();
                clientSocket.Send(Encoding.UTF8.GetBytes(message));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            string message = "Disconnected;";
            clientSocket.Send(Encoding.UTF8.GetBytes(message));
            clientSocket.Shutdown(SocketShutdown.Both);
            this.Close();
        }
    }
}
