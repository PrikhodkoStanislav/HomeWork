using System;
using System.Windows;
using System.Windows.Controls;

namespace Tic_Tac_Toe_Silverlight
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            matrix = new int[9];
            for (int i = 0; i < 9; i++)
            {
                matrix[i] = 0;
            }
            random = new Random();
            newGame = false;
            arrayOfButtons = new Button[9] { Button1,  Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9};
        }

        /// <summary>
        /// Matrix with components of the button.
        /// 0 = empty. 1 = X. 2 = O.
        /// Indexes and buttons:
        /// 0 1 2
        /// 3 4 5
        /// 6 7 8
        /// </summary>
        private int[] matrix;

        /// <summary>
        /// Random.
        /// </summary>
        private Random random;

        /// <summary>
        /// Array of the buttons.
        /// </summary>
        private Button[] arrayOfButtons;

        /// <summary>
        /// Is new game?
        /// </summary>
        private bool newGame;

        /// <summary>
        /// Is draw in the game?
        /// </summary>
        /// <returns></returns>
        private bool IsDraw()
        {
            for (int i = 0; i < 9; i++)
            {
                if (matrix[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Is gamer win?
        /// </summary>
        /// <returns></returns>
        private bool IsWin()
        {
            // horizontal victory
            if ((matrix[0] != 0 && matrix[0] == matrix[1] && matrix[1] == matrix[2]) || (matrix[3] != 0 && matrix[3] == matrix[4] && matrix[4] == matrix[5]) || (matrix[7] != 0 && matrix[6] == matrix[7] && matrix[7] == matrix[8]))
            {
                return true;
            }
            else
            {
                // vertical victory
                if ((matrix[0] != 0 && matrix[0] == matrix[3] && matrix[3] == matrix[6]) || (matrix[1] != 0 && matrix[1] == matrix[4] && matrix[4] == matrix[7]) || (matrix[5] != 0 && matrix[2] == matrix[5] && matrix[5] == matrix[8]))
                {
                    return true;
                }
                else
                {
                    // diagonal victory
                    if ((matrix[0] != 0 && matrix[0] == matrix[4] && matrix[4] == matrix[8]) || (matrix[2] != 0 && matrix[2] == matrix[4] && matrix[4] == matrix[6]))
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        /// <summary>
        /// Clear the board for new game.
        /// </summary>
        private void ClearTheBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                arrayOfButtons[i].Content = "";
                matrix[i] = 0;
            }
        }

        /// <summary>
        /// If winner win - congratulation.
        /// If draw - message about it.
        /// </summary>
        /// <param name="winner"></param>
        private void YouAreWin(string winner)
        {
            if (IsWin())
            {
                string congratulation = winner + " You are win!";
                MessageBox.Show(congratulation);
                ClearTheBoard();
                newGame = true;
            }
            if (!newGame && IsDraw())
            {
                MessageBox.Show("Draw!");
                ClearTheBoard();
                newGame = true;
            }
        }

        /// <summary>
        /// Computer is moving.
        /// </summary>
        private void ComputerGame()
        {
            int position = random.Next(0, 10000) % 9;
            while (matrix[position] != 0)
            {
                position = random.Next(0, 10000) % 9;
            }
            matrix[position] = 2;
            arrayOfButtons[position].Content = "O";
        }

        /// <summary>
        /// Reaction on button click.
        /// </summary>
        /// <param name="button"></param>
        private void Do(Button button)
        {
            if (matrix[button.TabIndex] == 0)
            {
                button.Content = "X";
                matrix[button.TabIndex] = 1;
                YouAreWin("Player!");
                if (newGame)
                {
                    newGame = false;
                    return;
                }
                ComputerGame();
                YouAreWin("Computer!");
                newGame = false;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Do(Button1);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Do(Button2);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Do(Button3);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Do(Button4);
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Do(Button5);
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Do(Button6);
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Do(Button7);
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Do(Button8);
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Do(Button9);
        }
    }
}
