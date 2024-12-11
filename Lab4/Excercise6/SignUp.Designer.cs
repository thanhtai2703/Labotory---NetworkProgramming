namespace Excercise6
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtLanguage = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtPhone = new TextBox();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            textBox3 = new TextBox();
            Date = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtEmail = new Label();
            btnClear = new Button();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(74, 9);
            label1.Name = "label1";
            label1.Size = new Size(355, 54);
            label1.TabIndex = 0;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 126);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(126, 73);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(326, 31);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(126, 35);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(326, 31);
            txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(txtLanguage);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtLastname);
            groupBox2.Controls.Add(txtFirstname);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(Date);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Location = new Point(12, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(471, 327);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Information";
            // 
            // button2
            // 
            button2.Location = new Point(418, 339);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(250, 289);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(126, 289);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(126, 240);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(326, 31);
            txtLanguage.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 289);
            label10.Name = "label10";
            label10.Size = new Size(39, 25);
            label10.TabIndex = 11;
            label10.Text = "Sex";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 243);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 10;
            label9.Text = "Language";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 202);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 9;
            label8.Text = "Birthday";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(126, 158);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(326, 31);
            txtPhone.TabIndex = 8;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(126, 118);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(326, 31);
            txtLastname.TabIndex = 7;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(126, 78);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(326, 31);
            txtFirstname.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(326, 31);
            textBox3.TabIndex = 5;
            // 
            // Date
            // 
            Date.Location = new Point(126, 197);
            Date.Name = "Date";
            Date.Size = new Size(326, 31);
            Date.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 161);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 3;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 121);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 2;
            label6.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 80);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 1;
            label5.Text = "First Name";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(6, 39);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(54, 25);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "Email";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(255, 553);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(373, 553);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(494, 603);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "Sign Up";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label txtEmail;
        private TextBox textBox3;
        private DateTimePicker Date;
        private TextBox txtPhone;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtLanguage;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button2;
        private Button btnClear;
        private Button btnSubmit;
    }
}
