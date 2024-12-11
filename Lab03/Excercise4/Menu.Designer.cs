using System.Windows.Forms;
using System.Xml.Linq;

namespace Excercise4
{
    partial class Menu
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
            opServer = new Button();
            opClient = new Button();
            SuspendLayout();
            // 
            // opServer
            // 
            opServer.BackColor = SystemColors.ActiveCaption;
            opServer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opServer.Location = new Point(215, 84);
            opServer.Name = "opServer";
            opServer.Size = new Size(155, 81);
            opServer.TabIndex = 1;
            opServer.Text = "SERVER";
            opServer.UseVisualStyleBackColor = false;
            opServer.Click += opServer_Click;
            // 
            // opClient
            // 
            opClient.BackColor = SystemColors.ActiveCaption;
            opClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opClient.Location = new Point(21, 84);
            opClient.Name = "opClient";
            opClient.Size = new Size(155, 81);
            opClient.TabIndex = 2;
            opClient.Text = "CLIENT";
            opClient.UseVisualStyleBackColor = false;
            opClient.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 234);
            Controls.Add(opClient);
            Controls.Add(opServer);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button opServer;
        private Button opClient;
    }
}