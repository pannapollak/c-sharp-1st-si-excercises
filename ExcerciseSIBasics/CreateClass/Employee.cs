using System;

namespace CreateClass
{
    public class Employee : Person
    {
        public Employee(char v, string name, DateTime birthDate, int salary, string profession, int roomNumber) : base(v, name, birthDate)
        {
        }

        public int Salary { get; private set; }
        public string Profession { get; private set; }



    }
}