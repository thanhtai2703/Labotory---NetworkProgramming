namespace LAB01
{
    public partial class Lab01_Excersice_3 : Form
    {
        public Lab01_Excersice_3()
        {
            InitializeComponent();
        }

        string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] units = { "", " thousand", " million", " billion" };

        private void convertBtn_Click(object sender, EventArgs e)
        {
            long number;

            if (long.TryParse(textBox1.Text, out number) && number >= 0 && textBox1.Text.Length <= 12)
            {
                lbResult.Text = NumberToWords(number);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer (up to 12 digits).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string NumberToWords(long number)
        {
            if (number == 0)
                return "zero";

            string words = "";
            int unitIndex = 0;

            while (number > 0)
            {
                int group = (int)(number % 1000);
                if (group != 0)
                {
                    string groupWords = GroupToWords(group);
                    words = groupWords + units[unitIndex] + " " + words;
                }
                number /= 1000;
                unitIndex++;
            }

            return words.Trim();
        }

        private string GroupToWords(int number)
        {
            int hundreds = number / 100;
            int remainder = number % 100;
            int tensValue = remainder / 10;
            int onesValue = remainder % 10;

            string result = "";

            if (hundreds > 0)
            {
                result += ones[hundreds] + " hundred";
                if (remainder > 0)
                    result += " ";
            }

            if (tensValue >= 2)
            {
                result += tens[tensValue];
                if (onesValue > 0)
                    result += " " + ones[onesValue];
            }
            else if (tensValue == 1)
            {
                result += teens[onesValue];
            }
            else if (onesValue > 0)
            {
                result += "and " + ones[onesValue];
            }

            return result;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
