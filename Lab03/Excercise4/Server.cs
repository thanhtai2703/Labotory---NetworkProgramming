using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Excercise4
{
    public partial class Server : Form
    {
        private TcpListener listener;
        private Dictionary<TcpClient, string> clientNames = new Dictionary<TcpClient, string>();
        private List<TcpClient> clients = new List<TcpClient>();
        private CancellationTokenSource cts = new CancellationTokenSource();
        private List<string> messageHistory = new List<string>();


        public Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();

            AppendLog("Server started. Waiting for clients...");
            Task.Run(() => AcceptClientsAsync(cts.Token));
        }

        private async Task AcceptClientsAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var client = await listener.AcceptTcpClientAsync();
                    clients.Add(client);

                    Task.Run(() => HandleClientAsync(client, token));
                }
                catch (Exception ex)
                {
                    AppendLog($"Error accepting client: {ex.Message}");
                }
            }
        }

        private async Task HandleClientAsync(TcpClient client, CancellationToken token)
        {
            var stream = client.GetStream();
            byte[] buffer = new byte[1024];

            // Gửi lịch sử tin nhắn cho Client mới kết nối
            foreach (string historyMessage in messageHistory)
            {
                byte[] historyBuffer = Encoding.UTF8.GetBytes(historyMessage + Environment.NewLine);
                await stream.WriteAsync(historyBuffer, 0, historyBuffer.Length, token);

            }
            // UpdateClientList();
            while (!token.IsCancellationRequested && client.Connected)
            {
                try
                {
                    int byteCount = await stream.ReadAsync(buffer, 0, buffer.Length, token);
                    if (byteCount <= 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, byteCount);

                    if (message.StartsWith("CONNECT:"))
                    {
                        string clientName = message.Replace("CONNECT:", "").Trim();
                        clientNames[client] = clientName;
                        UpdateClientList();
                        Broadcast($"{clientName} has joined.{Environment.NewLine}", null);
                    }
                    else if (message.StartsWith("PRIVATE:"))
                    {
                        string[] parts = message.Split(':');
                        if (parts.Length >= 3)
                        {
                            string targetClientName = parts[1];
                            string privateMessage = string.Join(":", parts.Skip(2).ToArray());


                            // Tìm Client mục tiêu
                            var targetClient = clientNames.FirstOrDefault(c => c.Value == targetClientName).Key;
                            if (targetClient != null)
                            {
                                string formattedMessage = $"[Private from {clientNames[client]}] {privateMessage}{Environment.NewLine}";

                                try
                                {
                                    byte[] privateBuffer = Encoding.UTF8.GetBytes(formattedMessage);
                                    targetClient.GetStream().Write(privateBuffer, 0, privateBuffer.Length);
                                }
                                catch
                                {
                                    AppendLog($"Failed to send private message to {targetClientName}");
                                }
                            }
                            else
                            {
                                // Thông báo nếu không tìm thấy Client
                                AppendLog($"Client '{targetClientName}' not found for private message.");
                            }
                        }
                    }
                    else
                    {
                        // Lưu tin nhắn vào lịch sử
                        messageHistory.Add(message);

                        // Gửi tin nhắn cho tất cả các Client
                        Broadcast(message, client);
                    }
                }
                catch (Exception ex)
                {
                    AppendLog($"Error handling client: {ex.Message}");
                    break;
                }
            }

            // Xử lý khi Client ngắt kết nối
            clients.Remove(client);
            if (clientNames.ContainsKey(client))
            {
                string clientName = clientNames[client];
                clientNames.Remove(client);
                Broadcast($"{clientName} has left.{Environment.NewLine}", null);
            }

            UpdateClientList();
        }

        private void Broadcast(string message, TcpClient excludeClient)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            foreach (var client in clients)
            {
                if (client != excludeClient)
                {
                    try
                    {
                        var stream = client.GetStream();
                        stream.Write(buffer, 0, buffer.Length);
                    }
                    catch { }
                }
            }

            AppendLog(message);
        }

        private void UpdateClientList()
        {
            string clientList = "CLIENTLIST:";

            foreach (var client in clientNames.Keys)
            {
                IPEndPoint endPoint = (IPEndPoint)client.Client.RemoteEndPoint;
                string ip = endPoint.Address.ToString();
                int port = endPoint.Port;

                clientList += $"{clientNames[client]};{Environment.NewLine}";
            }

            Broadcast(clientList, null);

            Invoke((Action)(() =>
            {
                lstClients.Items.Clear();
                foreach (var client in clientNames.Keys)
                {
                    IPEndPoint endPoint = (IPEndPoint)client.Client.RemoteEndPoint;
                    string ip = endPoint.Address.ToString();
                    int port = endPoint.Port;

                    lstClients.Items.Add($"{clientNames[client]} ({ip}:{port}){Environment.NewLine}");
                }
            }));
        }

        private void AppendLog(string message)
        {
            Invoke((Action)(() =>
            {
                txtLog.AppendText(message + Environment.NewLine);
            }));
        }
    }
}
