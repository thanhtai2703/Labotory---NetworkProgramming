namespace LAB01
{
    partial class Lab01_Excersice_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Excersice_2));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            CalculateB = new Button();
            DeleteB = new Button();
            ExitB = new Button();
            ResultBox = new RichTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(166, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLightLight;
            textBox2.Location = new Point(526, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 46);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(438, 46);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter B";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Multiplication table", "Calculate values" });
            comboBox1.Location = new Point(275, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 28);
            comboBox1.TabIndex = 4;
            // 
            // CalculateB
            // 
            CalculateB.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalculateB.Location = new Point(44, 165);
            CalculateB.Name = "CalculateB";
            CalculateB.Size = new Size(104, 37);
            CalculateB.TabIndex = 5;
            CalculateB.Text = "Calculate";
            CalculateB.UseVisualStyleBackColor = true;
            CalculateB.Click += CalculateB_Click;
            // 
            // DeleteB
            // 
            DeleteB.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteB.Location = new Point(301, 165);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(104, 37);
            DeleteB.TabIndex = 6;
            DeleteB.Text = "Delete";
            DeleteB.UseVisualStyleBackColor = true;
            DeleteB.Click += DeleteB_Click;
            // 
            // ExitB
            // 
            ExitB.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitB.Location = new Point(562, 165);
            ExitB.Name = "ExitB";
            ExitB.Size = new Size(104, 37);
            ExitB.TabIndex = 7;
            ExitB.Text = "Exit";
            ExitB.UseVisualStyleBackColor = true;
            ExitB.Click += ExitB_Click;
            // 
            // ResultBox
            // 
            ResultBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultBox.Location = new Point(11, 255);
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.Size = new Size(690, 253);
            ResultBox.TabIndex = 8;
            ResultBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 230);
            label3.Name = "label3";
            label3.Size = new Size(102, 27);
            label3.TabIndex = 9;
            label3.Text = "RESULT: ";
            // 
            // Lab01_Excersice_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 508);
            Controls.Add(label3);
            Controls.Add(ResultBox);
            Controls.Add(ExitB);
            Controls.Add(DeleteB);
            Controls.Add(CalculateB);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab01_Excersice_2";
            Text = "Math operations";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CalculateB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.Label label3;
    }
}
