using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class BusinessEmployee : Employee
    {
        // Calls upon base-class (employee Class) constructor from within derived class (BusinessEMployee Class)
        // Sets baseSalary to 50000 for all BusinessEmployee objects
        public BusinessEmployee(string name) : base(name, 50000)
        {

        }

        // Creates double variable called "bonusBudget" and assigns value to 1000
        public double bonusBudget = 1000;

        // This method returns the toString() method - which is the emplyee's ID number and name - and prints the bonus budget
        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
