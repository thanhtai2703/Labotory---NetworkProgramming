using System.IO;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "*.txt|*.txt|*.bin|*.bin|*.*|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Thông tin file
                    FileInfo fileInfo = new FileInfo(ofd.FileName);
                    textFileName.Text = ofd.SafeFileName;
                    textURL.Text = fileInfo.FullName;
                    textSize.Text = Trans(fileInfo.Length);
                    richTextBox1.Clear();
                    //Tạo thread để tiến hành đọc file không bị dừng UI.
                    Thread thread = new Thread(() => ReadFile(fileInfo.FullName));
                    thread.Start();
                }
            }

        }
        private void ReadFile(string filePath)
        {
            // Thông tin về file
            string content = ""; //nội dung file
            int lineCount = 0;//dòng 
            int wordCount = 0; //Từ
            int charCount = 0;//ký tự

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 65536)) // Tăng kích thước bộ đệm
            using (BufferedStream bs = new BufferedStream(fs, 65536))  // Sử dụng BufferedStream với bộ đệm 8KB
            using (StreamReader sr = new StreamReader(bs, Encoding.UTF8, detectEncodingFromByteOrderMarks: true, bufferSize: 65536))
            {
                StringBuilder contentBuilder = new StringBuilder();
                while (!sr.EndOfStream)
                {
                    //StringBuilder contentBuilder = new StringBuilder();
                    // Đọc từng dòng
                    string line = sr.ReadLine();

                    // Đếm dòng, từ, ký tự
                    lineCount++;
                    wordCount += line.Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    charCount += line.Length;
                    contentBuilder.AppendLine(line);
                    string contentToUpdate = contentBuilder.ToString();
                    // Cập nhật nội dung file vào RichTextBox trên luồng giao diện
                    Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(contentToUpdate);
                    }));
                    Invoke(new Action(() =>
                    {
                        textLineCount.Text = lineCount.ToString();
                        textWordCount.Text = wordCount.ToString();
                        textCharCount.Text = charCount.ToString();
                    }));
                    contentBuilder.Clear();
                }
                if (contentBuilder.Length > 0)
                {
                    Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(contentBuilder.ToString());
                        textLineCount.Text = lineCount.ToString();
                        textWordCount.Text = wordCount.ToString();
                        textCharCount.Text = charCount.ToString();
                    }));
                }
            }
        }
        private string Trans(long byteSize)
        {
            double size = byteSize;
            string[] sizeUnits = { "Bytes", "KB", "MB", "GB", "TB" };
            int unitIndex = 0;

            // Chia liên tục cho 1024 để chuyển đổi giữa các đơn vị
            while (size >= 1024 && unitIndex < sizeUnits.Length - 1)
            {
                size /= 1024;
                unitIndex++;
            }

            // Trả về chuỗi kích thước tệp với 2 chữ số sau dấu thập phân
            return $"{size:F2} {sizeUnits[unitIndex]}";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //dừng tất cả chương trình 
            Environment.Exit(0);
        }
    }
}
