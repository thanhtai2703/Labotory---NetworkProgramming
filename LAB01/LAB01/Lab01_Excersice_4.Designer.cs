namespace LAB01
{
    partial class Lab01_Excersice_4
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
            lblResult = new Label();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            btnCheck = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(213, 35);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "Month";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblResult.Location = new Point(193, 108);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(74, 25);
            lblResult.TabIndex = 2;
            lblResult.Text = "Equal:";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(107, 39);
            txtDay.Margin = new Padding(3, 4, 3, 4);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(100, 27);
            txtDay.TabIndex = 3;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(293, 40);
            txtMonth.Margin = new Padding(3, 4, 3, 4);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(100, 27);
            txtMonth.TabIndex = 4;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnCheck.Location = new Point(29, 108);
            btnCheck.Margin = new Padding(3, 4, 3, 4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(147, 46);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Search";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 163);
            button1.Location = new Point(29, 161);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(147, 41);
            button1.TabIndex = 7;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lab01_Excersice_4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(646, 414);
            Controls.Add(button1);
            Controls.Add(btnCheck);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab01_Excersice_4";
            Text = "Zodiac";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button button1;
    }
}
