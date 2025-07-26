using sessionOOP02.inheritance;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessionOOP02
{
    internal class child : parent
    {
        public int Z { get; set; }
        public child(int X , int Y , int Z) : base(X,Y)
        {
            this.Z = Z;
        }

        public void fun01()
        {
            Console.WriteLine(" Iam child [derived]");
        }


        public void fun02()
        {
            Console.WriteLine($"X: {X}, Y: {Y} , Z : {Z}");
        }


        public override string ToString()
        {
            return $"x: {X}:: y: {Y}:: z: {Z}";
        }

    }

}
