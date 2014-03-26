using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Matrix with elements "newLetter"
        /// show where are the point of elements X (1) or Y (2).
        /// </summary>
        private int[,] matrix = new int[3, 3];

        /// <summary>
        /// Add to atrix new point of letter.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="letter"></param>
        private void modifyMatrix(int index, char letter)
        {
            // X: newLetter = 1; O: newLetter = 2;
            int newLetter = 2;
            if (letter == 'X')
            {
                newLetter = 1;
            }
            switch (index)
            {
                case 0:
                    this.matrix[0, 0] = newLetter;
                    break;
                case 1:
                    this.matrix[0, 1] = newLetter;
                    break;
                case 2:
                    this.matrix[0, 2] = newLetter;
                    break;
                case 3:
                    this.matrix[1, 0] = newLetter;
                    break;
                case 4:
                    this.matrix[1, 1] = newLetter;
                    break;
                case 5:
                    this.matrix[1, 2] = newLetter;
                    break;
                case 6:
                    this.matrix[2, 0] = newLetter;
                    break;
                case 7:
                    this.matrix[2, 1] = newLetter;
                    break;
                case 8:
                    this.matrix[2, 2] = newLetter;
                    break;
            }
        }

        /// <summary>
        /// return: Is player win?
        /// </summary>
        /// <returns></returns>
        private bool isWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((this.matrix[i, 0] != 0) && (this.matrix[i, 0] == this.matrix[i, 1]) && (this.matrix[i, 1] == this.matrix[i, 2]))
                    return true;
                if (this.matrix[0, i] != 0 && this.matrix[0, i] == this.matrix[1, i] && this.matrix[1, i] == this.matrix[2, i])
                    return true;
            }
            if (this.matrix[0, 0] != 0 && this.matrix[0, 0] == this.matrix[1, 1] && this.matrix[1, 1] == this.matrix[2, 2])
                return true;
            if (this.matrix[0, 2] != 0 && this.matrix[0, 2] == this.matrix[1, 1] && this.matrix[1, 1] == this.matrix[2, 0])
                return true;
            return false;
        }

        /// <summary>
        /// If player win, message box with congradulation is shown.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="element"></param>
        private void youAreWin(int index, char element)
        {
            modifyMatrix(index, element);
            if (isWin())
            {
                string congradulation = "' " + Convert.ToString(element) + " ' " + "! You are win!";
                DialogResult messageCongradulations = MessageBox.Show(congradulation, "Our congratulations!");
                if(messageCongradulations ==DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Is element O add now?
        /// If false then we add X.
        /// </summary>
        private bool oNow { get; set; }

        /// <summary>
        /// Button is clicked.
        /// </summary>
        /// <param name="button"></param>
        private void toDo(Button button)
        {
            if (button.Text == "")
            {
                if (!this.oNow)
                {
                    button.Text = "X";
                    this.oNow = true;
                    this.youAreWin(button.TabIndex, 'X');
                    return;
                }
                button.Text = "O";
                this.oNow = false;
                this.youAreWin(button.TabIndex, 'O');
                return;
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toDo(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toDo(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toDo(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toDo(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toDo(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            toDo(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            toDo(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            toDo(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            toDo(button9);
        }

    }
}
