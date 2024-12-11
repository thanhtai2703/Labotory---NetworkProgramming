using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB01
{
    public partial class Lab01_Excersice_2 : Form
    {
        public Lab01_Excersice_2()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateB_Click(object sender, EventArgs e)
        {
            try
            {
                int A = int.Parse(textBox1.Text);
                int B = int.Parse(textBox2.Text);

                if (comboBox1.SelectedItem.ToString() == "Multiplication table")
                {
                    int result = B - A;
                    string multiplicationTable = "Multiplication table of " + result + ":\n";
                    for (int i = 1; i <= 10; i++)
                    {
                        multiplicationTable += $"{result} x {i} = {result * i}\n";
                    }
                    ResultBox.Text = multiplicationTable;
                }
                else if (comboBox1.SelectedItem.ToString() == "Calculate values")
                {
                    int diff = A - B;

                    long factorial = 1;
                    for (int i = 1; i <= Math.Abs(diff); i++)
                    {
                        factorial *= i;
                    }

                    long sum = 0;
                    for (int i = 1; i <= B; i++)
                    {
                        sum += (long)Math.Pow(A, i);
                    }

                    string result = $"(A - B)! = {factorial}\nSum S = {sum}";
                    ResultBox.Text = result;
                }
                else
                {
                    MessageBox.Show("Please select a function!");
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            DialogResult dls = MessageBox.Show("Are you sure want to delete the calculation?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dls == DialogResult.OK)
            {
                textBox1.Clear();
                textBox2.Clear();
                ResultBox.Clear();
            }
            else { }
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure want to exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                Close();

            }
            else { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure want to exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;
        }
    }
}
