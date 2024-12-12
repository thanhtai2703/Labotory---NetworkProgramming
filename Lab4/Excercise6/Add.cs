using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise6
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string url = "https://nt106.uitiot.vn/api/v1/monan/add";
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"bearer {User.Instance.AccessToken}");
            var jsonContent = new
            {
                ten_mon_an = txtName.Text,
                gia = Convert.ToDouble(txtPrice.Text),
                hinh_anh = txtPicture.Text,
                mo_ta = txtDescription.Text,
                dia_chi = txtAddress.Text,
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
                    MessageBox.Show("Thêm thành công:\n");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Xử lý lỗi
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    var errorJson = JsonSerializer.Deserialize<JsonElement>(errorResponse);

                    if (errorJson.TryGetProperty("detail", out JsonElement detail))
                    {
                        MessageBox.Show($"Thất bại: {detail.GetString()}");
                    }
                    else
                    {
                        MessageBox.Show($"thất bại: {errorResponse}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
