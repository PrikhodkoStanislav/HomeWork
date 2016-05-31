using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha1_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            NewInitialize();
        }

        /// <summary>
        /// Initalization of variables.
        /// </summary>
        private void NewInitialize()
        {
            isNumber1 = true;
            error = false;
            newOperation = false;
            fraction = false;
            integerPart1 = 0;
            integerPart2 = 0;
            fractionDenominator1 = 1;
            fractionDenominator2 = 1;
            fractionNumerator1 = 0;
            fractionNumerator2 = 0;
            operation = '+';
            textBox1.Text = "0";
        }

        /// <summary>
        /// Integer part of number 1.
        /// </summary>
        private int integerPart1 { get; set;}

        /// <summary>
        /// Numerator of fraction of number 1.
        /// </summary>
        private int fractionNumerator1 { get; set; }

        /// <summary>
        /// Denomerator of fraction of number 2.
        /// </summary>
        private int fractionDenominator1 { get; set; }

        /// <summary>
        /// Iteger part of number 2.
        /// </summary>
        private int integerPart2 { get; set;}

        /// <summary>
        /// Numerator of fraction of number 2.
        /// </summary>
        private int fractionNumerator2 { get; set; }

        /// <summary>
        /// Denomerator of fraction of number 2.
        /// </summary>
        private int fractionDenominator2 { get; set; }

        /// <summary>
        /// Result of the operation.
        /// </summary>
        private double result { get; set; }

        /// <summary>
        /// Intefer part of the result.
        /// </summary>
        private int resultIntegerPart { get; set; }
        
        /// <summary>
        /// Numerator of fraction of result.
        /// </summary>
        private int resultFracNumerator { get; set; }

        /// <summary>
        /// Denominator of fraction of result.
        /// </summary>
        private int resultFracDenominator { get; set; }

        /// <summary>
        /// Is number 1 input now?
        /// </summary>
        private bool isNumber1 { get; set; }

        /// <summary>
        /// Operation.
        /// </summary>
        private char operation { get; set; }

        /// <summary>
        /// Is error now (division by 0) ?
        /// </summary>
        private bool error { get; set; }

        /// <summary>
        /// Is we make new operation now?
        /// </summary>
        private bool newOperation { get; set; }

        /// <summary>
        /// Is we input fraction of number now?
        /// </summary>
        private bool fraction { get; set; }

        /// <summary>
        /// Number 1 = result. Number 2 = 0.
        /// (Count new operation with result and new number)
        /// </summary>
        private void NewElements()
        {
            integerPart1 = resultIntegerPart;
            fractionNumerator1 = resultFracNumerator;
            fractionDenominator1 = resultFracDenominator;
            integerPart2 = 0;
            fractionNumerator2 = 0;
            fractionDenominator2 = 1;
        }

        /// <summary>
        /// Count result of operation.
        /// </summary>
        private void Count()
        {
            double number1 = (double)integerPart1 + ((double)fractionNumerator1 / (double)fractionDenominator1);
            double number2 = (double)integerPart2 + ((double)fractionNumerator2 / (double)fractionDenominator2);
            if (operation == '+')
            {
                result = (number1 + number2);
                resultIntegerPart = (int)result;
                resultFracDenominator = fractionDenominator1 * fractionDenominator2;
                resultFracNumerator = (fractionNumerator1 * fractionDenominator2) + (fractionNumerator2 * fractionDenominator1) - ((resultIntegerPart - (integerPart1 + integerPart2)) * resultFracDenominator);
            }
            if (operation == '-')
            {
                result = (number1 - number2);
                resultIntegerPart = (int)result;
                resultFracDenominator = fractionDenominator1 * fractionDenominator2;
                resultFracNumerator = (fractionNumerator1 * fractionDenominator2) - (fractionNumerator2 * fractionDenominator1) + (((integerPart1 - integerPart2) - resultIntegerPart) * resultFracDenominator);
            }
            if (operation == '*')
            {
                result = (number1 * number2);
                resultIntegerPart = (int)result;
                resultFracDenominator = fractionDenominator1 * fractionDenominator2;
                resultFracNumerator = (fractionNumerator1 * fractionNumerator2) + (fractionNumerator1 * integerPart2 * fractionDenominator2) + (integerPart1 * fractionNumerator2 * fractionDenominator1) - ((resultIntegerPart - (integerPart1 * integerPart2)) * resultFracDenominator);
            }
            if (operation == '/')
            {
                if (number2 == 0)
                {
                    textBox1.Text = "Error!";
                    error = true;
                }
                else
                {
                    result = (number1 / number2);
                    resultIntegerPart = (int)result;
                    resultFracDenominator = (integerPart2 * fractionDenominator2 + fractionNumerator2) * fractionDenominator1;
                    resultFracNumerator = ((integerPart1 * fractionDenominator1 + fractionNumerator1) * fractionDenominator2) - (resultIntegerPart * resultFracDenominator);
                }
            }
            NewElements();
        }

        /// <summary>
        /// Input number to dial.
        /// </summary>
        /// <param name="element"></param>
        private void NewNumber(int element)
        {
            if (isNumber1)
            {
                if (fraction)
                {
                    fractionNumerator1 = fractionNumerator1 * 10 + element;
                    fractionDenominator1 = fractionDenominator1 * 10;
                }
                else
                    integerPart1 = integerPart1 * 10 + element;
            }
            else
            {
                if (fraction)
                {
                    fractionNumerator2 = fractionNumerator2 * 10 + element;
                    fractionDenominator2 *= 10;
                }
                else
                    integerPart2 = integerPart2 * 10 + element;
            }
        }

        /// <summary>
        /// Number click now.
        /// </summary>
        /// <param name="number"></param>
        private void NumberClick(int number)
        {
            if (error || newOperation)
            {
                NewInitialize();
            }
            if (textBox1.Text != "0")
            {
                textBox1.Text += number.ToString();
            }
            else
            {
                textBox1.Text = number.ToString();
            }
            NewNumber(number);
        }

        /// <summary>
        /// Operation click now.
        /// </summary>
        /// <param name="element"></param>
        private void OperationClick(string element)
        {
            if (error)
            {
                textBox1.Text = "";
            }
            error = false;
            newOperation = false;
            isNumber1 = false;
            fraction = false;
            operation = Convert.ToChar(element);
            textBox1.Text += " " + element.ToString() + " ";
        }

        /// <summary>
        /// Number click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void number_Click(object sender, EventArgs e)
        {
            NumberClick((sender as Button).TabIndex);
        }

        /// <summary>
        /// Operation click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operation_Click(object sender, EventArgs e)
        {
            OperationClick((sender as Button).Text);
        }

        /// <summary>
        /// "="
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            Count();
            if (!error)
            {
                textBox1.Text = result.ToString();
            }
            isNumber1 = true;
            newOperation = true;
        }

        /// <summary>
        /// ","
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            fraction = true;
        }

        /// <summary>
        /// Don't touch text box!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
