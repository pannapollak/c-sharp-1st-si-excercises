using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    abstract class Person
    {
        string Name;
        DateTime BirthDate;

        enum Genders { Male, Female };

        public override string ToString()
        {
            return base.ToString() + ":" enum.ToString();
        }
    }
}
