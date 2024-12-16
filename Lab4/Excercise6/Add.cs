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
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm thành công:\n");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    var errorJson = JsonSerializer.Deserialize<JsonElement>(responseBody);

                    if (errorJson.TryGetProperty("detail", out JsonElement detail))
                    {
                        MessageBox.Show($"Thêm không thành công: {detail.GetString()}");
                    }
                    else
                    {
                        MessageBox.Show($"Thêm không thành công: {responseBody}");
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
