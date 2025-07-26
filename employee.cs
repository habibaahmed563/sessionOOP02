using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessionOOP02
{
    //container for common property 
    internal class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        public string address { get; set; }

        public void fun01()
        {
            Console.WriteLine("iam employee");
        }

        public virtual void fun02()
        {
            Console.WriteLine($"salary :???");
        }
    }
}
