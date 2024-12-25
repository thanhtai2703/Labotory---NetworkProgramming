using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                // Nếu CheckBox được chọn, hiện mật khẩu
                txtPassword.PasswordChar = '\0';  // '\0' có nghĩa là không có ký tự đặc biệt
            }
            else
            {
                // Nếu CheckBox không được chọn, ẩn mật khẩu
                txtPassword.PasswordChar = '*';  // Hiển thị '*' để ẩn mật khẩu
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User.email = txtEmail.Text;
            User.password = txtPassword.Text;
            try
            {
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                client.Authenticate(User.email, User.password);
                MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InboxForm inboxForm = new InboxForm(client);
                inboxForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
