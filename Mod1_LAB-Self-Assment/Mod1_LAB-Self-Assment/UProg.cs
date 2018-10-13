using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Mod1_LAB_Self_Assment
{
    public class UProg
    {

     public string Name { get; set; }
     public string DegreeName { get; set; }

        public UProg(string uProgName, string degreename)
        {
            this.Name = uProgName;
            this.DegreeName = degreename;
        }
    }
}
