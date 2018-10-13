using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_zone
{
    class Program
    {
        static void Main()
        {
            test test1 = new test();
            test1.AppleColor = "red";

            test test2 = new test();
            test2.AppleColor = "yellow";

            testing testing1 = new testing("fuji",test2.AppleColor);
            testing testing2 = new testing("colorado", test1.AppleColor);

            IList<string> strList = new List<string>();
            strList.Add(test2.AppleColor);

            Console.WriteLine($"{test1.AppleColor}");
            Console.WriteLine($"{test2.AppleColor}");

            foreach (var el in strList)
                Console.WriteLine($"it is {el}");

            foreach (var el in testing2.colorsList)
                Console.WriteLine($"the list includes {el}");
        }
    }
}
