using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа___1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double firstnumber;
                double secondnumber;

                firstnumber = Convert.ToDouble(textBox1.Text);
                secondnumber = Convert.ToDouble(textBox2.Text);


                switch (comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(firstnumber + secondnumber);
                        break;

                    case "-":
                        textBox3.Text = Convert.ToString(firstnumber - secondnumber);
                        break;

                    case "*":
                        textBox3.Text = Convert.ToString(firstnumber * secondnumber);
                        break;

                    case "/":
                        if(secondnumber == 0)
                        {
                            MessageBox.Show("На нуль делить нельзя");
                        }
                        textBox3.Text = Convert.ToString(firstnumber / secondnumber);
                        break;

                    case "%":
                        textBox3.Text = Convert.ToString(firstnumber % secondnumber);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Неверно введены данные!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                MessageBox.Show("Данные очищены");
            }
            catch
            {
                MessageBox.Show("Данные не смогли очиститься!");
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double pownumber;
                pownumber = Convert.ToDouble(textBox4.Text);
                double receivednumber;
                receivednumber = Convert.ToDouble(textBox3.Text);
                switch (comboBox2.Text)
                {
                    case "sqrt":
                        textBox3.Text = Convert.ToString(Math.Sqrt(receivednumber));
                        break;
                    case "sqrt3":
                        textBox3.Text = Convert.ToString(Math.Pow(receivednumber, 1.0 / 3.0));
                        break;
                    case "sin":
                        textBox3.Text = Convert.ToString(Math.Sin(receivednumber));
                        break;
                    case "cos":
                        textBox3.Text = Convert.ToString(Math.Cos(receivednumber));
                        break;
                    case "tan":
                        textBox3.Text = Convert.ToString(Math.Tan(receivednumber));
                        break;
                    case "^":
                        textBox3.Text = Convert.ToString(Math.Pow(receivednumber, pownumber));
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }
    }
}
