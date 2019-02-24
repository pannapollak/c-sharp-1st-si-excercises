using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable randomHashTable = new Hashtable
            {
                { "0", "zero" },
                { "1", "one" },
                { "2", "two" },
                { "3", "three" },
                { "4", "four" },
                { "5", "five" },
                { "6", "six" },
                { "7", "seven" },
                { "8", "eight" },
                { "9", "nine" },
            };

            string numSeries = "0375";
            foreach (var number in numSeries)
            {
                string currentNumber = number.ToString();
                if (randomHashTable.ContainsKey(currentNumber))
                {
                    Console.WriteLine(randomHashTable[currentNumber]);
                }
            }
        }
    }
}
