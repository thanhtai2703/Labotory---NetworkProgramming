using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInputPath.Text = openFileDialog.FileName;
                //Hiển thị đường dẫn file
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string inputFilePath = txtInputPath.Text;
            string outputFilePath = "output3.txt";

            if (File.Exists(inputFilePath))
            {
                string[] lines = File.ReadAllLines(inputFilePath);
                List<string> results = new List<string>();

                bool hasError = false;

                foreach (string line in lines)
                {
                    string expression = line.Trim();

                    if (string.IsNullOrEmpty(expression))
                    {
                        continue;
                    }

                    double result = EvaluateExpression(expression);
                    if (result == 0 && expression != "0")
                    {
                        hasError = true;
                        MessageBox.Show($"Lỗi: Invalid expression '{expression}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    results.Add($"{expression} = {result}");
                }

                if (hasError)
                {
                    File.WriteAllLines(outputFilePath, new[] { "ERROR" });
                    txtOutput.Text = "ERROR";

                    MessageBox.Show("Calculation failed! Please select the file containing the expression.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    File.WriteAllLines(outputFilePath, results);
                    txtOutput.Text = string.Join(Environment.NewLine, results);
                    MessageBox.Show("Calculation successful! The result has been written to the file output3.txt.", "Notification");
                }
            }
            else
            {
                MessageBox.Show("Input file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double EvaluateExpression(string expression)
        {
            expression = expression.Replace(" ", "");

            var values = new Stack<double>();
            var operators = new Stack<char>();

            int i = 0;
            while (i < expression.Length)
            {
                if (char.IsDigit(expression[i]) || expression[i] == '.')
                {
                    string num = "";
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        num += expression[i++];
                    }
                    values.Push(double.Parse(num));
                }
                else if (expression[i] == '(')
                {
                    operators.Push(expression[i]);
                    i++;
                }
                else if (expression[i] == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        values.Push(ApplyOperator(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    operators.Pop();
                    i++;
                }
                else if (IsOperator(expression[i]))
                {
                    while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(expression[i]))
                    {
                        if (values.Count < 2)
                        {
                            MessageBox.Show("Error: Invalid expression.");
                            return 0;
                        }
                        values.Push(ApplyOperator(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    operators.Push(expression[i]);
                    i++;
                }
                else
                {
                    MessageBox.Show($"Error: Invalid character '{expression[i]}' in expression.");
                    return 0;
                }
            }

            while (operators.Count > 0)
            {
                if (values.Count < 2)
                {
                    MessageBox.Show("Error: Invalid expression.");
                    return 0;
                }
                values.Push(ApplyOperator(operators.Pop(), values.Pop(), values.Pop()));
            }

            return values.Count > 0 ? values.Pop() : 0;
        }


        private bool IsOperator(char op)
        {
            return op == '+' || op == '-' || op == '*' || op == '/';
        }

        private int Precedence(char op)
        {
            if (op == '+' || op == '-')
                return 1;
            if (op == '*' || op == '/')
                return 2;
            return 0;
        }

        private double ApplyOperator(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: throw new ArgumentException("Invalid operator");
            }
        }

    }
}
