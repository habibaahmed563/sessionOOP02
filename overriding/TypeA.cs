using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessionOOP02.overriding
{
    internal class TypeA
    {
        public int A { get; set; }
        public void fun01()
        {
            Console.WriteLine("fun01 from typeA");
        }

        public void fun02()
        {
            Console.WriteLine($"A : {A}");
        }

    }
}
