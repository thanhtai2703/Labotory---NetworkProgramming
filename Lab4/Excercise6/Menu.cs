using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise6
{
    public partial class Menu : Form
    {
        private List<MonAn> danhSachMonAn = new List<MonAn> ();
        private int type = 0; //Xác định đang ở tab nào
        public Menu()
        {
            InitializeComponent();
            GetUserInfo();
        }
        public async Task GetUserInfo()
        {
            string url;
            if (type == 0) url = "https://nt106.uitiot.vn/api/v1/monan/all";
            else url = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";

            using var httpClient = new HttpClient();
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
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var jsonData = JsonSerializer.Deserialize<JsonElement>(responseBody);
                    string responeData  = jsonData.GetProperty("data").GetRawText();
                    danhSachMonAn = JsonSerializer.Deserialize<List<MonAn>>(responeData);
                    getPanel();
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(errorResponse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getPanel() //tạo panel lưu danh sách món ăn
        {
            for (int i = 0; i < danhSachMonAn.Count(); i++)
            {
                var monAn = danhSachMonAn[i];
                var foodPanel = CreateFoodItem(monAn.HinhAnh,monAn.TenMonAn,monAn.Gia,monAn.DiaChi,monAn.NguoiDongGop, i);
                if (type == 0) flowLayoutPanel1.Controls.Add(foodPanel);
                else flowLayoutPanel2.Controls.Add(foodPanel);
            }
        }
        public Panel CreateFoodItem(string imagePath, string foodName, double price, string address, string contributor, int index)
        {
            Panel foodPanel = new Panel
            {
                Size = new Size(550, 150),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)

            };
            //PictureBox hiển thị ảnh món ăn
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(100, 150),
                Location = new Point(10, 10),
                ImageLocation = imagePath,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Label nameLabel = new Label
            {
                Text = foodName,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(120, 10),
                AutoSize = true
            };
            Label priceLabel = new Label
            {
                Text = $"Giá: {price} VNĐ",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Location = new Point(120, 35),
                AutoSize = true
            };
            Label addressLabel = new Label
            {
                Text = $"Địa chỉ: {address}",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Location = new Point(120, 55),
                AutoSize = true
            };
            Label contributorLabel = new Label
            {
                Text = $"Đóng góp: {contributor}",
                Font = new Font("Arial", 10, FontStyle.Italic),
                Location = new Point(120, 75),
                AutoSize = true
            };
            foodPanel.Controls.Add(pictureBox);
            foodPanel.Controls.Add(nameLabel);
            foodPanel.Controls.Add(priceLabel);
            foodPanel.Controls.Add(addressLabel);
            foodPanel.Controls.Add(contributorLabel);
            foodPanel.Tag = index; //chỉ số của panel
            foodPanel.Click += panel_Click; //Gán sự kiện click cho từng panel
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

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(0, danhSachMonAn.Count);
            MonAn x = danhSachMonAn[index];
            //int id,string name, string description, double gia, string diachi,string picture,string donggop
            Panel food = CreateFoodItem(x.HinhAnh, x.TenMonAn, x.Gia, x.DiaChi, x.NguoiDongGop, index);
            food.Click -= panel_Click; //Bỏ sự kiện click
            food.AutoScroll = true;
            Label description = new Label //Thêm label mô tả
            {
                Text = $"Mô tả: {x.MoTa}",
                Font = new Font("Arial", 10, FontStyle.Italic),
                Location = new Point(120, 95),
                MaximumSize = new Size(300, 0),
                AutoSize = true
            };
            food.Controls.Add(description);
            Detail detail = new Detail(food,"ĂN MÓN NÀY ĐI!!");
            detail.Show();
        }
        private void panel_Click(object sender, EventArgs e)
        {
            int index = (int)((Panel)sender).Tag; //lấy chỉ số panel
            var x = danhSachMonAn[index];
            //string name, string description, doube gia, string diachi,string picture,string donggop,int id
            Panel food = CreateFoodItem(x.HinhAnh, x.TenMonAn, x.Gia, x.DiaChi, x.NguoiDongGop, index);
            food.Click -= panel_Click; //Loại bỏ sự kiện click
            food.AutoScroll = true;
            Label description = new Label //Thêm label mô tả
            {
                Text = $"Mô tả: {x.MoTa}",
                Font = new Font("Arial", 10, FontStyle.Italic),
                Location = new Point(120, 95),
                MaximumSize = new Size (200,0),
                AutoSize = true
            };
            food.Controls.Add(description);
            Detail detail = new Detail(food,"MÓN ĂN");
            detail.Show();
        }
    }
}
