using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKit;
namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void LogInbtn_Click(object sender, EventArgs e)
        {
            LogInbtn.Enabled = false; // Vô hiệu hóa nút LOGIN trong khi tải email
            try
            {
                await Task.Run(() =>
                {
                    using (var client = new ImapClient())
                    {
                        // Kết nối đến máy chủ IMAP
                        client.Connect("imap.gmail.com", 993, true);

                        // Xác thực
                        client.Authenticate(Emailtxt.Text, Passwordtxt.Text);

                        // Truy cập hộp thư "INBOX"
                        var inbox = client.Inbox;
                        inbox.Open(MailKit.FolderAccess.ReadOnly);

                        // Cập nhật thông tin Total và Recent
                        Invoke(new Action(() =>
                        {
                            lblTotal.Text = "Total: " + inbox.Count.ToString();
                            int recentCount = Math.Min(inbox.Count, 10);
                            lblRecent.Text = "Recent: " + recentCount.ToString();

                            // Xóa dữ liệu cũ trong ListView
                            listView1.Items.Clear();
                        }));

                        // Lấy và hiển thị email
                        for (int i = inbox.Count - 1; i >= inbox.Count - Math.Min(inbox.Count, 10); i--)
                        {
                            var message = inbox.GetMessage(i);

                            // Thêm email vào ListView trên UI thread
                            Invoke(new Action(() =>
                            {
                                var item = new ListViewItem(new[]
                                {
                            message.Subject ?? "(No Subject)",
                            message.From.ToString(),
                            message.Date.ToString("dd-MM-yyyy HH:mm:ss")
                        });
                                listView1.Items.Add(item);
                            }));
                        }

                        // Ngắt kết nối
                        client.Disconnect(true);
                    }
                });

                MessageBox.Show("Email loads successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LogInbtn.Enabled = true; // Kích hoạt lại nút LOGIN
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Hiển thị mật khẩu
                Passwordtxt.UseSystemPasswordChar = false;
            }
            else
            {
                // Ẩn mật khẩu
                Passwordtxt.UseSystemPasswordChar = true;
            }
        }
    }
}
