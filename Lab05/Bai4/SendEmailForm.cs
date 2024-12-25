using MimeKit;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace LoginForm
{
    public partial class SendEmailForm : Form
    {
        private MimeMessage _replyMessage;
        private string _loggedInEmail;
        private string _loggedInPassword;
        private string imagePath;
        private BodyBuilder bodyBuilder = new BodyBuilder();

        public SendEmailForm(MimeMessage replyMessage = null)
        {
            InitializeComponent();
            _replyMessage = replyMessage;

            if (_replyMessage != null)
            {
                txtTo.Text = GetSenderEmail(_replyMessage);
                txtSubject.Text = "Re: " + _replyMessage.Subject;
                richTextBoxBody.Text = "\n\n-----Original Message-----\n" + _replyMessage.TextBody;
            }
        }

        private string GetSenderEmail(MimeMessage message)
        {
            if (message?.From?.Mailboxes?.Any() == true)
            {
                return message.From.Mailboxes.First().Address;
            }
            return "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string to = txtTo.Text.Trim();
                string subject = txtSubject.Text.Trim();
                string body = richTextBoxBody.Text.Trim();
                string SMTPHost = "smtp.gmail.com";
                int SMTPPort = 465; // Cổng SSL/TLS

                var client = new MailKit.Net.Smtp.SmtpClient();
                client.Connect(SMTPHost, SMTPPort, true); // Kết nối với SSL/TLS (Implicit SSL)
                client.Authenticate(User.email, User.password); // Xác thực

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(txtSubject.Text, User.email));
                message.To.Add(new MailboxAddress("", to));
                message.Subject = subject;

                // Tạo BodyBuilder để thêm nội dung và hình ảnh
                var builder = new BodyBuilder();

                // Thêm hình ảnh nếu có
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    var image = builder.LinkedResources.Add(imagePath);
                    image.ContentId = MimeUtils.GenerateMessageId();

                    // Nội dung HTML với hình ảnh nhúng
                    builder.HtmlBody = $@"
                    <html>
                        <head>
                            <style>
                                body {{ font-family: Arial, sans-serif; line-height: 1.6; }}
                                h1 {{ color: Black; }}
                                p {{ color: Black; }}
                                .button {{
                                    background-color: #4CAF50;
                                    color: white;
                                    padding: 10px 20px;
                                    text-decoration: none;
                                    border-radius: 5px;
                                    display: inline-block;
                                }}
                            </style>
                        </head>
                        <body>
                            <h1>{subject}</h1>
                            <p>{body}</p>
                            <img src=""cid:{image.ContentId}"" alt=""Attached Image"" style=""max-width: 100%; height: auto;"" />
                            <p><a href='https://github.com/thanhtai2703/Labotory---NetworkProgramming' class='button'>Get Started</a></p>
                        </body>
                    </html>";
                }
                else
                {
                    // Nội dung HTML không có hình ảnh
                    builder.HtmlBody = $@"
                    <html>
                        <head>
                            <style>
                                body {{ font-family: Arial, sans-serif; line-height: 1.6; }}
                                h1 {{ color: Black; }}
                                p {{ color: Black; }}
                            </style>
                        </head>
                        <body>
                            <h1>{subject}</h1>
                            <p>{body}</p>
                            <p><a href='https://github.com/thanhtai2703/Labotory---NetworkProgramming' class='button'>Contact us</a></p>
                        </body>
                    </html>";
                }

                // Thêm phần nội dung vào email
                message.Body = builder.ToMessageBody();

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

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Chỉ định bộ lọc để chỉ hiển thị các tệp hình ảnh
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select an Image";

                // Nếu người dùng chọn OK
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName; // Lưu đường dẫn hình ảnh vào biến
                }
            }
        }
    }
}
