using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise6
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string url = "https://nt106.uitiot.vn/auth/token";
            using var httpClient = new HttpClient();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var formData = new FormUrlEncodedContent(new[]
{
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });
            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(url, formData);
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung phản hồi
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Phân tích nội dung JSON
                    var json = JsonSerializer.Deserialize<JsonElement>(responseBody);
                    User.AccessToken = json.GetProperty("access_token").GetString();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    var errorJson = JsonSerializer.Deserialize<JsonElement>(errorResponse);
                    string detail = errorJson.GetProperty("detail").GetString();
                    MessageBox.Show(detail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sign = new SignUp();
            sign.ShowDialog();
        }
    }
}
