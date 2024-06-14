using System;

namespace OOPDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run Inheritance and Method Overriding demo
            Console.WriteLine("Inheritance and Method Overriding Demo:");
            InheritanceDemo.Run();
            Console.WriteLine();

            // Run Abstract Classes and Methods demo
            Console.WriteLine("Abstract Classes and Methods Demo:");
            AbstractClassDemo.Run();
            Console.WriteLine();

            // Run Interfaces demo
            Console.WriteLine("Interfaces Demo:");
            InterfaceDemo.Run();
        }
    }
}
