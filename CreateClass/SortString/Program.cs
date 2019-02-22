using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    public class Program
    {
        static string myStr = "Microsoft .NET Framework 2.0 Application Development Foundation";

        public string[] words = myStr.Split(' ');

        public string PlayWithStrings(string[] words)
        {
            Array.Sort(words);
            myStr = string.Join(" ", words);
            return myStr;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(myStr);
        }
    }
}
