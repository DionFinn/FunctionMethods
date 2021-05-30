using System;

namespace _1._7
{
    class Program
    {
        static void Main(string[] args)
        
        
        {
          sqaured();
        }
        static void sqaured(){
            Console.WriteLine("please enter a base number!");
            string baseint = Console.ReadLine();
            Console.WriteLine("please add an additional number");
            string secondint = Console.ReadLine();
            int first = int.Parse(baseint);
            int second = int.Parse(secondint);
            int value = (first^second);
            Console.WriteLine($"your values of your two numbers sqaured are {value}");

        }
    }
}
