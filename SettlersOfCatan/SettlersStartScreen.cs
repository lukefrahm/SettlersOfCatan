using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SettlersOfCatan;
using DataModels;

namespace SettlersOfCatan
{
    public partial class SettlersStartScreen : Form
    {
        public static int numPlayers;
        SettlersRollsGUI screen = new SettlersRollsGUI();
        public Player player = new Player();
        
        public SettlersStartScreen()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Must set properties and prepare values for beginning game
            numPlayers = (int)numSelectPlayers.Value;
            player.PlayerCount = numPlayers;
            Player.CurrentPlayerNumber = 1;
            screen.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits the application
            this.Close();
        }
    }
}
