using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MimeKit;

namespace LoginForm
{
    public partial class ReadEmailForm : Form
    {
        private MimeMessage _message;

        public ReadEmailForm(MimeMessage message)
        {
            InitializeComponent();
            _message = message;
            DisplayEmail();
        }

        private void DisplayEmail()
        {
            webBrowser1.DocumentText = _message.HtmlBody;
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            var sendEmailForm = new SendEmailForm(_message);
            sendEmailForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
