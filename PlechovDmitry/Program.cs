using System;

namespace PlechovDmitry
{
    class Program
    {
        static void Condition(int i)
        {
            if (i % 15 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
        static void Main(string[] args)  
        {
            int figure = 1;
            while (figure<=100)
            {
                Condition(figure);
                figure++;
            }
        }
    }
}
