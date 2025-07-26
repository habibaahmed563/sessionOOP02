using sessionOOP02.inheritance;
using sessionOOP02.overriding;

namespace sessionOOP02
{

    class Order
    {
        public item[] items { get; set;}
    }
    class item
    {

    }
    class Room
    {
        public Wall Wall { get; set; }
        public chair[]? Chairs { get; set; } 
    }
    class chair
    {

    }
    class Wall
    {

    }
    internal class Program
    {

        #region polymorphism methods (functions) overloading 
        static int sum(int X, int Y)
        {
            return X + Y;
        }
        static double sum(double X, double Y)
        {
            return X + Y;
        }

        static int sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }

        static double sum(int X, double Y)
        {
            return X + Y;
        }
        static double sum(double X, int Y)
        {
            return X + Y;
        }
        #endregion

        //static void Employeeprocess (FulltimeEmployee employee)
        //{
        //    employee.fun01();
        //    employee.fun02();
        //}

        static void Employeeprocess(employee employee)
        {
            employee.fun01();
            employee.fun02();
        }

        static void Main(string[] args)
        {

            #region inheritance

            //2. inheritance : 
            //X --> Y
            //DRY 

            //parent parent = new parent(1, 2);

            ////Console.WriteLine(parent);

            //parent.fun01();
            //parent.fun02();

            //child child = new child(1, 2, 3);

            //child.fun01();
            //child.fun02(); 
            #endregion


            #region relationship between classes 
            //relationship between classes 

            //1. inheritance : is a relationship [fulltimeemployee is a Employee - Dog is a animal ]
            //2. aggregation : has a relationship [order has item]
            //  2.1.compositation : order has a item  , room has a Wall 
            //  2.2.association   : 
            #endregion


            #region polymorphism methods 

            //3. polymorphsm 
            //3.1.polymorphism methods (functions ) overloading 
            //3.2.polymorphism methods (functions ) overriding 


            //Console.WriteLine();

            //3.1.polymorphism methods (functions ) overloading 
            //there are more than one function(in the same scope[class - struct ]) these have the same name but with different signature 
            //(count - type - order) parameters 


            //sum(1, 2);
            //sum(1.3, 2.4);

            //sum(1, 3.4);
            //sum() 
            #endregion


            #region 3.2.polymorphism methods (functions ) overriding 
            //3.2.polymorphism methods (functions ) overriding 
            //there are more than one functions [in different class] these have
            //the same name and the same signature but with behaviour

            TypeB typeB = new TypeB() { A = 12, B = 13 };

            //typeB.A = 12;
            //typeB.B = 12;

            Console.WriteLine(typeB.A);
            Console.WriteLine(typeB.B);


            typeB.fun01();
            typeB.fun02();
            #endregion


            #region what is binding 
            //binding 
            //what is binding ? 

            //referencefromparent ---> objectchild 

            TypeA Ref;

            //Ref = new TypeA();
            //Ref = new Typeb();

            //child is a parent 

            //TypeB ia a typea 

            Ref = new TypeB();

            Ref.A = 12;
            //Ref.B = 12;

            Ref.fun01(); // static binding method 
                         //Ref.fun02(); 
            #endregion


            #region not binding 

            //binding 
            //refparent ---> objchild 

            //TypeA Ref = new TypeA();

            //Ref = new TypeB(); // Binding 

            //TypeB Ref = new TypeB();


            //Ref = new TypeA(); 

            //child is a parent 

            //animal --> Dog is a animal 
            //Dog -> animal : animal is a dog 

            //TypeA Ref = new TypeA();

            //Ref = new TypeB();

            //TypeB typeB = (TypeB)Ref; //not binding  
            #endregion


            #region when u need binding ??

            //when u need binding ??

            //fulltimeEmployee : id , name , address , Email , salary 

            //FulltimeEmployee fulltime = new FulltimeEmployee()
            //{
            //    id = 1,
            //    name = "ahmed",
            //    Email = "ahmed@.c",
            //    address = "cairo",
            //    salary = 12000
            //};

            ////parttimeemployee : id , name , address , email , numberofhours , hourrate 

            //Employeeprocess(fulltime);

            //parttimeemployee parttime = new parttimeemployee()
            //{
            //    id = 1,
            //    name = "ali",
            //    Email = "ali@.com",
            //    address = "alex",
            //    hourrate = 300,
            //    numberofhours = 200,

            //};

            // int x; 
            #endregion


            #region types EX
            TypeA typeA;

            typeA = new TypeA();
            typeA = new TypeB(); // TypeA is a parent of typeB
            typeA = new TypeC(); // TypeA is a indirect parent of typeC
            typeA = new TypeD(); // TypeA is a indirect parent of typeD
            typeA = new TypeE(); // TypeA is a indirect parent of typeE

            typeA.A = 12;
            //typeA.B = 12;
            //typeA.C = 12;
            //typeA.D = 12;

            typeA.fun01();
            typeA.fun02(); 
            #endregion




        }
    }
}
