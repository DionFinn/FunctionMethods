using System;

namespace _1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            arraycall();      
        }
        static void arraycall()
        {
                Console.WriteLine("input 5 numbers");
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                string input3 = Console.ReadLine();
                string input4 = Console.ReadLine();
                string input5 = Console.ReadLine();

                int[] num = new int[5] {int.Parse(input1), int.Parse(input2), int.Parse(input3), int.Parse(input4), int.Parse(input5)};
                Console.WriteLine("equals " + num[0] + num[1] + num[2] + num[3] + num[4]);

        }
    }
}
