using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        private string Name;
        public string name { get => Name; set => Name = value; }

        public Class1(string Name)
        {
            this.name = Name;
        }

        public Class1()
        {

        }
    }
}
