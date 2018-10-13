using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Mod1_LAB_Self_Assment
{
    public class Degrees
    {
        public string Name { get; set; }
        public string CourseName { get; set; }

        public Degrees(string degreeName, string courseName )
        {
            this.Name = degreeName;
            this.CourseName = courseName;
        }
    }
}
