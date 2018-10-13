using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    // Abstract class
    abstract class Employee
    {
        // 3 private member variables: employeeName, emplyeeBaseSalary, and employeeId
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        // public properties
        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }
        
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }

            set
            {
                employeeBaseSalary = value;
            }
        }

        public int ID
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        // creates integer variable called "employeeCount" and assigns value to 1
        private static int employeeCount = 1;

        // constructor
        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        // this method returns the emplyee's base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        // this method returns the employee's name
        public string getName()
        {
            return this.Name;
        }
        // this method returns the emplooyee's ID
        public int getEmployeeID()
        {
            return this.ID;
        }

        // this method returns the emplyee's id and name as a string
        public string toString()
        {
            return this.ID + " " + this.Name;
        }

        // abstract method 
        public abstract string employeeStatus();
    }
}
