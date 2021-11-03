using ClassLibrary1;
using System;

namespace ConsoleApp3
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1nd number") ;
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Class1.Meth1(a, b));
            Console.WriteLine(Class1.Meth2(a, b));
           


        }
    }
}
