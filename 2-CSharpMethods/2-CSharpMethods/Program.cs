using System;
using System.Threading; 

namespace _2_CSharpMethods
{
    class Program
    {
        // Static keyword doesn't belong to an object. 
        // Void no return type. 
        static void Wait(int delay) 
        {
            // Call method within another method possible 
            // CountToThree();

            // Write line is a static method we dont need and object.
            Console.WriteLine("Waiting...");
            Thread.Sleep(delay);
            Console.WriteLine("Done");
        }

        static void CountToThree() 
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);

        }

        // Parameters and Arguments 
        static void Add(double first, double second) 
        {
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(first + second);
        }
            
        static void Main(string[] args)
        {
            // Call static method (doens't need an object). 
            Wait(3000);

            CountToThree();

            // Get Type is not static and must be called on an object. 
            42.GetType();

            Add(1, 2);

        }
    }
}
