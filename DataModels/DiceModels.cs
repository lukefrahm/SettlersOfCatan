using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class DiceModels
    {
        // Creates Dice object to be used throughout program: used extensively to keep a List<> of moves
        public enum Dice
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Eleven,
            Twelve,
            Yellow = 100,
            Blue = 200,
            Green = 300,
            Black = 400
        }

        public Dice dice { get; set; }

        public DiceModels(Dice dice)
        {
            this.dice = dice;
        }
    }
}
