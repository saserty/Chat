using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        private const string NamesFile = "Names.txt";
        private const string SurnameFile = "Surnames.txt";
        private const string OutputFile = "Outpet.txt";
        private const string Absolute = @"D:\FoldeName"; // use @ before path  ---  use doubled slash \\ instead of \ ----
        private const int FullNamesNumber = 50;
        static List<string> namesList;
        static List<string> surnamesList;


        static void Main(string[] args)
        {
            namesList = new List<string>();
            surnamesList = new List<string>();
        }

        private static void ReadNames()
        {
            ReadLines(NamesFile, namesList);
        }

        private static void ReadSurnames()
        {
            ReadLines(SurnameFile, surnamesList);
        }

        private static void ReadLines(string path, List<string> outlist)
        {
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    outlist.Add(line);
                }

            }
        }

        private static void Mix()
        {
            using (StreamWriter writer = new StreamWriter(OutputFile))
            {
                Random rand = new Random();

                for (int i = 0; i < FullNamesNumber; i++)
                {
                    string fullName;
                    int namesCount = namesList.Count;
                    int surNames = surnamesList.Count;
                    int currentName = rand.Next(namesCount);
                    int currentSurname = rand.Next(surNames);
                    fullName = string.Format("{0} {1}", namesList[currentName], surnamesList[currentSurname]);

                }
            }
        }
    }
}
