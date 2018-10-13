using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab3
{
    // Declaring the Car() Class
    // This class has 3 properties: Color, Year, and Mileage
    public class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // Creates integer variable called "instances" and assigns value to 0
        private static int instances = 0;

        // Adding a constructor
        // This constructor instantiates a Car() object while only having the car's color and year information available
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;

            // Every time the constructor runs, increment "instances"
            instances++;
        }

        // Adding another Constructor
        // This constructor instantiates a Car() object while only having the car's year and mileage information available
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;

            // Every time the constructor runs, increment "instances"
            instances++;

        }

        public Car()
        {
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        // Declare static member
        public static int CountCars()
        {
            return instances;
        }
    }
}
