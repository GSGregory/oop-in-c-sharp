using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Self_assessment
{
    class Course
    {
        // Private variables
        private IList<Student> studentsList = new List<Student>();
        private IList<Teacher> teacherList = new List<Teacher>();
        private string name;

        // Public variables
        public IList<Student> StudentsList { get { return this.studentsList; } set { this.studentsList = value; } }
        public IList<Teacher> TeacherList { get { return this.teacherList; } set { this.teacherList = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }

        // Constructor

        public Course(string name)
        {
            this.Name = name;
        }

        // Add students method
        public void AddStudent(Student student)
        {
            this.StudentsList.Add(student);
        }

        // Add teacher method
        public void AddTeacher(Teacher teacher)
        {
            this.TeacherList.Add(teacher);
        }
    }
}
