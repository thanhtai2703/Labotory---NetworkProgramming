namespace LAB01
{
    partial class Lab1_Menu
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
            Excercise1 = new Button();
            Excercise5 = new Button();
            Excercise2 = new Button();
            Excercise3 = new Button();
            Excercise4 = new Button();
            SuspendLayout();
            // 
            // Excercise1
            // 
            Excercise1.BackColor = Color.FromArgb(255, 192, 128);
            Excercise1.FlatStyle = FlatStyle.Flat;
            Excercise1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            Excercise1.Location = new Point(100, 66);
            Excercise1.Margin = new Padding(4, 3, 4, 3);
            Excercise1.Name = "Excercise1";
            Excercise1.Size = new Size(162, 95);
            Excercise1.TabIndex = 0;
            Excercise1.Text = "Excersice1";
            Excercise1.UseVisualStyleBackColor = false;
            Excercise1.Click += Excercise1button_Click;
            // 
            // Excercise5
            // 
            Excercise5.BackColor = Color.FromArgb(255, 192, 128);
            Excercise5.BackgroundImageLayout = ImageLayout.None;
            Excercise5.FlatStyle = FlatStyle.Flat;
            Excercise5.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Excercise5.Location = new Point(400, 210);
            Excercise5.Margin = new Padding(4, 3, 4, 3);
            Excercise5.Name = "Excercise5";
            Excercise5.Size = new Size(162, 95);
            Excercise5.TabIndex = 1;
            Excercise5.Text = "Excersice5";
            Excercise5.UseVisualStyleBackColor = false;
            Excercise5.Click += Excercise5_Click;
            // 
            // Excercise2
            // 
            Excercise2.BackColor = Color.FromArgb(255, 192, 128);
            Excercise2.FlatStyle = FlatStyle.Flat;
            Excercise2.Location = new Point(672, 66);
            Excercise2.Margin = new Padding(4, 3, 4, 3);
            Excercise2.Name = "Excercise2";
            Excercise2.Size = new Size(162, 95);
            Excercise2.TabIndex = 2;
            Excercise2.Text = "Excersice2";
            Excercise2.UseVisualStyleBackColor = false;
            Excercise2.Click += Excercise2button_Click;
            // 
            // Excercise3
            // 
            Excercise3.BackColor = Color.FromArgb(255, 192, 128);
            Excercise3.FlatStyle = FlatStyle.Flat;
            Excercise3.Location = new Point(100, 369);
            Excercise3.Margin = new Padding(4, 3, 4, 3);
            Excercise3.Name = "Excercise3";
            Excercise3.Size = new Size(162, 95);
            Excercise3.TabIndex = 3;
            Excercise3.Text = "Excersice3";
            Excercise3.UseVisualStyleBackColor = false;
            Excercise3.Click += Excercise3button_Click;
            // 
            // Excercise4
            // 
            Excercise4.BackColor = Color.FromArgb(255, 192, 128);
            Excercise4.FlatStyle = FlatStyle.Flat;
            Excercise4.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold);
            Excercise4.Location = new Point(672, 369);
            Excercise4.Margin = new Padding(4, 3, 4, 3);
            Excercise4.Name = "Excercise4";
            Excercise4.Size = new Size(162, 95);
            Excercise4.TabIndex = 4;
            Excercise4.Text = "Excersice4";
            Excercise4.UseVisualStyleBackColor = false;
            Excercise4.Click += Excercise4button_Click;
            // 
            // Lab1_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 518);
            Controls.Add(Excercise4);
            Controls.Add(Excercise3);
            Controls.Add(Excercise2);
            Controls.Add(Excercise5);
            Controls.Add(Excercise1);
            Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Lab1_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main menu";
            ResumeLayout(false);
        }

        #endregion

        private Button Excercise1;
        private Button Excercise5;
        private Button Excercise2;
        private Button Excercise3;
        private Button Excercise4;
    }
}