using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeissCalculator
{
    public partial class frmCalculator : Form
    {
        #region Private Members
        private string input = string.Empty;
        private double output;
        private string operand1;
        private string operand2;
        double result = 0.0;
        char operation;
        private Operation currentOperation = Operation.NoneSelected;
        #endregion

        #region Public Members
        public enum Operation
        {
            NoneSelected = 0,
            SquareRoot = 1,
            Square = 2,
            Power = 3,
            Reciprocal = 4,

            Division = 5,
            Multiplicaion = 6,
            Subtraction = 7,
            Addition = 8
        }
        #endregion


        public frmCalculator()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(frmCalculator_KeyPress);
        }
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            var pow = Math.Pow(3, 4);
            var sqrt = Math.Sqrt(3);
            var result = 0;
            txtTotal.Text = result.ToString();
        }

        void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show("Form.KeyPress:  '" + e.KeyChar + "' pressed.");

                switch (e.KeyChar)
                {
                    case (char) 48:
                        btnZero_Click(sender, e);
                        break;
                    case (char) 49:
                        btnOne_Click(sender, e);
                        break;
                    case (char) 50:
                        btnTwo_Click(sender, e);
                        break;
                    case (char) 51:
                        btnThree_Click(sender, e);
                        break;
                    case (char) 52:
                        btnFour_Click(sender, e);
                        break;
                    case (char) 53:
                        btnFive_Click(sender, e);
                        break;
                    case (char) 54:
                        btnSix_Click(sender, e);
                        break;
                    case (char) 55:
                        btnSeven_Click(sender, e);
                        break;
                    case (char) 56:
                        btnEight_Click(sender, e);
                        break;
                    case (char) 57:
                        btnNine_Click(sender, e);
                        break;
                    default:
                        MessageBox.Show("Form.KeyPress: '" +
                                         e.KeyChar.ToString() + "' consumed.");
                        e.Handled = true;
                        break;
                }

            }
        }
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                txtTotal.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtTotal.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtTotal.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                        {
                    result = num1 / num2;
                    txtTotal.Text = result.ToString();
                }
                else
                {
                    txtTotal.Text = "Div/Zero!";
                }
            }
           
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "";
            input += "0";
            this.txtTotal.Text += input;

            //if (operand1 == null)
            //{
             //   return;
           // }
           // if (operand2 != null) return;
           // operand2 = 0;

           // txtTotal.Text = "0";
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "";
            input += "1";
            this.txtTotal.Text += input;

            /*if (operand1 == null)
            {
                operand1 = 1;
                return;
            }
            if (operand2 != null) return;
            operand2 = 1;

            txtTotal.Text = "1";*/
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "";
            input += "2";
            this.txtTotal.Text += input;

            /*if (operand1 == null)
            {
                operand1 = 2;
                return;
            }
            if (operand2 != null) return;
            operand2 = 2;

            txtTotal.Text = "2";*/
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "";
            input += "3";
            this.txtTotal.Text += input;

            /*if (operand1 == null)
            {
                operand1 = 3;
                return;
            }
            if (operand2 != null) return;
            operand2 = 3;

            txtTotal.Text = "3";*/
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "";
            input += "4";
            this.txtTotal.Text += input;

            /*if (operand1 == null)
            {
                operand1 = 4;
                return;
            }
            if (operand2 != null) return;
            operand2 = 4;

            txtTotal.Text = "4";*/
        }

        private void btnFive_Click(object sender, EventArgs e)
        {

            this.txtTotal.Text = "";
            input += "5";
            this.txtTotal.Text += input;
            /*if (operand1 == null)
            {
                operand1 = 5;
                return;
            }
            if (operand2 != null) return;
                    operand2 = 5;

            txtTotal.Text = "5";*/
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "";
            input += "6";
            this.txtTotal.Text += input;

            /*if (operand1 == null)
            {
                operand1 = 6;
                return;
            }
            if (operand2 != null) return;
            operand2 = 6;

            txtTotal.Text = "6";*/
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {

            this.txtTotal.Text = "";
            input += "7";
            this.txtTotal.Text += input;
            /*if (operand1 == null)
            {
                operand1 = 7;
                    return;
            }
            if (operand2 != null) return;
            operand2 = 7;

            txtTotal.Text = "7";*/
        }

        private void btnEight_Click(object sender, EventArgs e)
        {

            this.txtTotal.Text = "";
            input += "8";
            this.txtTotal.Text += input;

            /*if (operand1 == null)
            {
                operand1 = 8;
                return;
            }
            if (operand2 != null) return;
            operand2 = 8;

            txtTotal.Text = "8";*/
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "";
            input += "9";
            this.txtTotal.Text += input;

            /*if (operand1 == null)
            {
                operand1 = 9;
                return;
                txtTotal.Text = "9";
            }
            if (operand2 != null) return;
            operand2 = 9'*/



        }
        private void btnSubtract_Click(object sender, EventArgs e)
         {
            operand1 = input;
            operation = '-';
            input = string.Empty;
         }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }
        
        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (operand1 == null) return;
            var btn = (Button)sender;
            double num = 0;

            Math.Sqrt(5);

            if (Double.TryParse(btn.Text, out num))

                txtTotal.Text = output.ToString();

        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            currentOperation = Operation.Square;
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            currentOperation = Operation.Square;
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            /*if (operand1 == null) return; //need an operand to continue
            if (operand2 == 0) txtTotal.Text = "Cannot Divide By Zero.";
            currentOperation = Operation.Reciprocal;

            var btn = (Button)sender;
            double num = 0;

            if (Double.TryParse(txtTotal.Text, out num))
            {
                if (num < 0)
                {
                    return; //cannot take square root of negative numbers
                }
                else
                {

                }
            }*/
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
