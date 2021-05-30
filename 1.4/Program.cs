using System;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        { 
            space();    
        }  
         
        static void space()
        {
            Console.WriteLine("enter a string");
            string input = Console.ReadLine();
            int spaces = 0;
  
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ') 
                {
                    spaces++;
                }
            }
            Console.WriteLine("you have " +  spaces + " spaces in your string");
        }
    }
}
