using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise6
{
    public partial class Menu : Form
    {
        private List<JsonElement> danhSachMonAn;
        private int type = 0;
        public Menu()
        {
            InitializeComponent();
            GetUserInfo();
        }
        public async Task GetUserInfo()
        {
            string url;
            if (type == 0) url = "https://nt106.uitiot.vn/api/v1/monan/all"; // URL API để lấy thông tin người dùng
            else url = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";

            using var httpClient = new HttpClient();

            // Thêm JWT vào Authorization header
            var payload = new
            {
                current = 1,
                pagesize = 5
            };
            httpClient.DefaultRequestHeaders.Add("Authorization", $"bearer {User.Instance.AccessToken}");
            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                // Kiểm tra xem yêu cầu có thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var jsonData = JsonSerializer.Deserialize<JsonElement>(responseBody);

                    danhSachMonAn = jsonData.GetProperty("data").EnumerateArray().ToList();
                    getPanel();
                }
                else
                {
                    // Nếu có lỗi, in ra mã lỗi và thông tin lỗi
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(errorResponse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getPanel()
        {
            for (int i = 0; i < danhSachMonAn.Count(); i++)
            {
                var monan = danhSachMonAn[i];
                var foodPanel = CreateFoodItem(monan.GetProperty("hinh_anh").GetString(), monan.GetProperty("ten_mon_an").GetString(),
                                                monan.GetProperty("gia").GetDouble(), monan.GetProperty("dia_chi").GetString(), monan.GetProperty("nguoi_dong_gop").GetString(), i);

                if(type == 0) flowLayoutPanel1.Controls.Add(foodPanel);
                else flowLayoutPanel2.Controls.Add(foodPanel);
            }
        }
        private Panel CreateFoodItem(string imagePath, string foodName, double price, string address, string contributor, int index)
        {
            // Panel chứa từng mục món ăn
            Panel foodPanel = new Panel
            {
                Size = new Size(400, 100), // Kích thước của một mục
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)

            };


            //PictureBox hiển thị ảnh món ăn
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(80, 80),
                Location = new Point(10, 10),
                ImageLocation = imagePath, // Đường dẫn ảnh
                SizeMode = PictureBoxSizeMode.Zoom // Phóng to hình ảnh vừa khung
            };

            // Label hiển thị tên món ăn
            Label nameLabel = new Label
            {
                Text = foodName,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(100, 10),
                AutoSize = true
            };

            // Label hiển thị giá
            Label priceLabel = new Label
            {
                Text = $"Giá: {price} VNĐ",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Location = new Point(100, 35),
                AutoSize = true
            };

            // Label hiển thị địa chỉ
            Label addressLabel = new Label
            {
                Text = $"Địa chỉ: {address}",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Location = new Point(100, 55),
                AutoSize = true
            };

            // Label hiển thị người đóng góp
            Label contributorLabel = new Label
            {
                Text = $"Đóng góp: {contributor}",
                Font = new Font("Arial", 10, FontStyle.Italic),
                Location = new Point(100, 75),
                AutoSize = true
            };

            // Thêm các control vào Panel
            foodPanel.Controls.Add(pictureBox);
            foodPanel.Controls.Add(nameLabel);
            foodPanel.Controls.Add(priceLabel);
            foodPanel.Controls.Add(addressLabel);
            foodPanel.Controls.Add(contributorLabel);
            foodPanel.Tag = index;
            //foodPanel.Click += panel_Click;
            return foodPanel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                type = 0;
                flowLayoutPanel1.Controls.Clear();
                GetUserInfo();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                type = 1;
                flowLayoutPanel2.Controls.Clear();
                GetUserInfo();
            }
        }
    }
}
