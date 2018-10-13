using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_LAB_Self_Assment
{
     
    public class Students
    {
        // Students Properties
        public string Name { get; set; }
        public int Age { get; set; }
        
        // Student constructor
        public Students(string studentName, int studentAge)
        {
            this.Name = studentName;
            this.Age = studentAge;
            Courses.studentList.Add(studentName);
            studentCount++;
        }
        
        // Int for student count
        private static int studentCount = 0;

        public static int CountStudents()
        {
            return studentCount;
        }
          
    }


}
