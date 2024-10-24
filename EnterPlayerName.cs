using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempName
{
    public partial class EnterPlayerName : Form
    {
        public string playerName;

        private bool isPlayer1;

        /// <summary>
        /// Constructor for the EnterPlayerName class
        /// </summary>
        /// <param name="name">Current name of the player</param>
        /// <param name="player1">If it is player 1</param>
        public EnterPlayerName(string name, bool player1)
        {
            InitializeComponent();

            playerName = name;
            isPlayer1 = player1;

            if (isPlayer1)
            {
                GetNameLabel.Text = "Enter Name for Player 1:";
            }
            else
            {
                GetNameLabel.Text = "Enter Name for Player 2:";
            }
            GetNameTextBox.Text = playerName;
        }

        /// <summary>
        /// Handles a click on the ok button
        /// </summary>
        /// <param name="sender">Object signaling the event</param>
        /// <param name="e">Information about the event</param>
        public void OkButtonOnClick(object sender, EventArgs e)
        {
            playerName = GetNameTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Handles a click on the cancel button
        /// </summary>
        /// <param name="sender">Object Signaling the event</param>
        /// <param name="e">Information about the event</param>
        public void CancelButtonOnClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
