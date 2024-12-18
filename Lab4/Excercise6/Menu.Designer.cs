namespace Excercise6
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnRandom = new Button();
            btnAdd = new Button();
            label1 = new Label();
            statelb = new Label();
            Loginlbl = new LinkLabel();
            progressBar1 = new ProgressBar();
            pagesize = new ComboBox();
            currentpage = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(574, 503);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(566, 475);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(560, 469);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(566, 475);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tôi đóng góp";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(560, 469);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // btnRandom
            // 
            btnRandom.BackColor = Color.PeachPuff;
            btnRandom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRandom.Location = new Point(303, 12);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(136, 65);
            btnRandom.TabIndex = 1;
            btnRandom.Text = "Chọn giúp tôi";
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PeachPuff;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(443, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 65);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm món ăn";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(14, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 45);
            label1.TabIndex = 3;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // statelb
            // 
            statelb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statelb.AutoSize = true;
            statelb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statelb.ForeColor = Color.FromArgb(192, 0, 0);
            statelb.Location = new Point(19, 575);
            statelb.Name = "statelb";
            statelb.Size = new Size(110, 17);
            statelb.TabIndex = 4;
            statelb.Text = "Unauthenticated";
            // 
            // Loginlbl
            // 
            Loginlbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Loginlbl.AutoSize = true;
            Loginlbl.Location = new Point(257, 578);
            Loginlbl.Name = "Loginlbl";
            Loginlbl.Size = new Size(37, 15);
            Loginlbl.TabIndex = 5;
            Loginlbl.TabStop = true;
            Loginlbl.Text = "Login";
            Loginlbl.LinkClicked += Login_LinkClicked;
            Loginlbl.Click += Login_LinkClicked;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(300, 572);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 6;
            // 
            // pagesize
            // 
            pagesize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pagesize.FormattingEnabled = true;
            pagesize.Items.AddRange(new object[] { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            pagesize.Location = new Point(527, 572);
            pagesize.Name = "pagesize";
            pagesize.Size = new Size(43, 23);
            pagesize.TabIndex = 7;
            pagesize.Text = "5";
            pagesize.SelectedIndexChanged += pagesize_SelectedIndexChanged;
            // 
            // currentpage
            // 
            currentpage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            currentpage.FormattingEnabled = true;
            currentpage.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            currentpage.Location = new Point(445, 572);
            currentpage.Name = "currentpage";
            currentpage.Size = new Size(43, 23);
            currentpage.TabIndex = 8;
            currentpage.Text = "1";
            currentpage.SelectedIndexChanged += currentpage_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(406, 578);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Page";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(494, 575);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 10;
            label3.Text = "Size";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(600, 601);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(currentpage);
            Controls.Add(pagesize);
            Controls.Add(progressBar1);
            Controls.Add(Loginlbl);
            Controls.Add(statelb);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnRandom);
            Controls.Add(tabControl1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnRandom;
        private Button btnAdd;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label statelb;
        private LinkLabel Loginlbl;
        private ProgressBar progressBar1;
        private ComboBox pagesize;
        private ComboBox currentpage;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}