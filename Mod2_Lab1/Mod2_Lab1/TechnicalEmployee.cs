using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class TechnicalEmployee : Employee
    {
        //Calls upon base-class (Employee Class) constructor from within derived class ( technical Employee Class)
        // Sets baseSalary to 75000 for all technical Employee objects
        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }

        // Creates integer variable caled "successfulCheckIns" and assigns value to 5
        public int successfulCheckIns = 5;

        // This method reutrns the toString() method - which is the employee's ID number and name - and prints the number of successful check ins the emplyee has had
        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful checkins";
        }
    }
}
