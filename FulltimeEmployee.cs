using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessionOOP02
{
    internal class FulltimeEmployee : employee
    {

        public double salary { get; set; }
        
        public new void fun01()
        {
            Console.WriteLine("iam full time employee");
        }

        public override void fun02()
        {
            Console.WriteLine($"salary : {salary}");
        }


    }
}
