using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai1
{
    partial class subjectColor
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SendBtn = new Button();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            txtSubject = new TextBox();
            txtBody = new RichTextBox();
            colorDialog1 = new ColorDialog();
            SubjectColorChoose = new Button();
            attachBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtImagePath = new TextBox();
            BodyColorChoose = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 33);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 67);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Body";
            // 
            // SendBtn
            // 
            SendBtn.BackColor = Color.AliceBlue;
            SendBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendBtn.Location = new Point(12, 27);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(96, 60);
            SendBtn.TabIndex = 4;
            SendBtn.Text = "SEND";
            SendBtn.UseVisualStyleBackColor = false;
            SendBtn.Click += SendBtn_Click;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(172, 30);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(377, 27);
            txtFrom.TabIndex = 5;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(172, 67);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(377, 27);
            txtTo.TabIndex = 6;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(88, 119);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(325, 27);
            txtSubject.TabIndex = 7;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(88, 157);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(325, 234);
            txtBody.TabIndex = 8;
            txtBody.Text = "";
            // 
            // SubjectColorChoose
            // 
            SubjectColorChoose.BackColor = Color.AliceBlue;
            SubjectColorChoose.Location = new Point(419, 119);
            SubjectColorChoose.Name = "SubjectColorChoose";
            SubjectColorChoose.Size = new Size(106, 29);
            SubjectColorChoose.TabIndex = 9;
            SubjectColorChoose.Text = "SubjectColor";
            SubjectColorChoose.UseVisualStyleBackColor = false;
            SubjectColorChoose.Click += chooseSubjectColorBtn_Click;
            // 
            // attachBtn
            // 
            attachBtn.BackColor = Color.AliceBlue;
            attachBtn.Location = new Point(419, 407);
            attachBtn.Name = "attachBtn";
            attachBtn.Size = new Size(106, 29);
            attachBtn.TabIndex = 10;
            attachBtn.Text = "Attach";
            attachBtn.UseVisualStyleBackColor = false;
            attachBtn.Click += attachBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(90, 407);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(323, 27);
            txtImagePath.TabIndex = 11;
            // 
            // BodyColorChoose
            // 
            BodyColorChoose.BackColor = Color.AliceBlue;
            BodyColorChoose.Location = new Point(419, 157);
            BodyColorChoose.Name = "BodyColorChoose";
            BodyColorChoose.Size = new Size(106, 29);
            BodyColorChoose.TabIndex = 12;
            BodyColorChoose.Text = "BodyColor";
            BodyColorChoose.UseVisualStyleBackColor = false;
            BodyColorChoose.Click += BodyColorChoose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(14, 410);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 13;
            label5.Text = "location";
            // 
            // subjectColor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(556, 461);
            Controls.Add(label5);
            Controls.Add(BodyColorChoose);
            Controls.Add(txtImagePath);
            Controls.Add(attachBtn);
            Controls.Add(SubjectColorChoose);
            Controls.Add(txtBody);
            Controls.Add(txtSubject);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(SendBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "subjectColor";
            Text = "SendMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SendBtn;
        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtSubject;
        private RichTextBox txtBody;
        private ColorDialog colorDialog1;
        private Button SubjectColorChoose;
        private Button attachBtn;
        private OpenFileDialog openFileDialog1;
        private TextBox txtImagePath;
        private Button BodyColorChoose;
        private Label label5;
    }
}
