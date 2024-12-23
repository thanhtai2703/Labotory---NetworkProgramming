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
            chooseColorBtn = new Button();
            attachBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtImagePath = new TextBox();
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
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Body";
            // 
            // SendBtn
            // 
            SendBtn.Location = new Point(12, 27);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(84, 60);
            SendBtn.TabIndex = 4;
            SendBtn.Text = "SEND";
            SendBtn.UseVisualStyleBackColor = true;
            SendBtn.Click += SendBtn_Click;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(172, 30);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(313, 27);
            txtFrom.TabIndex = 5;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(172, 67);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(313, 27);
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
            // chooseColorBtn
            // 
            chooseColorBtn.Location = new Point(419, 117);
            chooseColorBtn.Name = "chooseColorBtn";
            chooseColorBtn.Size = new Size(81, 29);
            chooseColorBtn.TabIndex = 9;
            chooseColorBtn.Text = "Color";
            chooseColorBtn.UseVisualStyleBackColor = true;
            chooseColorBtn.Click += chooseColorBtn_Click;
            // 
            // attachBtn
            // 
            attachBtn.Location = new Point(428, 400);
            attachBtn.Name = "attachBtn";
            attachBtn.Size = new Size(81, 29);
            attachBtn.TabIndex = 10;
            attachBtn.Text = "Attach";
            attachBtn.UseVisualStyleBackColor = true;
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
            // subjectColor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 441);
            Controls.Add(txtImagePath);
            Controls.Add(attachBtn);
            Controls.Add(chooseColorBtn);
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
            Text = "Form1";
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
        private Button chooseColorBtn;
        private Button attachBtn;
        private OpenFileDialog openFileDialog1;
        private TextBox txtImagePath;
    }
}
