using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;
namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();

            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                float result = 0;

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "+":
                        result = Calculator.Addition(num1, num2);
                        break;
                    case "-":
                        result = Calculator.Subtraction(num1, num2);
                        break;
                    case "*":
                        result = Calculator.Multiplication(num1, num2);
                        break;
                    case "/":
                        result = Calculator.Division(num1, num2);
                        break;
                    default:
                        MessageBox.Show("Please select an operation.");
                        return;
                }

                label3.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
