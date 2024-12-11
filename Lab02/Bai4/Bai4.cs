using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Bai4
{
    public partial class Bai4 : Form
    {
        [Serializable]
        public class Student
        {
            public string Name;
            public int ID;
            public string Phone;
            public float C1;
            public float C2;
            public float C3;
            public float AVG;

        }
        public Bai4()
        {
            InitializeComponent();
            i_Phone.MaxLength = 10;
            i_ID.MaxLength = 8;

        }
        public List<Student> students = new List<Student>();
        int currentPage = -1;
        int totalPage = 0;

        private void Clear()
        {
            i_Name.Clear();
            i_ID.Clear();
            i_Phone.Clear();
            i_C1.Clear();
            i_C2.Clear();
            i_C3.Clear();
        }
        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(i_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên");
                return false;
            }
            if (string.IsNullOrWhiteSpace(i_Phone.Text))
            {
                MessageBox.Show("Vui lòng nhập SDT");
                return false;
            }
            if (string.IsNullOrWhiteSpace(i_C1.Text))
            {
                MessageBox.Show("Vui lòng nhập điểm môn 1");
                return false;
            }
            if (string.IsNullOrWhiteSpace(i_C2.Text))
            {
                MessageBox.Show("Vui lòng nhập Điểm môn 2");
                return false;
            }
            if (string.IsNullOrWhiteSpace(i_C3.Text))
            {
                MessageBox.Show("Vui lòng nhập Điểm môn 3");
                return false;
            }
            if (string.IsNullOrWhiteSpace(i_ID.Text))
            {
                MessageBox.Show("Vui lòng nhập ID");
                return false;
            }
            if (!Regex.IsMatch(i_Phone.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Vui lòng nhập lại sdt 10 chữ số,, bắt đầu bằng chữ số 0");
                return false;
            }
            if (!Regex.IsMatch(i_ID.Text, @"\d{8}$"))
            {
                MessageBox.Show("Vui lòng nhập lại ID có 8 chữ số");
                return false;
            }
            int number;
            if (!int.TryParse(i_C1.Text, out number) || number < 0 || number > 10)
            {
                MessageBox.Show("vui lòng nhập lại điểm môn 1");
                return false;
            }
            if (!int.TryParse(i_C2.Text, out number) || number < 0 || number > 10)
            {
                MessageBox.Show("vui lòng nhập lại điểm môn 2");
                return false;
            }
            if (!int.TryParse(i_C3.Text, out number) || number < 0 || number > 10)
            {
                MessageBox.Show("vui lòng nhập lại điểm môn 3");
                return false;
            }
            return true;
        }
        private void Input(Student x)
        {
            x.Name = i_Name.Text;
            x.ID = Convert.ToInt32(i_ID.Text);
            x.Phone = i_Phone.Text;
            x.C1 = float.Parse(i_C1.Text);
            x.C2 = float.Parse(i_C2.Text);
            x.C3 = float.Parse(i_C3.Text);
            x.AVG = (x.C1 + x.C2 + x.C3) / 3;
        }
        private void DisplayToPage(Student x)
        {
            o_Name.Text = x.Name;
            o_ID.Text = x.ID.ToString();
            o_Phone.Text = x.Phone.ToString();
            o_C1.Text = x.C1.ToString();
            o_C2.Text = x.C2.ToString();
            o_C3.Text = x.C3.ToString();
            AVG.Text = x.AVG.ToString();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                totalPage++; // Tổng số trang
                currentPage++; // hiển thị trang hiện tại
                Student x = new Student(); ;
                Input(x);
                students.Add(x);
                DisplayToPage(x);
                page.Text = currentPage.ToString();
                UpdateInfo(currentPage);
            }

        }
        private void UpdateInfo(int page)
        {
            o_Name.Text = students[page].Name;
            o_ID.Text = students[page].ID.ToString();
            o_Phone.Text = students[page].Phone.ToString();
            o_C1.Text = students[page].C1.ToString();
            o_C2.Text = students[page].C2.ToString();
            o_C3.Text = students[page].C3.ToString();
            AVG.Text = students[page].AVG.ToString();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                page.Text = currentPage.ToString();
                UpdateInfo(currentPage);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < students.Count - 1)
            {
                currentPage++;
                UpdateInfo(currentPage);
                page.Text = currentPage.ToString();
            }
            else
            {
                MessageBox.Show("Hết");
            }

        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            string filePath = "input4.txt";
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(fs, students);
            }
        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            string filePath = "input4.txt";
            string outputPath = "output.txt";
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                students = (List<Student>)formatter.Deserialize(fs);

                // Hiển thị nội dung học sinh lên RichTextBox
                display.Clear(); // Xóa nội dung hiện tại
                foreach (var hs in students)
                {
                    display.AppendText($"{hs.Name}\n{hs.ID}\n{hs.Phone}\n{hs.C1}\n{hs.C2}\n{hs.C3}\n {Environment.NewLine}");
                }
                totalPage = 0;
                currentPage = -1;
                foreach (var hs in students)
                {
                    totalPage++;
                    currentPage++;
                    UpdateInfo(currentPage);
                }
                page.Text = currentPage.ToString();

            }
            using (StreamWriter sw = new StreamWriter(outputPath))
            {
                foreach (var st in students)
                    sw.Write($"{st.Name} Điểm trung bình :{st.AVG}\n");
            }
        }


    }
}
