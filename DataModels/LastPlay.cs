using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class LastPlay
    {
        public string CurrentPlay { get; set; }                                         // Object to hold last move for undo move
        public static List<DiceModels.Dice> playList = new List<DiceModels.Dice>();     // Code to track all moves in order of occurrence. This will be used for undoing multiple moves.
        public static DiceModels.Dice lastItem { get; set; }                            // Stores most recent move: used to help transfer the last move value to bottom method to return an int value to SettlersRollsGUI
        public static int last { get; set; }                                            // Used to hold int value of the last move: aids in adjusting counters by casting to int

        public LastPlay() { }

        // Overloaded constructor for adding to the List<>
        public LastPlay(bool addDel, DiceModels.Dice play)
        {
            playList.Add(play);
        }

        // Overloaded constructor for deleting from List<>
        public LastPlay(bool delete)
        {
            // Prevent exception: System.InvalidOperationException due to empty List
            if (playList.Count != 0)
            {
                lastItem = playList.Last<DiceModels.Dice>();
                last = RemoveThis(lastItem);
            }
            else
            {
                last = 0;
            }

            if (delete == true)
            {
                // Prevent exception: System.ArgumentOutOfRangeException due to empty List
                if (playList.Count != 0)
                {
                    playList.RemoveAt(playList.Count - 1);
                    // Prevent exception: System.InvalidOperationException due to empty List
                    try
                    {
                        lastItem = playList.Last<DiceModels.Dice>();
                    }
                    catch (System.InvalidOperationException) { }
                }
            }
        }

        public int RemoveThis(DiceModels.Dice last) // Function to set up value to remove from counters
        {
            // Returns an int value of the last stored value in List<> BEFORE it is removed. Used to decrement counters for the element removed from List<>
            return (int)last;
        }
    }
}
