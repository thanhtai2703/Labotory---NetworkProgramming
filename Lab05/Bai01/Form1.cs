using MailKit.Net.Smtp;
using MimeKit;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập thông tin từ giao diện
                string from = txtFrom.Text.Trim();
                string to = txtTo.Text.Trim();
                string subject = txtSubject.Text.Trim();
                string body = txtBody.Text.Trim();

                // Mật khẩu ứng dụng của email người gửi
                string appPassword = "lqnl xmwl gwuq ybps"; // Thay bằng mật khẩu ứng dụng
                string SMTPHost = "smtp.gmail.com";
                int SMTPPort = 465; // Cổng SSL/TLS
                string username = txtFrom.Text;

                var client = new MailKit.Net.Smtp.SmtpClient();
                client.Connect(SMTPHost, SMTPPort, true); // Kết nối với SSL/TLS (Implicit SSL)
                client.Authenticate(username, appPassword); // Xác thực

                // Tạo email
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Your Company", from));
                message.To.Add(new MailboxAddress("Customer", to));
                message.Subject = subject;

                // Nội dung HTML
                string richTextContent = txtBody.Text;
                message.Body = new TextPart("html")
                {
                    Text = @"
            <html>
                <head>
                    <style>
                        body { font-family: Arial, sans-serif; line-height: 1.6; }
                        h1 { color: #f39c12; }
                        .button {
                            background-color: #4CAF50;
                            color: white;
                            padding: 10px 20px;
                            text-decoration: none;
                            border-radius: 5px;
                            display: inline-block;
                        }
                    </style>
                </head>
                <body>
                    <h1>Welcome to Our Service!</h1>
                    <p>We are excited to have you on board. Here’s what you can do:</p>
                    <ul>
                        <li>Explore our <b>features</b></li>
                        <li>Connect with others</li>
                        <li>Enjoy exclusive benefits</li>
                    </ul>
                    <p><a href='https://example.com' class='button'>Get Started</a></p>
                    <p>Thank you for joining us!</p>
                </body>
            </html>"
                };

                // Gửi email
                client.Send(message);
                client.Disconnect(true);

                // Hiển thị thông báo thành công
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Thông báo lỗi
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
