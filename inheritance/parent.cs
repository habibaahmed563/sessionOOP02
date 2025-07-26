using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessionOOP02.inheritance
{
    internal class parent
    {
        public int X { get; set; }
        public int Y { get; set; }


        public void fun01()
        {
            Console.WriteLine(" Iam parent [Base]");
        }


        public void fun02()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
        public parent (int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return $"x: {X} , y: {Y}";
        }


    }
}
