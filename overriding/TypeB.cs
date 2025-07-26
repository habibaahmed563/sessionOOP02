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

        //static binding 
        //complier will bind function call based on reference type not the object type 
        //at compilation 

        public void fun01() //using new keyword
        {
            Console.WriteLine("fun01 from typeB");
        }

        //must be not private and virtual
        //public override fun02() //using override keyword
        //{
        //    Console.WriteLine($"A : {A} , B: {B}");
        //}

        //dynamic binding 
        //CLR will bind the function call based on object type not the reference type 
        //reltime 

    }
}
