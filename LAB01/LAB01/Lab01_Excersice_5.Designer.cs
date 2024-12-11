namespace LAB01
{
    partial class Lab01_Excersice_5
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            deleteData_btn = new Button();
            button1 = new Button();
            Subj3 = new TextBox();
            Subj2 = new TextBox();
            Subj1 = new TextBox();
            Genderlist = new ComboBox();
            txtName = new TextBox();
            button3 = new Button();
            ListData = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewComboBoxColumn();
            Subject1 = new DataGridViewTextBoxColumn();
            Subject2 = new DataGridViewTextBoxColumn();
            Subject3 = new DataGridViewTextBoxColumn();
            AVG = new DataGridViewTextBoxColumn();
            Classification = new DataGridViewComboBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Statistic = new Button();
            Table = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListData).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(deleteData_btn);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Subj3);
            groupBox1.Controls.Add(Subj2);
            groupBox1.Controls.Add(Subj1);
            groupBox1.Controls.Add(Genderlist);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(23, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 209);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 155);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 14;
            label5.Text = "Subject3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 102);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 13;
            label4.Text = "Subject2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 55);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 12;
            label3.Text = "Subject1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 102);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 11;
            label2.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 10;
            label1.Text = "FullName";
            // 
            // deleteData_btn
            // 
            deleteData_btn.Location = new Point(137, 168);
            deleteData_btn.Name = "deleteData_btn";
            deleteData_btn.Size = new Size(94, 29);
            deleteData_btn.TabIndex = 9;
            deleteData_btn.Text = "Delete";
            deleteData_btn.UseVisualStyleBackColor = true;
            deleteData_btn.Click += buttonDelete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(15, 168);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += savebutton_Click;
            // 
            // Subj3
            // 
            Subj3.Location = new Point(340, 152);
            Subj3.Name = "Subj3";
            Subj3.Size = new Size(118, 27);
            Subj3.TabIndex = 7;
            // 
            // Subj2
            // 
            Subj2.Location = new Point(340, 99);
            Subj2.Name = "Subj2";
            Subj2.Size = new Size(118, 27);
            Subj2.TabIndex = 6;
            // 
            // Subj1
            // 
            Subj1.Location = new Point(340, 48);
            Subj1.Name = "Subj1";
            Subj1.Size = new Size(118, 27);
            Subj1.TabIndex = 5;
            // 
            // Genderlist
            // 
            Genderlist.DropDownStyle = ComboBoxStyle.DropDownList;
            Genderlist.FormattingEnabled = true;
            Genderlist.Items.AddRange(new object[] { "Male", "Female" });
            Genderlist.Location = new Point(94, 99);
            Genderlist.Name = "Genderlist";
            Genderlist.Size = new Size(151, 28);
            Genderlist.TabIndex = 4;
            Genderlist.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(94, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 4);
            button3.Name = "button3";
            button3.Size = new Size(60, 22);
            button3.TabIndex = 2;
            button3.Text = "Prev";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += prevButton_Click;
            // 
            // ListData
            // 
            ListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListData.Columns.AddRange(new DataGridViewColumn[] { ID, FullName, Gender, Subject1, Subject2, Subject3, AVG, Classification, Delete });
            ListData.Location = new Point(1, 266);
            ListData.Name = "ListData";
            ListData.RowHeadersWidth = 51;
            ListData.Size = new Size(1181, 455);
            ListData.TabIndex = 1;
            ListData.CellClick += ListNumber_CellClick;
            ListData.CellContentClick += ListNumber_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Resizable = DataGridViewTriState.True;
            ID.Width = 125;
            // 
            // FullName
            // 
            FullName.HeaderText = "FullName";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 125;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Items.AddRange(new object[] { "Male", "Female" });
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Resizable = DataGridViewTriState.True;
            Gender.Width = 125;
            // 
            // Subject1
            // 
            Subject1.HeaderText = "Subject 1";
            Subject1.MinimumWidth = 6;
            Subject1.Name = "Subject1";
            Subject1.Resizable = DataGridViewTriState.True;
            Subject1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Subject1.Width = 125;
            // 
            // Subject2
            // 
            Subject2.HeaderText = "Subject 2";
            Subject2.MinimumWidth = 6;
            Subject2.Name = "Subject2";
            Subject2.Width = 125;
            // 
            // Subject3
            // 
            Subject3.HeaderText = "Subject 3";
            Subject3.MinimumWidth = 6;
            Subject3.Name = "Subject3";
            Subject3.Width = 125;
            // 
            // AVG
            // 
            AVG.HeaderText = "Average";
            AVG.MinimumWidth = 6;
            AVG.Name = "AVG";
            AVG.Width = 125;
            // 
            // Classification
            // 
            Classification.HeaderText = "Classification";
            Classification.Items.AddRange(new object[] { "Excellent", "", "Good", "Average", "", "Below Average", "", "Poor" });
            Classification.MinimumWidth = 6;
            Classification.Name = "Classification";
            Classification.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Width = 125;
            // 
            // Statistic
            // 
            Statistic.Location = new Point(93, 4);
            Statistic.Name = "Statistic";
            Statistic.Size = new Size(94, 29);
            Statistic.TabIndex = 3;
            Statistic.Text = "Statistic";
            Statistic.UseVisualStyleBackColor = true;
            Statistic.Click += Statistic_Click;
            // 
            // Table
            // 
            Table.Location = new Point(560, 15);
            Table.Name = "Table";
            Table.Size = new Size(611, 245);
            Table.TabIndex = 4;
            Table.Text = "";
            // 
            // Lab01_Excersice_5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 760);
            Controls.Add(Table);
            Controls.Add(Statistic);
            Controls.Add(button3);
            Controls.Add(ListData);
            Controls.Add(groupBox1);
            Name = "Lab01_Excersice_5";
            Text = "Candidate Management";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtName;
        private Button deleteData_btn;
        private Button button1;
        private TextBox Subj3;
        private TextBox Subj2;
        private TextBox Subj1;
        private ComboBox Genderlist;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button3;
        private DataGridView ListData;
        private Button Statistic;
        private RichTextBox Table;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewComboBoxColumn Gender;
        private DataGridViewTextBoxColumn Subject1;
        private DataGridViewTextBoxColumn Subject2;
        private DataGridViewTextBoxColumn Subject3;
        private DataGridViewTextBoxColumn AVG;
        private DataGridViewComboBoxColumn Classification;
        private DataGridViewButtonColumn Delete;
    }
}
