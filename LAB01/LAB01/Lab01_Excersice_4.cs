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
    public partial class Lab01_Excersice_4 : Form
    {
        public Lab01_Excersice_4()
        {
            InitializeComponent();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int day = int.Parse(txtDay.Text);
                int month = int.Parse(txtMonth.Text);

                if (month < 1 || month > 12)
                {
                    MessageBox.Show("Invalid month! Please enter a month from 1 to 12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidDate(day, month))
                {
                    MessageBox.Show("Invalid date! Please check the date and month again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string zodiacSign = GetZodiacSign(day, month);
                lblResult.Text = "Equal: " + zodiacSign;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integers for day and month!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred.: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetZodiacSign(int day, int month)
        {
            switch (month)
            {
                case 1:
                    return (day <= 20) ? "Capricorn" : "Aquarius";
                case 2:
                    return (day <= 19) ? "Aquarius" : "Pisces";
                case 3:
                    return (day <= 20) ? "Pisces" : "Aries";
                case 4:
                    return (day <= 20) ? "Aries" : "Taurus";
                case 5:
                    return (day <= 21) ? "Taurus" : "Gemini";
                case 6:
                    return (day <= 21) ? "Gemini" : "Cancer";
                case 7:
                    return (day <= 22) ? "Cancer" : "Leo";
                case 8:
                    return (day <= 22) ? "Leo" : "Virgo";
                case 9:
                    return (day <= 23) ? "Virgo" : "Libra";
                case 10:
                    return (day <= 23) ? "Libra" : "Scorpio";
                case 11:
                    return (day <= 22) ? "Scorpio" : "Sagittarius";
                case 12:
                    return (day <= 21) ? "Sagittarius" : "Capricorn";
                default:
                    return "Invalid date!";
            }
        }
        private bool IsValidDate(int day, int month)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && IsLeapYear(DateTime.Now.Year))
            {
                daysInMonth[1] = 29;
            }

            return day > 0 && day <= daysInMonth[month - 1];
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
