using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtatCalculator
{
    public partial class Calculator : Form
    {
        public static double? num = null;
        public static double? num2 = null;
        public static string action = String.Empty;

        double? result = 0;

        public Calculator()
        {
            InitializeComponent();
            Starting();
        }
        private void Starting()
        {
            if (num == null && num2 == null && string.IsNullOrEmpty(action))
            {
                screen.Text = button0.Text;
            }
        }
        private void ActionCase()
        {
            switch (action)
            {
                case "+":
                    if (!num.HasValue) num = 0;
                    num += double.Parse(screen.Text.ToString());
                    break;
                case "-":
                    if (!num.HasValue) num = 0;
                    num -= double.Parse(screen.Text.ToString());
                    break;
                case "*":
                    if (!num.HasValue) num = 1;
                    num *= double.Parse(screen.Text.ToString());
                    break;
                case "/":
                    if (!num.HasValue) num = 1;
                    num /= double.Parse(screen.Text.ToString());
                    break;
            }
        }
        private static bool IsIn(string symbol, double num)
        {
            string temp;
            temp = num.ToString();
            return temp.Contains(symbol);
        }

        private void NegativeNums(string buttonNumber)
        {
            if (screen.Text == minus.Text)
            {
                if (string.IsNullOrEmpty(action) && num == null)
                {
                    screen.Text += buttonNumber;
                    num = double.Parse(screen.Text.ToString());
                }
                if (!string.IsNullOrEmpty(action) && num != null && num2 == null)
                {
                    if (action != "-")
                    {
                        screen.Text += buttonNumber;
                        num2 = double.Parse(screen.Text.ToString());
                    }
                }
            }
        }
        private void AtatikDmbo(string buttonNumber)
        {
            if (screen.Text == button0.Text)
            {
                screen.Text = buttonNumber;
            }
            else if (screen.Text != plus.Text && screen.Text != minus.Text && screen.Text != multiply.Text && screen.Text != divide.Text)
                screen.Text += buttonNumber;
            else if (IsIn(minus.Text, double.Parse(buttonNumber)))
                screen.Text += buttonNumber;
            screen.Text = buttonNumber;


            if (string.IsNullOrEmpty(action) && num == null)
                num = double.Parse(screen.Text.ToString());

            if (!string.IsNullOrEmpty(action) && num != null && num2 == null)
                num2 = double.Parse(screen.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
            NegativeNums(button1.Text);
            AtatikDmbo(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightBlue;
            NegativeNums(button2.Text);
            AtatikDmbo(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightBlue;
            NegativeNums(button3.Text);
            AtatikDmbo(button3.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            NegativeNums(button4.Text);
            AtatikDmbo(button4.Text);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightBlue;
            NegativeNums(button5.Text);
            AtatikDmbo(button5.Text);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightBlue;
            NegativeNums(button6.Text);
            AtatikDmbo(button6.Text);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.LightBlue;
            NegativeNums(button7.Text);
            AtatikDmbo(button7.Text);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.LightBlue;
            NegativeNums(button8.Text);
            AtatikDmbo(button8.Text);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.LightBlue;
            NegativeNums(button9.Text);
            AtatikDmbo(button9.Text);
        }
        private void button0_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.LightBlue;
            NegativeNums(button0.Text);
            AtatikDmbo(button0.Text);
        }

        private void point_Click(object sender, EventArgs e)
        {
            point.BackColor = Color.LightBlue;
            AtatikDmbo(point.Text);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            plus.BackColor = Color.LightBlue;
            screen.Text = plus.Text;
            if (string.IsNullOrEmpty(action))
                action = "+";
            if (num != null && num2 != null)
            {
                Calculate();
                action = "+";
                Calc2();
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            minus.BackColor = Color.LightBlue;
            screen.Text = minus.Text;


            if (string.IsNullOrEmpty(action) && num != null && num2 == null)
                action = "-";
            else if (string.IsNullOrEmpty(action) && num == null && num2 == null)
            {
                screen.Text = minus.Text;
            }
            else if (!string.IsNullOrEmpty(action) && num != null && num2 == null)
            {
                screen.Text = minus.Text;
            }
            if (num != null && num2 != null)
            {
                Calculate();
                action = "-";
                Calc2();
            }
        }


        private void multiply_Click(object sender, EventArgs e)
        {
            multiply.BackColor = Color.LightBlue;
            screen.Text = multiply.Text;
            if (string.IsNullOrEmpty(action))
                action = "*";
            if (num != null && num2 != null)
            {
                Calculate();
                action = "*";
                Calc2();
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            divide.BackColor = Color.LightBlue;
            screen.Text = divide.Text;
            if (string.IsNullOrEmpty(action)) action = "/";
            if (num != null && num2 != null)
            {
                Calculate();
                action = "/";
                Calc2();
            }
        }
        private void equal_Click(object sender, EventArgs e)
        {
            equal.BackColor = Color.LightBlue;
            if (num != null && num2 != null)
            {
                Calculate();
            }
        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            SquareRoot.BackColor = Color.LightBlue;
            screen.Text = SquareRoot.Text;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            Square.BackColor = Color.LightBlue;
            screen.Text = Square.Text;

            if (num != null)
            {
                result = (double)(num * num);
                screen.Text = result.ToString();
                num = result;
            }
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            Percent.BackColor = Color.LightBlue;
            //screen.Text = Percent.Text;
            if (num != null && num2 != null && action == multiply.Text)
            {
                Calculate();
                result /= 100;
                screen.Text = result.ToString();
                num2 = null;
                num = result;
            }
        }


        private void buttonC_Click(object sender, EventArgs e)
        {
            screen.Text = null;
            action = null;
            num = null;
            num2 = null;
            Starting();
        }



        public void Calculate()
        {
            if ((num != null || num2 != null) && !string.IsNullOrEmpty(action))
            {
                if (action == "+")
                {
                    result = (double)(num + num2);
                    screen.Text = result.ToString();
                    num2 = null;
                    num = result;
                }
                if (action == "-")
                {
                    result = (double)(num - num2);
                    screen.Text = result.ToString();
                    num2 = null;
                    num = result;
                }
                if (action == "*")
                {
                    result = (double)(num * num2);
                    screen.Text = result.ToString();
                    num2 = null;
                    num = result;
                }
                if (action == "/")
                {
                    result = (double)(num / num2);
                    screen.Text = result.ToString();
                    num2 = null;
                    num = result;
                }
            }
        }
        private void Calc2()
        {
            if (result != null)
            {
                switch (action)
                {
                    case "+":
                        screen.Text = result.ToString();
                        screen.Text += "+";
                        break;
                    case "-":
                        screen.Text = result.ToString();
                        screen.Text += "-";
                        break;
                    case "*":
                        screen.Text = result.ToString();
                        screen.Text += "*";
                        break;
                    case "/":
                        screen.Text = result.ToString();
                        screen.Text += "/";
                        break;
                }
            }
        }



        #region Design
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.LightGray;
        }
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }
        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.LightGray;
        }
        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.LightGray;
        }
        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.LightGray;
        }
        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.LightGray;
        }
        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            button8.BackColor = Color.LightGray;
        }
        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            button9.BackColor = Color.LightGray;
        }
        private void button0_MouseClick(object sender, MouseEventArgs e)
        {
            button0.BackColor = Color.LightGray;
        }
        private void point_MouseClick(object sender, MouseEventArgs e)
        {
            point.BackColor = Color.LightGray;
        }
        private void buttonC_MouseClick(object sender, MouseEventArgs e)
        {
            buttonC.BackColor = Color.LightGray;
        }
        private void plus_MouseClick(object sender, MouseEventArgs e)
        {
            plus.BackColor = Color.LightGray;
        }
        private void minus_MouseClick(object sender, MouseEventArgs e)
        {
            minus.BackColor = Color.LightGray;
        }
        private void multiply_MouseClick(object sender, MouseEventArgs e)
        {
            multiply.BackColor = Color.LightGray;
        }
        private void divide_MouseClick(object sender, MouseEventArgs e)
        {
            divide.BackColor = Color.LightGray;
        }
        private void Square_MouseClick(object sender, MouseEventArgs e)
        {
            Square.BackColor = Color.LightGray;
        }
        private void SquareRoot_MouseClick(object sender, MouseEventArgs e)
        {
            SquareRoot.BackColor = Color.LightGray;
        }
        private void Percent_MouseClick(object sender, MouseEventArgs e)
        {
            Percent.BackColor = Color.LightGray;
        }

        private void equal_MouseClick(object sender, MouseEventArgs e)
        {
            equal.BackColor = Color.LightGray;
        }
        #endregion

    }
}
