using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModels;
using System.Diagnostics;
using DataIO;

//
// This class uses the preprocessor directive #region extensively to help group code into collapsable sections based on the content within
//

namespace SettlersOfCatan
{
    public partial class SettlersRollsGUI : Form
    {
        #region Variables/Instances
        LastPlay _lastPlay = new LastPlay();
        Player player = new Player();
        SaveFileDialog _newSave = new SaveFileDialog();
        int[] rollCounter = new int[15];
        #endregion

        public SettlersRollsGUI()
        {
            InitializeComponent();

            // Sets opening text in status scroll box
            txtUpdates.AppendText("To play: Select first numerical roll result to record, followed by the color dice roll. After selecting the colored dice that was rolled, the next player's turn will begin. Click \"Help\" for further assistance.\n");
            txtUpdates.AppendText("\n");
            txtUpdates.AppendText("\nPlayer 1's turn:\n");
        }

        #region Extracted methods
            #region Extracted method for clearing text status box
            private void ResetForm()
            {
                #region Clear text counters
                lblRollCount2.Text = "0";
                lblRollCount3.Text = "0";
                lblRollCount4.Text = "0";
                lblRollCount5.Text = "0";
                lblRollCount6.Text = "0";
                lblRollCount7.Text = "0";
                lblRollCount8.Text = "0";
                lblRollCount9.Text = "0";
                lblRollCount10.Text = "0";
                lblRollCount11.Text = "0";
                lblRollCount12.Text = "0";
                lblAuxCountBlack.Text = "0";
                lblAuxCountBlue.Text = "0";
                lblAuxCountGreen.Text = "0";
                lblAuxCountYellow.Text = "0";
                #endregion
                #region Clear bar counters
                barRollCount2.Value = 0;
                barRollCount3.Value = 0;
                barRollCount4.Value = 0;
                barRollCount5.Value = 0;
                barRollCount6.Value = 0;
                barRollCount7.Value = 0;
                barRollCount8.Value = 0;
                barRollCount9.Value = 0;
                barRollCount10.Value = 0;
                barRollCount11.Value = 0;
                barRollCount12.Value = 0;
                barAuxCountBlack.Value = 0;
                barAuxCountBlue.Value = 0;
                barAuxCountGreen.Value = 0;
                barAuxCountYellow.Value = 0;
                #endregion
                #region Clear status text box and status bar
                txtUpdates.Clear();
                staLastMoveUpdate.Text = "";
                #endregion
            }
            #endregion

            #region Extracted method for stating next player after valid moves
            private void resetPlayerCount(bool increment)
            {
                if (increment == true)
                {
                    // Increments CurrentPlayerNumber and writes the next player name on status zones
                    Player.CurrentPlayerNumber++;

                    // Checks to see if CurrentPlayerNumber is out of range and sets it to max to be printed as current player
                    if (Player.CurrentPlayerNumber > player.PlayerCount)
                    {
                        Player.CurrentPlayerNumber = player.PlayerCount;
                    }

                    // Update status zones with current player
                    txtUpdates.AppendText("\n");
                    txtUpdates.AppendText("\nPlayer " + Player.CurrentPlayerNumber + "'s turn:\n");
                    staPlayerUp.Text = "Player " + Player.CurrentPlayerNumber + "'s turn";

                    // Checks to see if CurrentPlayerNumber is out of range based on PlayerCount set when starting application
                    if (Player.CurrentPlayerNumber >= player.PlayerCount)
                    {
                        Player.CurrentPlayerNumber = 0;
                    }
                }
                else
                {
                    // If false, sets up to revert to last player and print the last player number
                    Player.CurrentPlayerNumber--;
                    if (Player.CurrentPlayerNumber < 0)
                    {
                        Player.CurrentPlayerNumber = player.PlayerCount - 1;
                    } if (Player.CurrentPlayerNumber == 0)
                    {
                        Player.CurrentPlayerNumber = player.PlayerCount;
                    }
                    txtUpdates.AppendText("\n");
                    txtUpdates.AppendText("\nPlayer " + Player.CurrentPlayerNumber + "'s turn:\n");
                    staPlayerUp.Text = "Player " + Player.CurrentPlayerNumber + "'s turn";
                }
            }
            #endregion

            #region Extracted methods changing Enabled property of roll buttons
            private void NoStandardInput()
            {
                // This method removes the standard dice roll choices from the user until the player rolls the color dice
                btnDiceRoll2.Enabled = false;
                btnDiceRoll3.Enabled = false;
                btnDiceRoll4.Enabled = false;
                btnDiceRoll5.Enabled = false;
                btnDiceRoll6.Enabled = false;
                btnDiceRoll7.Enabled = false;
                btnDiceRoll8.Enabled = false;
                btnDiceRoll9.Enabled = false;
                btnDiceRoll10.Enabled = false;
                btnDiceRoll11.Enabled = false;
                btnDiceRoll12.Enabled = false;

                // Making sure the color die can be clicked
                btnAuxDieYellow.Enabled = true;
                btnAuxDieBlue.Enabled = true;
                btnAuxDieGreen.Enabled = true;
                btnAuxDieBlack.Enabled = true;
            }

            private void NoAuxInput()
            {
                // This method activates the standard dice roll choices and deactivates the ability to select the color dice until a regular roll is added
                btnDiceRoll2.Enabled = true;
                btnDiceRoll3.Enabled = true;
                btnDiceRoll4.Enabled = true;
                btnDiceRoll5.Enabled = true;
                btnDiceRoll6.Enabled = true;
                btnDiceRoll7.Enabled = true;
                btnDiceRoll8.Enabled = true;
                btnDiceRoll9.Enabled = true;
                btnDiceRoll10.Enabled = true;
                btnDiceRoll11.Enabled = true;
                btnDiceRoll12.Enabled = true;

                // Making sure the color dice is not Enabled
                btnAuxDieYellow.Enabled = false;
                btnAuxDieBlue.Enabled = false;
                btnAuxDieGreen.Enabled = false;
                btnAuxDieBlack.Enabled = false;
            }
            #endregion
        #endregion

        #region Button Increments for Dice
        // This region is for incrementing the counter and graph, recording it as the most recent play to allow an undo, and updating a status for the status box

        private void btnDiceRoll2_Click(object sender, EventArgs e)
        {
            barRollCount2.Increment(1);                                             // Increment bar count
            lblRollCount2.Text = (int.Parse(lblRollCount2.Text) + 1).ToString();    // Increment label count
            _lastPlay.CurrentPlay = "2";                                            // Sets LastPlay.CurrentPlay to record a roll of 2: will add it to List<>
            txtUpdates.AppendText("You have recorded a roll of 2!\n");              // Update text box
            staLastMoveUpdate.Text = "Roll of 2 recorded";                          // Update status bar
            NoStandardInput();                                                      // Set all number roll buttons to be disables to force a choice of color
            _lastPlay = new LastPlay(true, DiceModels.Dice.Two);                    // Sends "Two" enum to be added to List<>
        }

        private void btnDiceRoll3_Click(object sender, EventArgs e)
        {
            barRollCount3.Increment(1);
            lblRollCount3.Text = (int.Parse(lblRollCount3.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "3";
            txtUpdates.AppendText("You have recorded a roll of 3!\n");
            staLastMoveUpdate.Text = "Roll of 3 recorded";
            NoStandardInput();
            _lastPlay = new LastPlay(true, DiceModels.Dice.Three);
        }

        private void btnDiceRoll4_Click(object sender, EventArgs e)
        {
            barRollCount4.Increment(1);
            lblRollCount4.Text = (int.Parse(lblRollCount4.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "4";
            txtUpdates.AppendText("You have recorded a roll of 4!\n");
            staLastMoveUpdate.Text = "Roll of 4 recorded";
            NoStandardInput();
            _lastPlay = new LastPlay(true, DiceModels.Dice.Four);
        }

        private void btnDiceRoll5_Click(object sender, EventArgs e)
        {
            barRollCount5.Increment(1);
            lblRollCount5.Text = (int.Parse(lblRollCount5.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "5";
            txtUpdates.AppendText("You have recorded a roll of 5!\n");
            staLastMoveUpdate.Text = "Roll of 5 recorded";
            NoStandardInput();
            _lastPlay = new LastPlay(true, DiceModels.Dice.Five);
        }

        private void btnDiceRoll6_Click(object sender, EventArgs e)
        {
            barRollCount6.Increment(1);
            lblRollCount6.Text = (int.Parse(lblRollCount6.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "6";
            txtUpdates.AppendText("You have recorded a roll of 6!\n");
            staLastMoveUpdate.Text = "Roll of 6 recorded";
            NoStandardInput();
            _lastPlay = new LastPlay(true, DiceModels.Dice.Six);
        }

        private void btnDiceRoll7_Click(object sender, EventArgs e)
        {
            barRollCount7.Increment(1);
            lblRollCount7.Text = (int.Parse(lblRollCount7.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "7";
            txtUpdates.AppendText("You have recorded a roll of 7!\n");
            staLastMoveUpdate.Text = "Roll of 7 recorded";
            NoStandardInput();
            _lastPlay = new LastPlay(true, DiceModels.Dice.Seven);
        }

        private void btnDiceRoll8_Click(object sender, EventArgs e)
        {
            barRollCount8.Increment(1);
            lblRollCount8.Text = (int.Parse(lblRollCount8.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "8";
            txtUpdates.AppendText("You have recorded a roll of 8!\n");
            staLastMoveUpdate.Text = "Roll of 8 recorded";
            NoStandardInput();
            _lastPlay = new LastPlay(true, DiceModels.Dice.Eight);
        }

        private void btnDiceRoll9_Click(object sender, EventArgs e)
        {
            barRollCount9.Increment(1);
            lblRollCount9.Text = (int.Parse(lblRollCount9.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "9";
            txtUpdates.AppendText("You have recorded a roll of 9!\n");
            staLastMoveUpdate.Text = "Roll of 9 recorded";
            NoStandardInput();
            _lastPlay = new LastPlay(true, DiceModels.Dice.Nine);
        }

        private void btnDiceRoll10_Click(object sender, EventArgs e)
        {
            barRollCount10.Increment(1);
            lblRollCount10.Text = (int.Parse(lblRollCount10.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "10";
            txtUpdates.AppendText("You have recorded a roll of 10!\n");
            staLastMoveUpdate.Text = "Roll of 10 recorded";
            NoStandardInput();
            _lastPlay = new LastPlay(true, DiceModels.Dice.Ten);
        }

        private void btnDiceRoll11_Click(object sender, EventArgs e)
        {
            barRollCount11.Increment(1);
            lblRollCount11.Text = (int.Parse(lblRollCount11.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "11";
            txtUpdates.AppendText("You have recorded a roll of 11!\n");

            staLastMoveUpdate.Text = "Roll of 11 recorded";
            NoStandardInput();
            _lastPlay = new LastPlay(true, DiceModels.Dice.Eleven);
        }

        private void btnDiceRoll12_Click(object sender, EventArgs e)
        {
            barRollCount12.Increment(1);
            lblRollCount12.Text = (int.Parse(lblRollCount12.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "12";
            txtUpdates.AppendText("You have recorded a roll of 12!\n");
            staLastMoveUpdate.Text = "Roll of 12 recorded";
            NoStandardInput();
            _lastPlay = new LastPlay(true, DiceModels.Dice.Twelve);
        }

        private void btnAuxDieYellow_Click(object sender, EventArgs e)
        {
            barAuxCountYellow.Increment(1);
            lblAuxCountYellow.Text = (int.Parse(lblAuxCountYellow.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "Yellow";
            txtUpdates.AppendText("You have recorded a roll of Yellow!\n");
            staLastMoveUpdate.Text = "Roll of YELLOW recorded";
            NoAuxInput();
            resetPlayerCount(true);
            _lastPlay = new LastPlay(true, DiceModels.Dice.Yellow);
        }

        private void btnAuxDieBlue_Click(object sender, EventArgs e)
        {
            barAuxCountBlue.Increment(1);
            lblAuxCountBlue.Text = (int.Parse(lblAuxCountBlue.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "Blue";
            txtUpdates.AppendText("You have recorded a roll of Blue!\n");
            staLastMoveUpdate.Text = "Roll of BLUE recorded";
            NoAuxInput();
            resetPlayerCount(true);
            _lastPlay = new LastPlay(true, DiceModels.Dice.Blue);
        }

        private void btnAuxDieGreen_Click(object sender, EventArgs e)
        {
            barAuxCountGreen.Increment(1);
            lblAuxCountGreen.Text = (int.Parse(lblAuxCountGreen.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "Green";
            txtUpdates.AppendText("You have recorded a roll of Green!\n");
            staLastMoveUpdate.Text = "Roll of GREEN recorded";
            NoAuxInput();
            resetPlayerCount(true);
            _lastPlay = new LastPlay(true, DiceModels.Dice.Green);
        }

        // Black side of the dice is the "Barbarian" side and--per game rules--triggers an event every seven rolls
        private void btnAuxDieBlack_Click(object sender, EventArgs e)
        {
            barAuxCountBlack.Increment(1);
            lblAuxCountBlack.Text = (int.Parse(lblAuxCountBlack.Text) + 1).ToString();
            _lastPlay.CurrentPlay = "Black";
            txtUpdates.AppendText("You have recorded a roll of Barbarian!\n");
            NoAuxInput();

            // Sets up status update based on rolls to barbarian hitting: client wishes a countdown to 0 with a message saying "barbarian hits" when rolls have depleted
            if (lblAuxCountBlack.Text != "7") // Counter does not hit 0: resets to 7. Client request for this style
            {
                // "Normal" status when counter is not reset
                txtUpdates.AppendText("\tYou have " + (int.Parse(lblBarbarianCounter.Text) - 1).ToString() + " more Barbarian rolls" + "\n\t\t" + "before Barbarian hits\n");  // Updates users to when 7 rolls have been reached
                staLastMoveUpdate.Text = "Roll of BLACK recorded: " + (int.Parse(lblBarbarianCounter.Text) - 1).ToString() + " rolls left before Barbarian hits!";
            }
            else
            {
                // This code records barbarian hitting when countdown resets
                txtUpdates.AppendText("\tBarbarian hits now!\n");
                staLastMoveUpdate.Text = "Roll of BLACK recorded: " + " BARBARIAN HITS!";
            }

            // Hides barbarian counter until first barbarian roll: client request
            if (lblAuxCountBlack.Text != "0")
            {
                lblBarbarianCounter.Visible = true;
            }

            lblBarbarianCounter.Text = (int.Parse(lblBarbarianCounter.Text) - 1).ToString();

            if (int.Parse(lblBarbarianCounter.Text) == 0) // Reset counter for next series of countdown
            {
                lblBarbarianCounter.Text = "7";
            }

            resetPlayerCount(true);
            _lastPlay = new LastPlay(true, DiceModels.Dice.Black);
        }
        #endregion

        #region GUI Control Boxes
        // This region sets up functions for how each of the non-incrementer (for roll recording) buttons will work

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Closes the GUI window
            var result = MessageBox.Show("Are you sure you want to quit? Unsaved changes will be lost.", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ResetForm(); // If the SettlersRollsGUI is entered from SettlersStartScreen again, this ensures the form will be reset to defaults
                txtUpdates.AppendText("Player 1's turn:\n");
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Resets all values of the counters to zero
            var result = MessageBox.Show("Are you sure you want to reset all data? All unsaved data will be lost. This cannot be reversed!", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ResetForm();
                NoAuxInput();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Removes the last element of the List<> and decrements counters for the undone move
            int toRemove;
            var result = MessageBox.Show("Are you sure you want to undo last move?", "Confirm Undo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                _lastPlay = new LastPlay(true);
                toRemove = LastPlay.last;

                // Prevent System.InvalidOperationException
                try
                {
                    if (toRemove == 2)
                    {
                        barRollCount2.Value -= 1;                                               // Decrement bar counter
                        lblRollCount2.Text = (int.Parse(lblRollCount2.Text) - 1).ToString();    // Decrement label counter
                        txtUpdates.AppendText("Undo: Removed a roll of 2 from counters\n");     // State the move that was undone
                        NoAuxInput();                                                           // Switch active buttons 
                    }
                    else if (toRemove == 3)
                    {
                        barRollCount3.Value -= 1;
                        lblRollCount3.Text = (int.Parse(lblRollCount3.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of 3 from counters\n");
                        NoAuxInput();
                    }
                    else if (toRemove == 4)
                    {
                        barRollCount4.Value -= 1;
                        lblRollCount4.Text = (int.Parse(lblRollCount4.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of 4 from counters\n");
                        NoAuxInput();
                    }
                    else if (toRemove == 5)
                    {
                        barRollCount5.Value -= 1;
                        lblRollCount5.Text = (int.Parse(lblRollCount5.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of 5 from counters\n");
                        NoAuxInput();
                    }
                    else if (toRemove == 6)
                    {
                        barRollCount6.Value -= 1;
                        lblRollCount6.Text = (int.Parse(lblRollCount6.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of 6 from counters\n");
                        NoAuxInput();
                    }
                    else if (toRemove == 7)
                    {
                        barRollCount7.Value -= 1;
                        lblRollCount7.Text = (int.Parse(lblRollCount7.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of 7 from counters\n");
                        NoAuxInput();
                    }
                    else if (toRemove == 8)
                    {
                        barRollCount8.Value -= 1;
                        lblRollCount8.Text = (int.Parse(lblRollCount8.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of 8 from counters\n");
                        NoAuxInput();
                    }
                    else if (toRemove == 9)
                    {
                        barRollCount9.Value -= 1;
                        lblRollCount9.Text = (int.Parse(lblRollCount9.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of 9 from counters\n");
                        NoAuxInput();
                    }
                    else if (toRemove == 10)
                    {
                        barRollCount10.Value -= 1;
                        lblRollCount10.Text = (int.Parse(lblRollCount10.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of 10 from counters\n");
                        NoAuxInput();
                    }
                    else if (toRemove == 11)
                    {
                        barRollCount11.Value -= 1;
                        lblRollCount11.Text = (int.Parse(lblRollCount11.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of 11 from counters\n");
                        NoAuxInput();
                    }
                    else if (toRemove == 12)
                    {
                        barRollCount12.Value -= 1;
                        lblRollCount12.Text = (int.Parse(lblRollCount12.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of 12 from counters\n");
                        NoAuxInput();
                    }
                    else if (toRemove == 400)
                    {
                        barAuxCountBlack.Value -= 1;
                        lblAuxCountBlack.Text = (int.Parse(lblAuxCountBlack.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of Black from counters\n");
                        NoStandardInput();
                        resetPlayerCount(false);
                    }
                    else if (toRemove == 100)
                    {
                        barAuxCountYellow.Value -= 1;
                        lblAuxCountYellow.Text = (int.Parse(lblAuxCountYellow.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of Yellow from \n\t\t\tcounters\n");
                        NoStandardInput();
                        resetPlayerCount(false);
                    }
                    else if (toRemove == 200)
                    {
                        barAuxCountBlue.Value -= 1;
                        lblAuxCountBlue.Text = (int.Parse(lblAuxCountBlue.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of Blue from counters\n");
                        NoStandardInput();
                        resetPlayerCount(false);
                    }
                    else if (toRemove == 300)
                    {
                        barAuxCountGreen.Value -= 1;
                        lblAuxCountGreen.Text = (int.Parse(lblAuxCountGreen.Text) - 1).ToString();
                        txtUpdates.AppendText("Undo: Removed a roll of Green from \n\t\t\tcounters\n");
                        NoStandardInput();
                        resetPlayerCount(false);
                    }
                }
                catch { }
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            // Collects all counters and prepares to save data
            FileAccess fileAccess = new FileAccess();
            fileAccess.RollCount = new int[15];
            fileAccess.RollCount[0] = barRollCount2.Value;
            fileAccess.RollCount[1] = barRollCount3.Value;
            fileAccess.RollCount[2] = barRollCount4.Value;
            fileAccess.RollCount[3] = barRollCount5.Value;
            fileAccess.RollCount[4] = barRollCount6.Value;
            fileAccess.RollCount[5] = barRollCount7.Value;
            fileAccess.RollCount[6] = barRollCount8.Value;
            fileAccess.RollCount[7] = barRollCount9.Value;
            fileAccess.RollCount[8] = barRollCount10.Value;
            fileAccess.RollCount[9] = barRollCount11.Value;
            fileAccess.RollCount[10] = barRollCount12.Value;
            fileAccess.RollCount[11] = barAuxCountYellow.Value;
            fileAccess.RollCount[12] = barAuxCountBlue.Value;
            fileAccess.RollCount[13] = barAuxCountGreen.Value;
            fileAccess.RollCount[14] = barAuxCountBlack.Value;

            bool result;
            result = FileAccess.SaveOverData(fileAccess.RollCount);
            if (result)
            {
                MessageBox.Show("Master file updated successfully!","Save Successful!", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Save FAILED!","Save FAILED",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnHelpGuidelines_Click(object sender, EventArgs e)
        {
            // Opens help box for users
            Help help = new Help();
            help.ShowDialog();
        }
        #endregion
    }
}
