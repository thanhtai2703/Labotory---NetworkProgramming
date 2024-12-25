using MailKit.Net.Imap;
using MailKit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class InboxForm : Form
    {
        private ImapClient _client;

        public InboxForm(ImapClient client)
        {
            InitializeComponent();
            _client = client;
            LoadEmails();
        }

        private void LoadEmails()
        {
            if (!_client.IsConnected || !_client.IsAuthenticated)
            {
                MessageBox.Show("Kết nối đến máy chủ đã mất. Vui lòng đăng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var inbox = _client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            var messages = inbox.Fetch(0, -1, MessageSummaryItems.Envelope);

            if (messages == null || !messages.Any())
            {
                MessageBox.Show("Hộp thư đến không có email.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var message in messages)
            {
                lstEmails.Items.Add(message.Envelope.Subject ?? "(Không có tiêu đề)");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (lstEmails.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một email để đọc.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSubject = lstEmails.SelectedItem.ToString();
            var inbox = _client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            var messages = inbox.Fetch(0, -1, MessageSummaryItems.Envelope);

            foreach (var message in messages)
            {
                if (message.Envelope.Subject == selectedSubject)
                {
                    try
                    {
                        var fullMessage = inbox.GetMessage(message.Index);
                        var readEmailForm = new ReadEmailForm(fullMessage);
                        readEmailForm.Show();
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể đọc email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (_client.IsConnected)
            {
                _client.Disconnect(true);
            }
            this.Close();
        }
    }
}
