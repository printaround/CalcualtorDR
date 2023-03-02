using System;
using System.Windows.Forms;

namespace CalcualtorDR
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "-";
            txtDisplay.Clear();
            txtDisplay.Text = "-";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            History.Clear();
            btnDot.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            if (History.Text.Length > 0)
                History.Text = History.Text.Remove(History.Text.Length - 1, 1);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            Operation = "/";
            History.Text = History.Text + Operation;
            btnDot.Enabled = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            Operation = "*";
            History.Text = History.Text + Operation;
            btnDot.Enabled = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            Operation = "-";
            History.Text = History.Text + Operation;
            btnDot.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            Operation = "+";
            History.Text = History.Text + Operation;
            btnDot.Enabled = true;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "0";
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
                txtDisplay.Text = "0";
            else
                txtDisplay.Text = txtDisplay.Text + "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "1";
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
                txtDisplay.Text = "1";
            else
                txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "2";
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
                txtDisplay.Text = "2";
            else
                txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "3";
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
                txtDisplay.Text = "3";
            else
                txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "4";
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
                txtDisplay.Text = "4";
            else
                txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "5";
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
                txtDisplay.Text = "5";
            else
                txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "6";
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
                txtDisplay.Text = "6";
            else
                txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "7";
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
                txtDisplay.Text = "7";
            else
                txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "8";
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
                txtDisplay.Text = "8";
            else
                txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + "9";
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
                txtDisplay.Text = "9";
            else
                txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            History.Text = History.Text + ".";
            txtDisplay.Text = txtDisplay.Text + ".";
            btnDot.Enabled = false;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            btnDot.Enabled = true;
            History.Text = History.Text + "=";

            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(txtDisplay.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txtDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
                History.Text = History.Text + Result + "; ";
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txtDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
                History.Text = History.Text + Result + "; ";
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txtDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
                History.Text = History.Text + Result + "; ";
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtDisplay.Text = "Cannot divide by zero";
                    History.Text = History.Text + "error; ";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txtDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    History.Text = History.Text + Result + "; ";
                }
            }
        }
    }
}
