using System;
using System. Collections.Generic;
namespace _1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            function();
        }
        static void function() {
            List<int> num = new List<int>();
            Console.Write("please enter the number");
            num.Add(0);
            num.Add(1);
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(5);
            num.Add(8);
            num.Add(13);
            num.Add(21);
            num.Add(34);
            num.Add(55);
            num.Add(89);
            num.Add(144);
            num.Add(233);
            num.Add(377);
            num.Add(610);
            num.Add(987);
            num.Add(1597);
            num.Add(2584);
            num.Add(4181);
            string input = Console.ReadLine();
            int numinput = int.Parse(input);
            //Console.WriteLine(numinput);
            foreach (var item in num)
            {
                
                if (item <= numinput)
                  {
                      Console.WriteLine(item);
                  }
            }

        }
    }  
}
