using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary randomDict = new ListDictionary (StringComparer.InvariantCultureIgnoreCase)
            {
                { "United States", "Estados Unidos" },
                { "Canada", "Canadá" },
                { "Spain", "España" }
            };

            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("sp-SP");
            //String.Format(CultureInfo.InvariantCulture, );
        }
    }
}
