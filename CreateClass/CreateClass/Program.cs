﻿using System;
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
            Person person = new Person('a', "2009-06-15");
            Console.WriteLine(person.ToString());
            Person employee = new Employee();
        }
    }
}
