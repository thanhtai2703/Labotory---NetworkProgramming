using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Excercise6
{
    public partial class Menu : Form
    {
        private List<MonAn> danhSachMonAn = new List<MonAn>();
        private readonly HttpClient httpClient = new HttpClient();
        private string url;
        private int type = 0; //Xác định đang ở tab nào
        private bool isConnected = false;
        public Menu()
        {
            InitializeComponent();
        }
        private void addAuthorization()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer",User.AccessToken);
        }
        public async Task GetUserInfo()
        {
            url = "https://nt106.uitiot.vn/api/v1/user/me";
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           HttpResponseMessage response = await httpClient.GetAsync(url);
           if(response.IsSuccessStatusCode)
           {
              string responseBody = await response.Content.ReadAsStringAsync();
                JsonElement info = JsonSerializer.Deserialize<JsonElement>(responseBody);
                statelb.Text = $"Welcome,{info.GetProperty("username").GetString()}";
                statelb.ForeColor = Color.Green;
            }
        }
        public async Task GetData()
        {
            if (isConnected)
            {
                if (type == 0) url = "https://nt106.uitiot.vn/api/v1/monan/all";
                else url = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";
                var payload = new
                {
                    current = Convert.ToInt32(currentpage.Text),
                    pageSize = Convert.ToInt32(pagesize.Text),
                };
                var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var jsonData = JsonSerializer.Deserialize<JsonElement>(responseBody);
                        string responeData = jsonData.GetProperty("data").GetRawText();
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
            else
            {
                MessageBox.Show("vui lòng đăng nhập để sử dụng");
            }
        }
        private void getPanel() //tạo panel lưu danh sách món ăn
        {
            for (int i = 0; i < danhSachMonAn.Count(); i++)
            {
                MonAn monAn = danhSachMonAn[i];
                Panel foodPanel = CreateFoodItem(monAn.HinhAnh, monAn.TenMonAn, monAn.Gia, monAn.DiaChi, monAn.NguoiDongGop, i);
                if (type == 0) flowLayoutPanel1.Controls.Add(foodPanel);
                else flowLayoutPanel2.Controls.Add(foodPanel);
            }
        }
        public Panel CreateFoodItem(string imagePath, string foodName, double price, string address, string contributor, int index)
        {
            Panel foodPanel = new Panel
            {
                Size = new Size(525, 100),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)

            };
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(100, 100),
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
            if (isConnected){
                Add add = new Add();
                add.ShowDialog();
            }
            else{
                MessageBox.Show("vui lòng đăng nhập để sử dụng");
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                type = 0;
                flowLayoutPanel1.Controls.Clear();
                GetData();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                type = 1;
                flowLayoutPanel2.Controls.Clear();
                GetData();
            }
        }
        private async void btnRandom_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                Random random = new Random();
                int index = random.Next(1, 100);
                MonAn x = new MonAn();
                string url = $"https://nt106.uitiot.vn/api/v1/monan/{index}";
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //int id,string name, string description, double gia, string diachi,string picture,string donggop
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        x = JsonSerializer.Deserialize<MonAn>(responseBody);
                    }
                    Panel food = CreateFoodItem(x.HinhAnh, x.TenMonAn, x.Gia, x.DiaChi, x.NguoiDongGop, index);
                    food.Click -= panel_Click; //Bỏ sự kiện click
                    food.AutoScroll = true;
                    Label description = new Label //Thêm label mô tả
                    {
                        Text = $"Mô tả: {x.MoTa}",
                        Font = new Font("Arial", 10, FontStyle.Italic),
                        Location = new Point(120, 95),
                        AutoSize = true,
                        MaximumSize = new Size(300, 0)
                    };
                    food.Controls.Add(description);
                    Detail detail = new Detail(food, "ĂN MÓN NÀY ĐI!!");
                    detail.Show();
                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("vui lòng đăng nhập để sử dụng");
            }
        }
        private void panel_Click(object sender, EventArgs e)
        {
            if (isConnected)
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
                    MaximumSize = new Size(200, 0),
                    AutoSize = true
                };
                food.Controls.Add(description);
                Detail detail = new Detail(food, "MÓN ĂN");
                detail.Show();
            }
        }
        private void Login_LinkClicked(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            if (isConnected == false)
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    isConnected = true;
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", User.AccessToken);
                    GetData();
                    progressBar1.Value = 100;
                    GetUserInfo();
                    Loginlbl.Text = "Logout";
                }
            }
            else if(isConnected == true)
            {
                isConnected = false;
                progressBar1.Value = 0;
                User.AccessToken = "";
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel2.Controls.Clear();
                Loginlbl.Text = "Login";
                statelb.Text = "Unauthenticated";
            }
        }

        private void currentpage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type == 0) flowLayoutPanel1.Controls.Clear();
            else flowLayoutPanel2.Controls.Clear();
            GetData();
        }

        private void pagesize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type == 0) flowLayoutPanel1.Controls.Clear();
            else flowLayoutPanel2.Controls.Clear();
            GetData();
        }
    }
}
