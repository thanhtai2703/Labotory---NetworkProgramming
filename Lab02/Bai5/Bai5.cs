using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
namespace Bai5
{
    public partial class Bai5 : Form
    {
        private string currentDirectory;
        private TreeNode currentTreeNode;
        public Bai5()
        {
            InitializeComponent();
            LoadDrives();
        }
        private void LoadDrives()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive;
                node.Nodes.Add("...");
                treeView1.Nodes.Add(node);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "...")
            {
                e.Node.Nodes.Clear();  // Xóa "...." trước khi tải dữ liệu thực
                LoadDirectoriesAndFiles(e.Node);  // Load thư mục con và tệp
            }
        }
        private void LoadDirectoriesAndFiles(TreeNode node)
        {
            DirectoryInfo dir = new DirectoryInfo(node.FullPath);
            try
            {
                // Load subdirectories into the TreeView
                foreach (var directory in dir.GetDirectories())
                {
                    TreeNode dirNode = new TreeNode(directory.Name);
                    dirNode.Nodes.Add("...");
                    dirNode.Tag = directory;   //Lưu thông tin thư mục trong thuộc tính Tag
                    node.Nodes.Add(dirNode);   //Thêm node của thư mục vào node hiện tại
                }

                // Load files into the TreeView
                foreach (var file in dir.GetFiles())
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file.FullName;  // Store the full file path in the Tag property Lưu đường dẫn của file vào Tag
                    node.Nodes.Add(fileNode);      // Thêm node của file vào node hiện tại
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Bạn không có quyền truy cập");
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedPath = e.Node.Tag.ToString();  // Lấy đường dẫn đầy đủ của mục được chọn

            // Nếu là tệp, kiểm tra xem có phải là tệp ảnh không
            if (File.Exists(selectedPath))
            {
                // Các định dạng ảnh phổ biến
                string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
                string[] textExtensions = { ".txt" };

                // Kiểm tra nếu tệp là một ảnh dựa trên phần mở rộng
                string fileExtension = Path.GetExtension(selectedPath).ToLower();
                if (Array.Exists(imageExtensions, ext => ext == fileExtension))
                {
                    try
                    {
                        using (Image img = Image.FromFile(selectedPath))
                        {
                            Clipboard.SetImage(img); // Đặt hình ảnh vào bộ nhớ tạm
                            preview.Paste();    // Dán hình ảnh vào preview
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("lỗi khi tải ảnh");
                    }
                }
                else if (Array.Exists(textExtensions, ext => ext == fileExtension))
                {
                    try
                    {
                        //đọc nội dung văn bản
                        ReadTextFile(selectedPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("lỗi khi đọc nội dung");
                    }
                }
            }
            else if (Directory.Exists(selectedPath))
            {
                //Nếu là thư mục, thực hiện các hành động khác nếu cần
                preview.Clear();
                currentTreeNode = e.Node;
                DirectoryInfo dir = new DirectoryInfo(e.Node.FullPath);
                currentDirectory = dir.FullName;
                LoadDirectoriesAndFiles(e.Node); // Nếu là thư mục, gọi phương thức tải thư mục con
            }
            else preview.Clear();
        }
        private void ReadTextFile(string filePath)
        {
            // Bắt đầu một Thread mới để đọc file
            Task.Run(() =>
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Cập nhật giao diện trên thread chính
                            Invoke(new Action(() =>
                            {
                                preview.AppendText(line + Environment.NewLine); // Hiển thị từng dòng trong RichTextBox
                            }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi khi đọc file");
                }
            });
        }
    }

}
