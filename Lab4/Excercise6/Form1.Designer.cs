namespace Excercise6
{
    partial class Form1
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
            richTextBox1 = new RichTextBox();
            btnClear = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(100, 18);
            label1.Name = "label1";
            label1.Size = new Size(261, 54);
            label1.TabIndex = 0;
            label1.Text = "ADD DISHES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 90);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên món ăn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 134);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 2;
            label3.Text = "Giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 180);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 228);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 4;
            label5.Text = "Hình ảnh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 273);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 5;
            label6.Text = "Mô tả:";
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(322, 31);
            txtName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(117, 130);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(322, 31);
            txtPrice.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(117, 176);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(322, 31);
            txtAddress.TabIndex = 8;
            // 
            // txtPicture
            // 
            txtPicture.Location = new Point(117, 224);
            txtPicture.Name = "txtPicture";
            txtPicture.Size = new Size(322, 31);
            txtPicture.TabIndex = 9;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(117, 273);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(322, 127);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(197, 406);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(327, 405);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(452, 451);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(richTextBox1);
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
            Name = "Form1";
            Text = "Add Dishes";
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
        private RichTextBox richTextBox1;
        private Button btnClear;
        private Button btnSubmit;
    }
}