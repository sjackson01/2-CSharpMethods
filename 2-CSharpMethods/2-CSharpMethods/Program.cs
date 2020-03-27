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

        // Parameters Arguments Return Type  
        static double Add(double first, double second) 
        {
            return first + second;
        }

        // Ask method
        static string Ask(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        static double Price(double quantity) 
        {
            return quantity * 2;
        }

        static void Main(string[] args)
        {
            // String interpolation: Sub C# code 
            // into the middle of a string. 
            Console.WriteLine($"aaa {1 + 2}");

            // Use Datetime now property 
            // Property thats always set to now
            Console.WriteLine($"aaa {DateTime.Now} bbb");

            string name = "Steven"; 

            Console.WriteLine($"Hello {name}!"); // Interpolate var

            // Call static method (doens't need an object). 
            Wait(3000);

            CountToThree();

            // Get Type is not static and must be called on an object. 
            42.GetType();

            // Assign returned value to a variable 
            // Gives info the program different than
            // Console Write which just displays info 
            double otherTotal = Add(1, 2);

            Console.WriteLine(otherTotal);

            // Pass returned value directly to another method
            Console.WriteLine(Add(3,5));


            // Use ask method that returns a method
            // Use \n newline and \t tab 
            Console.WriteLine("Welcome to the cat food store!\nPlease let me know if you need anything.");
            string entry = Ask("\tHow many cans are you ordering?");

            // Convert string to double using parse method. 
            double quantity = double.Parse(entry);
            Console.WriteLine( $"You entered {quantity} cans");
            double total = Price(quantity);
            Console.WriteLine($"For {quantity} cans, your total is: ${total}");

        }
    }
}
