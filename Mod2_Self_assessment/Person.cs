using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Self_assessment
{
    // An abstract "Person" class
    abstract class Person
    {
        // private member attributes
        private int age;
        private string name;
        private char gender;

        // public variables

        public int Age
        {
            get { return this.age; } set{ this.age = value;}
        }

        public string Name
        {
            get { return this.name;} set { this.name = value;}
        }

        public char Gender
        {
            get { return this.gender;} set{ this.gender = value;}
        }

        // Constructor
        public Person(int age, string name, char gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

    }
}
