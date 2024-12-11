using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise1
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            //Lấy địa chỉ IP từ textbox và chuyển thành kiểu IPAddress
            IPAddress ipadd = IPAddress.Parse(txtIP.Text);
            int port = Convert.ToInt32(txtPort.Text);
            IPEndPoint ipend = new IPEndPoint(ipadd, port);
            //Chuyển chuỗi dữ liệu nhập sang kiểu byte
            Byte[] sendBytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
            //Gởi dữ liệu đến IPEndPoint đã định nghĩa địa chỉ IP và Port
            udpClient.Send(sendBytes, sendBytes.Length, ipend);
            //Xóa dữ liệu vừa gửi ở ô nhập
            richTextBox1.Text = "";
        }
    }
}
