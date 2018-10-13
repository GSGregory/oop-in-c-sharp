using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Self_assessment
{
    class Teacher : Person
    {
        // Private attributes
        private string degree;

        // Public variables
        public string Degree { get { return this.degree; } set { this.degree = value; } }

        // Constructor
        public Teacher(int age, string name, char gender, string degree) : base(age, name, gender)
        {
            this.Degree = degree;
        }
    }
}
