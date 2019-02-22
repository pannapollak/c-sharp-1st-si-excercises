using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Person
    {
        private char v;

        public Person(char v, string name, DateTime birthDate)
        {
            this.v = v;
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        enum Gender
        {
            Male,
            Female
        };


        public override string ToString()
        {
            return base.ToString() + " Name: " + v.ToString();
        }
    }
}