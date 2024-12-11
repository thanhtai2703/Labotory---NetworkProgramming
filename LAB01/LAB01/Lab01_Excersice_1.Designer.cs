namespace LAB01
{
    partial class Lab01_Excersice_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Excersice_1));
            TNumber1 = new TextBox();
            TNumber2 = new TextBox();
            TNumber3 = new TextBox();
            LNumber1 = new Label();
            LNumber2 = new Label();
            LNumber3 = new Label();
            Find = new Button();
            Delete = new Button();
            Exit = new Button();
            TMaxNum = new TextBox();
            TMinNum = new TextBox();
            LMaxNum = new Label();
            LMinNum = new Label();
            SuspendLayout();
            // 
            // TNumber1
            // 
            TNumber1.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TNumber1.Location = new Point(116, 66);
            TNumber1.Name = "TNumber1";
            TNumber1.Size = new Size(89, 25);
            TNumber1.TabIndex = 0;
            // 
            // TNumber2
            // 
            TNumber2.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TNumber2.Location = new Point(324, 66);
            TNumber2.Name = "TNumber2";
            TNumber2.Size = new Size(89, 25);
            TNumber2.TabIndex = 1;
            // 
            // TNumber3
            // 
            TNumber3.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TNumber3.Location = new Point(551, 66);
            TNumber3.Name = "TNumber3";
            TNumber3.Size = new Size(89, 25);
            TNumber3.TabIndex = 2;
            // 
            // LNumber1
            // 
            LNumber1.AutoSize = true;
            LNumber1.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNumber1.Location = new Point(25, 69);
            LNumber1.Name = "LNumber1";
            LNumber1.Size = new Size(83, 20);
            LNumber1.TabIndex = 3;
            LNumber1.Text = "Number 1: ";
            // 
            // LNumber2
            // 
            LNumber2.AutoSize = true;
            LNumber2.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNumber2.Location = new Point(234, 69);
            LNumber2.Name = "LNumber2";
            LNumber2.Size = new Size(83, 20);
            LNumber2.TabIndex = 4;
            LNumber2.Text = "Number 2: ";
            // 
            // LNumber3
            // 
            LNumber3.AutoSize = true;
            LNumber3.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNumber3.Location = new Point(460, 69);
            LNumber3.Name = "LNumber3";
            LNumber3.Size = new Size(83, 20);
            LNumber3.TabIndex = 5;
            LNumber3.Text = "Number 3: ";
            // 
            // Find
            // 
            Find.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Find.Location = new Point(79, 143);
            Find.Name = "Find";
            Find.Size = new Size(67, 33);
            Find.TabIndex = 6;
            Find.Text = "Find";
            Find.UseVisualStyleBackColor = true;
            Find.Click += button1_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete.Location = new Point(284, 143);
            Delete.Name = "Delete";
            Delete.Size = new Size(67, 33);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(480, 143);
            Exit.Name = "Exit";
            Exit.Size = new Size(67, 33);
            Exit.TabIndex = 8;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // TMaxNum
            // 
            TMaxNum.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TMaxNum.Location = new Point(176, 245);
            TMaxNum.Name = "TMaxNum";
            TMaxNum.ReadOnly = true;
            TMaxNum.Size = new Size(89, 25);
            TMaxNum.TabIndex = 9;
            // 
            // TMinNum
            // 
            TMinNum.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TMinNum.Location = new Point(464, 244);
            TMinNum.Name = "TMinNum";
            TMinNum.ReadOnly = true;
            TMinNum.Size = new Size(89, 25);
            TMinNum.TabIndex = 10;
            // 
            // LMaxNum
            // 
            LMaxNum.AutoSize = true;
            LMaxNum.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LMaxNum.Location = new Point(25, 247);
            LMaxNum.Name = "LMaxNum";
            LMaxNum.Size = new Size(143, 20);
            LMaxNum.TabIndex = 11;
            LMaxNum.Text = "Maximum Number: ";
            // 
            // LMinNum
            // 
            LMinNum.AutoSize = true;
            LMinNum.Font = new Font("Microsoft YaHei", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LMinNum.Location = new Point(312, 247);
            LMinNum.Name = "LMinNum";
            LMinNum.Size = new Size(141, 20);
            LMinNum.TabIndex = 12;
            LMinNum.Text = "Minimum Number: ";
            // 
            // Lab01_Excersice_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(659, 303);
            Controls.Add(LMinNum);
            Controls.Add(LMaxNum);
            Controls.Add(TMinNum);
            Controls.Add(TMaxNum);
            Controls.Add(Exit);
            Controls.Add(Delete);
            Controls.Add(Find);
            Controls.Add(LNumber3);
            Controls.Add(LNumber2);
            Controls.Add(LNumber1);
            Controls.Add(TNumber3);
            Controls.Add(TNumber2);
            Controls.Add(TNumber1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Lab01_Excersice_1";
            Text = "Find Max & Min";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox TNumber1;
        private System.Windows.Forms.TextBox TNumber2;
        private System.Windows.Forms.TextBox TNumber3;
        private System.Windows.Forms.Label LNumber1;
        private System.Windows.Forms.Label LNumber2;
        private System.Windows.Forms.Label LNumber3;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox TMaxNum;
        private System.Windows.Forms.TextBox TMinNum;
        private System.Windows.Forms.Label LMaxNum;
        private System.Windows.Forms.Label LMinNum;
    }
}
