using System.Text.Json;
using System.Text;
using System.Windows.Forms;

namespace Excercise6
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {

            // URL endpoint của API đăng ký
            string url = "https://nt106.uitiot.vn/api/v1/user/signup";

            // Tạo HttpClient
            using var httpClient = new HttpClient();

            // Tạo nội dung body của POST request (JSON)
            var jsonContent = new
            {
                username = txtUsername.Text,
                email = txtEmail.Text,
                password = txtPassword.Text,
                first_name = txtFirstname.Text,
                last_name = txtLastname.Text,
                sex = getSex(),
                birthday = Date.Value.ToString("yyyy-MM-dd"),
                language = txtLanguage.Text,
                phone = txtPhone.Text,
            };
            string jsonString = JsonSerializer.Serialize(jsonContent);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            try
            {
                // Gửi yêu cầu POST
                HttpResponseMessage response = await httpClient.PostAsync(url, content);

                // Kiểm tra mã trạng thái phản hồi
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung phản hồi
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Đăng ký thành công:\n");
                    this.Close();
                }
                else
                {
                    // Xử lý lỗi
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    var errorJson = JsonSerializer.Deserialize<JsonElement>(errorResponse);

                    if (errorJson.TryGetProperty("detail", out JsonElement detail))
                    {
                        MessageBox.Show($"Đăng ký thất bại: {detail.GetString()}");
                    }
                    else
                    {
                        MessageBox.Show($"Đăng ký thất bại: {errorResponse}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        int getSex()
        {
            if (radioButton1.Checked) return 0;
            return 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPhone.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtEmail.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtLanguage.Clear();
            txtUsername.Clear();
            Date.DataBindings.Clear();
            txtPassword.Clear();
        }
    }
}
