using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class Lab01_Excersice_1 : Form
    {
        public Lab01_Excersice_1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                a = Convert.ToDouble(TNumber1.Text);
                b = Convert.ToDouble(TNumber2.Text);
                c = Convert.ToDouble(TNumber3.Text);
                double Max = a, Min = a;
                if (b >= Max) Max = b;
                else if (c >= Max) Max = c;
                else Max = a;
                TMaxNum.Text = Max.ToString();
                if (b <= Min) Min = b;
                else if (c <= Min) Min = c;
                else Min = a;
                TMinNum.Text = Min.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dls = MessageBox.Show("Are you sure want to delete the calculation?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dls == DialogResult.OK)
            {
                TNumber1.Clear();
                TNumber2.Clear();
                TNumber3.Clear();
                TMaxNum.Clear();
                TMinNum.Clear();
            }
            else { }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure want to exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                Close();
            }
            else { }
        }

    }
}

