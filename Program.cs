using System;

namespace EvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers from 0 - 100 are: ");

            var number = 0;
            while (number < 100) {
                number = number + 2;
                Console.WriteLine(number);                
            }
        }
    }
}
