using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Self_assessment
{
    class UniProg
    {
        // private variables
        private string name;
        private IList<Degree> degreesList = new List<Degree>();

        // public variables
        public string Name;
        public IList<Degree> DegreesList { get { return this.degreesList; } set { this.degreesList = value; } }

        // constructor
        public UniProg(string name)
        {
            this.Name = name;
        }

        // Add degree method
        public void AddDegree(Degree degree)
        {
            this.DegreesList.Add(degree);
        }
    }
}
