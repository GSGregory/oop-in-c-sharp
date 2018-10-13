using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Self_assessment
{
    class Student : Person
    {
        // Private attributes
        private string grade = "No Grade Entered";

        // Public variables
        public string Grade
        {
            get { return this.grade; } set { this.grade = value; }
        }

        // Constructor
        public Student(int age, string name, char gender) : base(age, name, gender)
        {

        }

        // Grading method placeholder
        public void setGrade(string value)
        {
            this.Grade = value;
        }
    }
}
