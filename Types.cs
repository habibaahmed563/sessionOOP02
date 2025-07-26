using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessionOOP02
{

    class TypeA
    {
        public int A { get; set;}

        public void fun01()
        {
            Console.WriteLine("fun01 from typeA");
        }

        public virtual void fun02()
        {
            Console.WriteLine($"A : {A}");
        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }

        public new void fun01()
        {
            Console.WriteLine("fun01 from typeB");
        }

        public override void fun02()
        {
            Console.WriteLine($"A : {A} , B: {B}");
        }
    }

    class TypeC: TypeB
    {
        public int C { get; set; }

        public new void fun01()
        {
            Console.WriteLine("fun01 from typeC");
        }

        public override void fun02()
        {
            Console.WriteLine($"A : {A} , B: {B} , c : {C}");
        }
    }

    class TypeD : TypeC
    {
        public int D { get; set; }

        public new void fun01()
        {
            Console.WriteLine("fun01 from typeD");
        }

        public override void fun02()
        {
            Console.WriteLine($"A : {A} , B: {B} , c : {C} , D: {D}");
        }
    }

    class TypeE : TypeD
    {
        public int E { get; set; }

        public new void fun01()
        {
            Console.WriteLine("fun01 from typeE");
        }

        public override void fun02()
        {
            Console.WriteLine($"A : {A} , B: {B} , c : {C} , D: {D} , E : {E}");
        }
    }

}
