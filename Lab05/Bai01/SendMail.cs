using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Utils;

namespace Bai1
{
    public partial class subjectColor : Form
    {
        public subjectColor()
        {
            InitializeComponent();
        }
        private string from;
        private string to;
        private string subject; //Phần chủ đề mail
        private string body;//NỘi dung mail
        private string SUBJECTCOLOR = "black";//Màu chữ
        private string BODYCOLOR = "black";//Màu chữ
        private string appPassword;
        private string SMTPHost;
        private int SMTPPort;
        private string username;
        private string imagePath;

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                from = txtFrom.Text.Trim();
                to = txtTo.Text.Trim();
                subject = txtSubject.Text.Trim();
                body = txtBody.Text.Trim();
                appPassword = "lqnl xmwl gwuq ybps";
                SMTPHost = "smtp.gmail.com";
                SMTPPort = 465; // Cổng SSL/TLS
                username = txtFrom.Text;

                var client = new MailKit.Net.Smtp.SmtpClient();
                client.Connect(SMTPHost, SMTPPort, true);
                client.Authenticate(username, appPassword); 

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(txtSubject.Text, from));
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
                                h1 {{ color: {SUBJECTCOLOR}; }}
                                p {{ color: {BODYCOLOR}; }}
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
                            <p><a href='https://github.com/thanhtai2703/Labotory---NetworkProgramming' class='button'>Contact us</a></p>
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
                                h1 {{ color: {SUBJECTCOLOR}; }}
                                p {{ color: {BODYCOLOR}; }}
                            </style>
                        </head>
                        <body>
                            <h1>{subject}</h1>
                            <p>{body}</p>
                            <p><a href='https://github.com/thanhtai2703/Labotory---NetworkProgramming' class='button'>Contact us</a></p>
                        </body>
                    </html>";
                }
                message.Body = builder.ToMessageBody();
                client.Send(message);
                client.Disconnect(true);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chooseSubjectColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedColor = ColorTranslator.ToHtml(colorDialog1.Color);
                SUBJECTCOLOR = selectedColor;
                txtSubject.ForeColor = colorDialog1.Color;
            }
        }
        private void BodyColorChoose_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedColor = ColorTranslator.ToHtml(colorDialog1.Color);
                BODYCOLOR = selectedColor;
                txtBody.ForeColor = colorDialog1.Color;
            }
        }
        private void attachBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select an Image";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    txtImagePath.Text = imagePath;
                }
            }
        }
    }
}
