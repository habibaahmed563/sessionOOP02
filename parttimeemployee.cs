using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessionOOP02
{
    internal class parttimeemployee : employee
    {

 
        public double hourrate { get; set; }
        public double numberofhours { get; set; }

        public new void fun01()
        {
            Console.WriteLine("iam full time employee");
        }

        public override void fun02()
        {
            Console.WriteLine($"salary : {hourrate*numberofhours}");
        }
    }
}
