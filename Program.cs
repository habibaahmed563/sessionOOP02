using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sessionOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 1.  protected:

            //Accessible within the class and in derived(child) classes,
            //even if they are in different assemblies(projects).

            // Ex :

            Dog dog = new Dog();
            dog.dogs();


            //2.  private protected :

            // Accessible only within the same class and by derived classes in the same assembly
            // (same project)Not accessible from outside the project, even if inherited.


            //EX : 

            derivedclass obj = new derivedclass();
            obj.showmessage();



            //3.  protected internal
            // Accessible within the same assembly(same project)
            //OR in any derived(child) class, even if it's in a different assembly.


            //EX : 

            student student = new student();
            student.greet();

        }
    }
}
