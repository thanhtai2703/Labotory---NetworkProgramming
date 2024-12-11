namespace Excercise5
{
    partial class Client
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
            connectBtn = new Button();
            set = new Button();
            nameTxt = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            exit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // connectBtn
            // 
            connectBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            connectBtn.Location = new Point(8, 128);
            connectBtn.Margin = new Padding(4, 3, 4, 3);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(168, 69);
            connectBtn.TabIndex = 25;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // set
            // 
            set.BackColor = SystemColors.ActiveCaption;
            set.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            set.Location = new Point(8, 445);
            set.Margin = new Padding(4, 3, 4, 3);
            set.Name = "set";
            set.Size = new Size(168, 69);
            set.TabIndex = 26;
            set.Text = "BOOK";
            set.UseVisualStyleBackColor = false;
            set.Click += Book_Click;
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxt.Location = new Point(13, 413);
            nameTxt.Margin = new Padding(4, 3, 4, 3);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(162, 26);
            nameTxt.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(78, 36);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 26);
            textBox1.TabIndex = 28;
            textBox1.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveBorder;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(78, 84);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 26);
            textBox2.TabIndex = 29;
            textBox2.Text = "11000";
            // 
            // exit
            // 
            exit.BackColor = SystemColors.ActiveCaption;
            exit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(8, 551);
            exit.Margin = new Padding(4, 3, 4, 3);
            exit.Name = "exit";
            exit.Size = new Size(168, 69);
            exit.TabIndex = 30;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 390);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 31;
            label1.Text = "Enter your name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 32;
            label2.Text = "IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 84);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 33;
            label3.Text = "Port";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 632);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(nameTxt);
            Controls.Add(set);
            Controls.Add(connectBtn);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Client";
            Text = "CLIENT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

