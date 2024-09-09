using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentalsExample.Common.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string personName, int personAge) {
            Name = personName;
            Age = personAge;
        }
        public void SelfPresentation() {
            Console.WriteLine($"Hi, my name is {Name}, and I'm {Age} years old");
        }
    }
}