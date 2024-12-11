using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class Lab01_Excersice_5 : Form
    {
        public Lab01_Excersice_5()
        {
            InitializeComponent();
            txtName.MaxLength = 30;
            Delete.Text = "DELETE";
            Delete.UseColumnTextForButtonValue = true;
        }
        public int idcounter = 0;
        public int insertPos = 0;
        public string Ranking;
        public string IdTS;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void UpdateId(int number)
        {
            if (number < 10)
            {
                IdTS = "TS00" + number.ToString();
            }
            else if (number >= 10)
            {
                IdTS = "TS0" + number.ToString();
            }
            else IdTS = "TS" + number.ToString();
        }
        private bool Check()
        {
            if (txtName.Text == ""||Genderlist.Text == "" || Subj1.Text == "" || Subj2.Text == "" || Subj3.Text == "") return false;
            if (Convert.ToDouble(Subj1.Text) > 10 || Convert.ToDouble(Subj1.Text) > 10 || Convert.ToDouble(Subj1.Text) > 10)
            {
                return false;
            }
            if (Convert.ToDouble(Subj1.Text) < 0 || Convert.ToDouble(Subj1.Text) < 0 || Convert.ToDouble(Subj1.Text) < 0)
            {
                return false;
            }
                return true;
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    double subj1 = Convert.ToDouble(Subj1.Text);
                    double subj2 = Convert.ToDouble(Subj2.Text);
                    double subj3 = Convert.ToDouble(Subj3.Text);
                    idcounter++;
                    insertPos = idcounter - 1;
                    double avg = (Convert.ToDouble(Subj1.Text) + Convert.ToDouble(Subj2.Text) + Convert.ToDouble(Subj3.Text)) / 3;
                    string gd = Genderlist.SelectedItem.ToString();
                    UpdateId(idcounter);
                    if (avg >= 8 && subj1 > 6.5 && subj2 > 6.5 && subj3 > 6.5)
                    {
                        Ranking = "Excellent";
                    }
                    else if (avg >= 6.5 && subj1 > 5 && subj2 > 5 && subj3 > 5)
                    {
                        Ranking = "Good";
                    }
                    else if (avg >= 5 && subj1 > 3.5 && subj2 > 3.5 && subj3 > 3.5)
                    {
                        Ranking = "Average";
                    }
                    else if (avg >= 3.5 && subj1 > 2 && subj2 > 2 && subj3 > 2)
                    {
                        Ranking = "Below Average";
                    }
                    else Ranking = "Poor";
                    ListData.Rows.Insert(insertPos, IdTS, txtName.Text, gd, Math.Round(subj1, 1), Math.Round(subj2, 1), Math.Round(subj3, 1), Math.Round(avg, 2), Ranking);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("The input data is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            Subj1.Clear();
            Subj2.Clear();
            Subj3.Clear();
            Genderlist.Text = "";
        }

        private void ListNumber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UpdateRowIDs()
        {
            for (int i = 0; i < ListData.Rows.Count - 1; i++)
            {

                UpdateId(i + 1);
                ListData.Rows[i].Cells["ID"].Value = IdTS;
            }


        }

        private void ListNumber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ListData.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                ListData.Rows.RemoveAt(e.RowIndex);
                idcounter--;
                UpdateRowIDs();
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
                int iExc = 0;
                int iGood = 0;
                int iAvg = 0;
                int iBad = 0;
                string student = "";
                double MAX = 0;
                for (int i = 0; i < ListData.Rows.Count; i++)
                {

                    double gpa = Convert.ToDouble(ListData.Rows[i].Cells["AVG"].Value);


                    if (gpa > MAX)
                    {
                        MAX = gpa;
                        student = ListData.Rows[i].Cells["FullName"].Value?.ToString();
                    }

                    string classification = ListData.Rows[i].Cells["Classification"].Value?.ToString();

                    switch (classification)
                    {
                        case "Excellent":
                            iExc++;
                            break;
                        case "Good":
                            iGood++;
                            break;
                        case "Average":
                            iAvg++;
                            break;
                        case "Below Average":
                        case "Poor":
                            iBad++;
                            break;
                    }
                }
                Table.Text = $"Total number of candidates: {idcounter}\n" +
                            $"Student with the highest average score: {student} with GPA: {MAX}\n" +
                            $"Number of students classified as Excellent: {iExc}\n" +
                            $"Number of students classified as Good: {iGood}\n" +
                            $"Number of students classified as Average: {iAvg}\n" +
                            $"Number of students who failed (Below Average/Poor): {iBad}";
            
        }
        
    }

}
