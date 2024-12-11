namespace Excercise4
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
            lblName = new Label();
            lblList = new Label();
            lblMessage = new Label();
            txtMessages = new TextBox();
            txtName = new TextBox();
            txtMessage = new TextBox();
            btnConnect = new Button();
            btnSend = new Button();
            lstClients = new ListBox();
            btnPrivate = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblName.Location = new Point(18, 227);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 17);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblList.Location = new Point(569, 11);
            lblList.Name = "lblList";
            lblList.Size = new Size(80, 17);
            lblList.TabIndex = 1;
            lblList.Text = "Client List";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblMessage.Location = new Point(18, 285);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(76, 18);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Message";
            // 
            // txtMessages
            // 
            txtMessages.Location = new Point(21, 11);
            txtMessages.Multiline = true;
            txtMessages.Name = "txtMessages";
            txtMessages.ReadOnly = true;
            txtMessages.Size = new Size(525, 210);
            txtMessages.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(21, 248);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(134, 31);
            txtName.TabIndex = 4;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(21, 308);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(323, 36);
            txtMessage.TabIndex = 5;
            txtMessage.KeyDown += btnSend_KeyDown;
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnConnect.Location = new Point(160, 248);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 31);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSend.Location = new Point(349, 308);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 36);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lstClients
            // 
            lstClients.FormattingEnabled = true;
            lstClients.ItemHeight = 15;
            lstClients.Location = new Point(550, 33);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(123, 334);
            lstClients.TabIndex = 8;
            // 
            // btnPrivate
            // 
            btnPrivate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnPrivate.Location = new Point(454, 308);
            btnPrivate.Name = "btnPrivate";
            btnPrivate.Size = new Size(81, 36);
            btnPrivate.TabIndex = 9;
            btnPrivate.Text = "Private";
            btnPrivate.UseVisualStyleBackColor = true;
            btnPrivate.Click += btnSendPrivate_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 374);
            Controls.Add(btnPrivate);
            Controls.Add(lstClients);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(txtMessage);
            Controls.Add(txtName);
            Controls.Add(txtMessages);
            Controls.Add(lblMessage);
            Controls.Add(lblList);
            Controls.Add(lblName);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Button btnPrivate;
    }
}

