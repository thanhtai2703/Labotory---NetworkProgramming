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
using MailKit;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private int currentPage = 0; // Trang hiện tại (bắt đầu từ 0)
        private int emailsPerPage = 10; // Số email mỗi trang
        private int totalEmails = 0; // Tổng số email

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadEmailsByPage(ImapClient client, int page)
        {
            var inbox = client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);

            // Tính toán email bắt đầu và kết thúc cho trang hiện tại
            int startIndex = inbox.Count - 1 - (page * emailsPerPage);
            int endIndex = Math.Max(startIndex - emailsPerPage + 1, 0);

            // Làm sạch ListView trước khi thêm dữ liệu mới
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new Action(() =>
                {
                    listView1.Items.Clear();
                }));
            }
            else
            {
                listView1.Items.Clear();
            }

            for (int i = startIndex; i >= endIndex; i--)
            {
                var message = inbox.GetMessage(i);

                var item = new ListViewItem(new[]
                {
            message.Subject ?? "(No Subject)",
            message.From.ToString(),
            message.Date.ToString("yyyy-MM-dd HH:mm:ss")
        });

                // Thêm item vào ListView
                if (listView1.InvokeRequired)
                {
                    listView1.Invoke(new Action(() =>
                    {
                        listView1.Items.Add(item);
                    }));
                }
                else
                {
                    listView1.Items.Add(item);
                }
            }

            // Cập nhật tổng số email và trạng thái phân trang
            totalEmails = inbox.Count;

            if (lblTotal.InvokeRequired)
            {
                lblTotal.Invoke(new Action(() =>
                {
                    lblTotal.Text = $"Total: {totalEmails}";
                }));
            }
            else
            {
                lblTotal.Text = $"Total: {totalEmails}";
            }

            int recentCount = Math.Min(inbox.Count, 10);
            if (lblRecent.InvokeRequired)
            {
                lblRecent.Invoke(new Action(() =>
                {
                    lblRecent.Text = "Recent: " + recentCount.ToString();
                }));
            }
            else
            {
                lblRecent.Text = "Recent: " + recentCount.ToString();
            }

            if (lblPage.InvokeRequired)
            {
                lblPage.Invoke(new Action(() =>
                {
                    lblPage.Text = $"Page: {currentPage + 1} / {Math.Ceiling((double)totalEmails / emailsPerPage)}";
                }));
            }
            else
            {
                lblPage.Text = $"Page: {currentPage + 1} / {Math.Ceiling((double)totalEmails / emailsPerPage)}";
            }
        }
        private async void LogInbtn_Click(object sender, EventArgs e)
        {
            LogInbtn.Enabled = false;

            try
            {
                using (var client = new ImapClient())
                {
                    await Task.Run(() =>
                    {
                        client.Connect("imap.gmail.com", 993, true);
                        client.Authenticate(Emailtxt.Text, Passwordtxt.Text);

                        // Reset trạng thái phân trang
                        currentPage = 0;

                        // Tải email của trang đầu tiên
                        LoadEmailsByPage(client, currentPage);

                        client.Disconnect(true);
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LogInbtn.Enabled = true;
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                await ReloadEmails();
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if ((currentPage + 1) * emailsPerPage < totalEmails)
            {
                currentPage++;
                await ReloadEmails();
            }
        }

        private async Task ReloadEmails()
        {
            using (var client = new ImapClient())
            {
                await Task.Run(() =>
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(Emailtxt.Text, Passwordtxt.Text);

                    LoadEmailsByPage(client, currentPage);

                    client.Disconnect(true);
                });
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
