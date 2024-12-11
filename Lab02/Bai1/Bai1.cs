using System.IO;
using System;
using System.Text;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Bai1 : Form
    {
        string filecontent = "";
        public Bai1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "*.txt|*.txt|*.bin|*.bin|*.*|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = File.Open(ofd.FileName, FileMode.OpenOrCreate))
                    {

                        StringBuilder sb = new StringBuilder();

                        using (StreamReader sr = new StreamReader(fs))
                        {
                            filecontent = sr.ReadToEnd();

                            this.richTextBox1.Text = filecontent;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string outputFile = "output1.txt";
            filecontent = richTextBox1.Text;
            try
            {
                string upperContent = filecontent.ToUpper();
                using (StreamWriter sw = new StreamWriter(outputFile))
                {
                    sw.WriteLine(upperContent);
                }

                MessageBox.Show("File saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to the file: " + ex.Message);
            }
        }

    }
}