using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Person
    {
        public string SSN;
        public string Name;
        public string City;
        public int Age;
        public Person(string ssn, string name, string city, int age)
        {
            SSN = ssn;
            Name = name;
            City = city;
            Age = age;
        }

    }
}
