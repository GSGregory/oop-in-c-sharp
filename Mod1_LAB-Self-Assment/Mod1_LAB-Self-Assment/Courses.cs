using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Mod1_LAB_Self_Assment
{
    public class Courses
    {
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
        public static ArrayList studentList = new ArrayList();


        public Courses(string courseName, string courseTeacher)
        {
            this.CourseName = courseName;
            this.CourseTeacher = courseName;
        }


    }
} 
