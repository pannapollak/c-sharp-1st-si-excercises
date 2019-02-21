using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
   class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person('a', "hey", DateTime.Now);
            Console.WriteLine(person.ToString());
            Person employee = new Employee('m', "no", DateTime.Now, 54300, "sailor", 214);
        }
    }
}
