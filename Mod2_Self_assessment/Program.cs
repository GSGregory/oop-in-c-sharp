using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Self_assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student(23, "greg", 'M');
            var student2 = new Student(26, "sarah", 'F');
            var student3 = new Student(200, "roxy", 'F');

            var teacher1 = new Teacher(33, "Roboto", 'R', "PHFD");

            var course1 = new Course("humanities");

            var degree1 = new Degree("PHFD");

            var uniProg1 = new UniProg("Human Studies");

            // adding students to course

            course1.AddStudent(student1);
            course1.AddStudent(student2);
            course1.AddStudent(student3);

            // adding teacher to course
            course1.AddTeacher(teacher1);

            // adding course to degree
            degree1.AddCourse(course1);

            // adding degree to uniprog
            uniProg1.AddDegree(degree1);



            // Output to console
            Console.WriteLine($"Here in the {uniProg1.Name} program we have the degree {uniProg1.DegreesList.ElementAt(0).Name} with its course {degree1.CourseList.ElementAt(0).Name} and it's teacher {degree1.CourseList.ElementAt(0).TeacherList.ElementAt(0).Name} with {uniProg1.DegreesList.ElementAt(0).CourseList.ElementAt(0).StudentsList.Count} students ");

        }
    }
}
