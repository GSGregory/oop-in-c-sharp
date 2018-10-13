using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_LAB_Self_Assment
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // first student object
            var Student1 = new Students("Greg Dragon",22);

            // second student object
            var Student2 = new Students("Sarah Fire",23);
            
            // third student object
            var Student3 = new Students("Kvothe None",30);

            // Teacher Object
            var Teacher1 = new Teachers("Beth");

            // Course Object
            var Course1 = new Courses("Programming with C#",Teacher1.Name);

            // Degree Object
            var Degree1 = new Degrees("PFHD", Course1.CourseName);

            // University Program Object
            var UProg1 = new UProg("Information Technology", Degree1.Name);

            // student count
            int totalStudents = Students.CountStudents();


            // Output to console
            Console.WriteLine($"We have {UProg1.Name} and it's {UProg1.DegreeName} degree and it's course {Degree1.CourseName} with {totalStudents} students.");
        }
    }
}
