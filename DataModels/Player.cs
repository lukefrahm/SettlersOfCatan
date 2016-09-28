using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Player
    {
        private static int count;

        // Property to keep track of the current player number
        public static int CurrentPlayerNumber { get; set; }

        // Property to set the player count: set based on the numericUpDown selection at startup
        public int PlayerCount
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public Player() { } // Default constructor
    }
}
