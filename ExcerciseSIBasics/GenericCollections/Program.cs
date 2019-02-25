using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> randomDict = new Dictionary<int, string>
            {
                { 33, "France" },
                { 44, "Great Britain" },
                { 36, "Hungary" },
                { 01, "USA" }
            };
            Console.WriteLine(randomDict[33]); //suppose to fix to print key with indexing synthax

            foreach (var item in randomDict)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
                //Console.Write(item.Key + ": ");
                //Console.WriteLine(item.Value);
            }
        }
    }
}
