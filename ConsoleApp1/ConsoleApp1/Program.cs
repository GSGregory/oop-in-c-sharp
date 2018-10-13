using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 greg = new Class1("hello");
            Class2 sarah = new Class2();
            sarah.name = "goodbye";

            Console.WriteLine(greg.name);
            Console.WriteLine(sarah.name);

        }
    }
}
