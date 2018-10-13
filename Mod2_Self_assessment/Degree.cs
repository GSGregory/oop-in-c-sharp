using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Self_assessment
{
    class Degree
    {
        // private variables
        private string name;
        private IList<Course> courseList = new List<Course>();

        // public variables
        public string Name { get { return this.name; } set { this.name = value; } }
        public IList<Course> CourseList { get { return this.courseList; } set { this.courseList = value; } }

        // Constructor
        public Degree(string name)
        {
            this.Name = name;
        }

        // Add Course method
        public void AddCourse(Course course)
        {
            this.CourseList.Add(course);
        }
    }
}
