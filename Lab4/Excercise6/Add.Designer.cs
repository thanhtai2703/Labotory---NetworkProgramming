namespace Excercise6
{
    partial class Add
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtAddress = new TextBox();
            txtPicture = new TextBox();
            btnClear = new Button();
            btnSubmit = new Button();
            txtDescription = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(62, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 0;
            label1.Text = "Thêm món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 54);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên món ăn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "Giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 108);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 137);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Hình ảnh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 164);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 5;
            label6.Text = "Mô tả:";
            // 
            // txtName
            // 
            txtName.Location = new Point(82, 52);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(227, 23);
            txtName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(82, 78);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(227, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(82, 106);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(227, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtPicture
            // 
            txtPicture.Location = new Point(82, 134);
            txtPicture.Margin = new Padding(2);
            txtPicture.Name = "txtPicture";
            txtPicture.Size = new Size(227, 23);
            txtPicture.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(138, 244);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 20);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(229, 243);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(78, 20);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(80, 164);
            txtDescription.Margin = new Padding(2);
            txtDescription.MaxLength = 150;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(227, 75);
            txtDescription.TabIndex = 13;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(316, 271);
            Controls.Add(txtDescription);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(txtPicture);
            Controls.Add(txtAddress);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Add";
            Text = "Add ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtAddress;
        private TextBox txtPicture;
        private Button btnClear;
        private Button btnSubmit;
        private TextBox txtDescription;
    }
}