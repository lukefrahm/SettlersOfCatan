using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace DataIO
{
    public class FileAccess
    {
        // Set up necessary items to perform save of data
        private const string masterFile = "masterFile.csv";       // Will only be used to keep a master file of all rolls
        private const string sep = ",";                           // Set up separators
        private static char[] separators = { ',', '\t' };
        public int[] RollCount { get; set; }

        #region Read file
        // File reader used to read the master file into an array of ints to be used for incrementing the master file later in the class
        public static int[] CountSetter()
        {
            var rollList = new int[15];
            {
                try
                {
                    StreamReader fileReader = new StreamReader(masterFile);

                    while (fileReader.EndOfStream == false)
                    {
                        // Read file line
                        string line = fileReader.ReadLine();

                        string[] parts = line.Split(separators);

                        for (int i = 0; i < 15; i++)
                        {
                            int num;
                            bool result = int.TryParse(parts[i], out num);
                            if (result)
                            {
                                rollList[i] = num;
                            }
                            else
                            {
                                foreach (int j in rollList)
                                {
                                    rollList[j] = 0;
                                }
                            }
                        }
                    }
                    fileReader.Close();
                }

                catch (Exception)
                {

                    throw;
                }

                return rollList;
            }
        }
        #endregion

        #region Save file
        // This region is in charge of incrementing the "masterFile" which holds the total number of rolls since file creation (as long as it isn't deleted, all rolls since the program was first run)

        private static int[] CreateNewMasterFileCounts(int[] sentArray)
        {
            // Creates an array with all values in the master file BEFORE updating for the save. Passes this array of ints back
            int[] readFile = new int[15];
            try
            {
                readFile = CountSetter();

            }
            catch (Exception)
            {

                throw;
            }
            return readFile;
        }

        public static bool SaveOverData(int[] elements)
        {
            //Save over old master file with a new total of all rolls submitted
            try
            {
                int[] updatedMasterCounts = new int[15];
                int[] oldMasterCounts = new int[15];
                oldMasterCounts = CreateNewMasterFileCounts(elements);

                for (int j = 0; j < 15; j++)
                {
                    updatedMasterCounts[j] = elements[j] + oldMasterCounts[j];
                }

                StreamWriter fileWriter = new StreamWriter(masterFile, false);
                string line = updatedMasterCounts[0] + sep;                                // Set initial state of string so it can be concatinated in for loop
                for (int i = 1; i < 14; i++)
                {
                    line += updatedMasterCounts[i] + sep;                                  // use concatination to add comma-deliminated string of text
                }
                line += updatedMasterCounts[14];
                fileWriter.WriteLine(line);
                fileWriter.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
