using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{

    public partial class Lab1_Menu : Form
    {
        public Lab1_Menu()
        {
            InitializeComponent();

        }

        private void Excercise1button_Click(object sender, EventArgs e)
        {
            Lab01_Excersice_1 lb1 = new Lab01_Excersice_1();
            lb1.ShowDialog();
        }

        private void Excercise2button_Click(object sender, EventArgs e)
        {
            Lab01_Excersice_2 lb2 = new Lab01_Excersice_2();
            lb2.ShowDialog();
        }

        private void Excercise3button_Click(object sender, EventArgs e)
        {
            Lab01_Excersice_3 lb3 = new Lab01_Excersice_3();
            lb3.ShowDialog();
        }

        private void Excercise4button_Click(object sender, EventArgs e)
        {
            Lab01_Excersice_4 lb4 = new Lab01_Excersice_4();
            lb4.ShowDialog();
        }

        private void Excercise5_Click(object sender, EventArgs e)
        {
            Lab01_Excersice_5 lb5 = new Lab01_Excersice_5();
            lb5.ShowDialog();
        }
    }
}
