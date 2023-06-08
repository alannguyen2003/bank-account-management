using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Slot2_2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            double num1 = 0, num2 = 0;
            bool isSucess = double.TryParse(number1, out num1);
            bool isSuccess2 = double.TryParse(number2, out num2);
            //MessageBox.Show(isSucess + " " + isSuccess2, "hh", MessageBoxButtons.OK);
            if (isSucess && isSuccess2)
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Second number equals to 0. Try again!", "Thong bao", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Your result: " + (num1 / num2) + ".", "Ket qua", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Number invalid. Try again", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            double num1 = 0, num2 = 0;
            bool isSucess = double.TryParse(number1, out num1);
            bool isSuccess2 = double.TryParse(number2, out num2);
            //MessageBox.Show(isSucess + " " + isSuccess2, "hh", MessageBoxButtons.OK);
            if (isSucess && isSuccess2)
            {
                MessageBox.Show("Your result: " + (num1 + num2) + ".", "Ket qua", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Number invalid. Try again", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            double num1 = 0, num2 = 0;
            bool isSucess = double.TryParse(number1, out num1);
            bool isSuccess2 = double.TryParse(number2, out num2);
            //MessageBox.Show(isSucess + " " + isSuccess2, "hh", MessageBoxButtons.OK);
            if (isSucess && isSuccess2)
            {
                MessageBox.Show("Your result: " + (num1 - num2) + ".", "Ket qua", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Number invalid. Try again", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            double num1 = 0, num2 = 0;
            bool isSucess = double.TryParse(number1, out num1);
            bool isSuccess2 = double.TryParse(number2, out num2);
            //MessageBox.Show(isSucess + " " + isSuccess2, "hh", MessageBoxButtons.OK);
            if (isSucess && isSuccess2)
            {
                MessageBox.Show("Your result: " + (num1 * num2) + ".", "Ket qua", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Number invalid. Try again", "Thong bao", MessageBoxButtons.OK);
            }
        }
    }
}
