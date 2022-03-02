using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        string inputField = "0";
        double firstNum;
        double result = 0;
        char operation;
        bool flagMinus = false;
        bool afterMulti = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            input.Text += "1";
            inputField += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.Text += "2";
            inputField += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input.Text += "3";
            inputField += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input.Text += "4";
            inputField += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input.Text += "5";
            inputField += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input.Text += "6";
            inputField += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input.Text += "7";
            inputField += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input.Text += "8";
            inputField += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input.Text += "9";
            inputField += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input.Text += "0";
            inputField += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            input.Text += '+';
            firstNum = Convert.ToDouble(inputField);
            inputField = "0";
            result += firstNum;
            operation = '+';
            flagMinus = true;
            Console.WriteLine($"Plus result = {result}");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            input.Text += '-';
            firstNum = Convert.ToDouble(inputField);
            inputField = "-";

            if (flagMinus == false) { 
                result = firstNum;
                flagMinus = true;
            }
            else
                result+=firstNum;
            Console.WriteLine($"Minus result = {result}");
            operation = '-';
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            input.Text += '*';
            
            if (afterMulti == false)
            {
                firstNum = Convert.ToDouble(inputField);
                inputField = "0";
            }
            else {
                operation = '*';
                afterMulti = false;
                return;
            }

            if (flagMinus == false) {
                result = firstNum;
                flagMinus = true;
            }
            else
                result *= firstNum;

            operation = '*';
            Console.WriteLine($"Multi result = {result}");
        }

        private void buttonDivided_Click(object sender, EventArgs e)
        {
            input.Text += '/';
            
            if (afterMulti == false)
            {
                firstNum = Convert.ToDouble(inputField);
                inputField = "0";
            }
            else
            {
                operation = '/';
                afterMulti = false;
                return;
            }
            if (flagMinus == false)
            {
                result = firstNum;
                flagMinus = true;
            }
            else
                result /= firstNum;
            operation= '/';
            Console.WriteLine($"Divided result = {result}");
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

            
            switch (operation) {
                case '+':
                    result+=Convert.ToDouble(inputField);
                    afterMulti = true;
                    break;
                case '-':
                    result+=Convert.ToDouble(inputField);
                    afterMulti = true;
                    break;
                case '*':
                    result*=Convert.ToDouble(inputField);
                    afterMulti = true;
                    Console.WriteLine($"Multi switch result = {result}");
                    break;
                case '/':
                    result/=Convert.ToDouble(inputField);
                    afterMulti = true;
                    Console.WriteLine($"Divided switch result = {result}");
                    break;
            }

            answer.Text = result.ToString();
            Console.WriteLine($"Equals result = {result}");
            inputField = "0";
        }
    }
}