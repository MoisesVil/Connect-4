using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempName
{
    public partial class Connect4 : Form
    {
        private Gameboard gameboard;

        private List<Button> column0 = new List<Button>();
        private List<Button> column1 = new List<Button>();
        private List<Button> column2 = new List<Button>();
        private List<Button> column3 = new List<Button>();
        private List<Button> column4 = new List<Button>();
        private List<Button> column5 = new List<Button>();
        private List<Button> column6 = new List<Button>();

        private string player1Name = "";

        private string player2Name = "";

        /// <summary>
        /// Constructor for Connect4 class
        /// </summary>
        public Connect4()
        {
            InitializeComponent();

            gameboard = new Gameboard();
            SubTextLabel.Text = "";
            AddButtonsToLists();
            ResetGameButtons();
            BackgroundPanel.BackColor = Color.Black;
            CenterTextLabel();
        }

        /// <summary>
        /// Handles click on any game button
        /// </summary>
        /// <param name="sender">Object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void GameButtonOnClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            char column = clickedButton.Name[7];

            bool peicePlaced = gameboard.PlacePeice(column - 48);

            if (peicePlaced)
            {
                SubTextLabel.Text = "";
                ShowPeicePlayed((column - 48).ToString());
            }
            else
            {
                SubTextLabel.Text = "Cannot place peice in that column!";
            }

            ShowWinner();

        }

        /// <summary>
        /// Shows a lighter version of the players color where the
        /// player is thinking of placing a peice
        /// </summary>
        /// <param name="sender">Object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void GameButtonOnHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string buttonName = "Button";
            string column = btn.Name[7].ToString();
            if (gameboard.highestPeice[int.Parse(column)] == 5) return;
            buttonName += (gameboard.highestPeice[int.Parse(column)] + 1).ToString() + column;
            Button button = FindButton(buttonName);
            if (button.BackColor == Color.White) button.BackColor = gameboard.player1Turn ? Color.IndianRed : Color.LightGoldenrodYellow;
        }

        /// <summary>
        /// Changes color back to white if player does not place
        /// a peice and peice is not already there
        /// </summary>
        /// <param name="sender">Object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void GameButtonLeaveHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string buttonName = "Button";
            string column = btn.Name[7].ToString();
            if (gameboard.highestPeice[int.Parse(column)] == 5) return;
            buttonName += (gameboard.highestPeice[int.Parse(column)] + 1).ToString() + column;
            Button button = FindButton(buttonName);

            if (button.BackColor == Color.IndianRed || button.BackColor == Color.LightGoldenrodYellow) button.BackColor = Color.White;
        }

        /// <summary>
        /// Handles click on Quit button
        /// </summary>
        /// <param name="sender">Object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void QuitButtonOnClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles a click on the Resart button
        /// </summary>
        /// <param name="sender">Object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void RestartButtonOnClick(object sender, EventArgs e)
        {
            gameboard.resetBoard();
            ResetGameButtons();
            if (!player1Name.Equals("")) GameTextLabel.Text = player1Name + "'s Turn";
            else GameTextLabel.Text = "Player 1's Turn";
            SubTextLabel.Text = "";
        }

        /// <summary>
        /// If there is a winner or tie, this method shows that on GUI
        /// </summary>
        private void ShowWinner()
        {
            if (gameboard.Winner != -1)
            {
                if (gameboard.Winner == 1)
                {
                    if (!player1Name.Equals("")) GameTextLabel.Text = player1Name + " Won!";
                    else GameTextLabel.Text = "Player 1 Won!";
                }
                else if (gameboard.Winner == 2)
                {
                    if (!player2Name.Equals("")) GameTextLabel.Text = player2Name + " Won!";
                    else GameTextLabel.Text = "Player 2 Won!";
                }
                else
                {
                    GameTextLabel.Text = "Tie!";
                }
                DisableGameButtons();
                CenterTextLabel();
            }
        }

        /// <summary>
        /// Shows where the peice was played on the board
        /// </summary>
        /// <param name="column">Column the peice was played in</param>
        private void ShowPeicePlayed(string column)
        {
            string buttonName = "Button";

            buttonName += gameboard.highestPeice[int.Parse(column)].ToString() + column;

            Button btn = FindButton(buttonName);

            if (!gameboard.player1Turn)
            {
                btn.BackColor = Color.Red;
                if (!player2Name.Equals("")) GameTextLabel.Text = player2Name + "'s Turn";
                else GameTextLabel.Text = "Player 2's Turn";
            }
            else
            {
                btn.BackColor = Color.Yellow;
                if (!player1Name.Equals("")) GameTextLabel.Text = player1Name + "'s Turn";
                else GameTextLabel.Text = "Player 1's Turn";
            }
            CenterTextLabel();
        }

        /// <summary>
        /// Helper method to get button where peice was played
        /// </summary>
        /// <param name="btnName">The name of the button</param>
        /// <returns>Button where the peice should be played</returns>
        private Button FindButton(string btnName)
        {
            Control[] foundControls = Controls.Find(btnName, true);

            if (foundControls.Length > 0 && foundControls[0] is Button)
            {
                return (Button)foundControls[0];
            }
            return null;
        }

        /// <summary>
        /// Disables all of the game buuttons so they can not be pressed
        /// </summary>
        private void DisableGameButtons()
        {
            foreach (Button b in column0)
            {
                b.Enabled = false;
            }
            foreach (Button b in column1)
            {
                b.Enabled = false;
            }
            foreach (Button b in column2)
            {
                b.Enabled = false;
            }
            foreach (Button b in column3)
            {
                b.Enabled = false;
            }
            foreach (Button b in column4)
            {
                b.Enabled = false;
            }
            foreach (Button b in column5)
            {
                b.Enabled = false;
            }
            foreach (Button b in column6)
            {
                b.Enabled = false;
            }
        }

        /// <summary>
        /// Resets all game buttons to be able to be clicked and be white
        /// </summary>
        private void ResetGameButtons()
        {
            foreach (Button b in column0)
            {
                b.Enabled = true;
                b.BackColor = Color.White;
            }
            foreach (Button b in column1)
            {
                b.Enabled = true;
                b.BackColor = Color.White;
            }
            foreach (Button b in column2)
            {
                b.Enabled = true;
                b.BackColor = Color.White;
            }
            foreach (Button b in column3)
            {
                b.Enabled = true;
                b.BackColor = Color.White;
            }
            foreach (Button b in column4)
            {
                b.Enabled = true;
                b.BackColor = Color.White;
            }
            foreach (Button b in column5)
            {
                b.Enabled = true;
                b.BackColor = Color.White;
            }
            foreach (Button b in column6)
            {
                b.Enabled = true;
                b.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Helper method to add all buttons to column lists
        /// </summary>
        private void AddButtonsToLists()
        {
            column0.Add(button00);
            column0.Add(button10);
            column0.Add(button20);
            column0.Add(button30);
            column0.Add(button40);
            column0.Add(button50);

            column1.Add(button01);
            column1.Add(button11);
            column1.Add(button21);
            column1.Add(button31);
            column1.Add(button41);
            column1.Add(button51);

            column2.Add(button02);
            column2.Add(button12);
            column2.Add(button22);
            column2.Add(button32);
            column2.Add(button42);
            column2.Add(button52);

            column3.Add(button03);
            column3.Add(button13);
            column3.Add(button23);
            column3.Add(button33);
            column3.Add(button43);
            column3.Add(button53);

            column4.Add(button04);
            column4.Add(button14);
            column4.Add(button24);
            column4.Add(button34);
            column4.Add(button44);
            column4.Add(button54);

            column5.Add(button05);
            column5.Add(button15);
            column5.Add(button25);
            column5.Add(button35);
            column5.Add(button45);
            column5.Add(button55);

            column6.Add(button06);
            column6.Add(button16);
            column6.Add(button26);
            column6.Add(button36);
            column6.Add(button46);
            column6.Add(button56);
        }

        /// <summary>
        /// Method to pop up a form to get both players name's
        /// </summary>
        private void GetPlayerNames()
        {
            using (EnterPlayerName player1 = new EnterPlayerName(player1Name, true))
            {
                if (player1.ShowDialog() == DialogResult.OK)
                {
                    player1Name = player1.playerName;
                }
            }
            using (EnterPlayerName player2 = new EnterPlayerName(player2Name, false))
            {
                if (player2.ShowDialog() == DialogResult.OK)
                {
                    player2Name = player2.playerName;
                }
            }
        }

        /// <summary>
        /// Method to center the text label showing whose turn it is
        /// </summary>
        private void CenterTextLabel()
        {
            GameTextLabel.Location = new Point(
                (this.ClientSize.Width - GameTextLabel.Width) / 2,
                GameTextLabel.Location.Y);
        }

        /// <summary>
        /// Handles a click on the change names button
        /// </summary>
        /// <param name="sender">Object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void ChangeNamesButtonOnClick(object sender, EventArgs e)
        {
            GetPlayerNames();

            if (!gameboard.player1Turn)
            {
                if (!player2Name.Equals("")) GameTextLabel.Text = player2Name + "'s Turn";
                else GameTextLabel.Text = "Player 2's Turn";
            }
            else
            {
                if (!player1Name.Equals("")) GameTextLabel.Text = player1Name + "'s Turn";
                else GameTextLabel.Text = "Player 1's Turn";
            }
            CenterTextLabel();
        }
    }
}
