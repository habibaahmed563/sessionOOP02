using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessionOOP02.overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        //override or hide 
        //apply override
        //1.apply override using 'new'keyword
        //2.apply override using 'override'keyword


        public void fun01() //using new keyword
        {
            Console.WriteLine("fun01 from typeB");
        }

        //must be not private and virtual
        //public override fun02() //using override keyword
        //{
        //    Console.WriteLine($"A : {A} , B: {B}");
        //}


    }
}
