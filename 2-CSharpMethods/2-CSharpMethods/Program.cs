using System;
using System.Threading; 

namespace _2_CSharpMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Desmonstrate sleep method 
            Console.WriteLine("Welcome to the cat food store!");

            // System.Threading is a different namespace 
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Done Sleeping!");

        }
    }
}
