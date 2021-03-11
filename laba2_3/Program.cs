using System;

namespace laba2_3
{
    class Program
    {
        static void Main()
        {
            bool run = true;
            string a;
            string b;
            uint firstNumber = 0;
            uint lastNumber = 0;
            while (run)
            {
                Console.WriteLine("enter value a");
                a = Console.ReadLine();
                Console.WriteLine("enter value b");
                b = Console.ReadLine();
                if (UInt32.TryParse(a, out firstNumber) && UInt32.TryParse(b, out lastNumber))
                {
                    if (firstNumber >= lastNumber)
                    {
                        Console.WriteLine("try again \n");
                        run = true;
                    }
                    else
                    {
                        run = false;
                    }
                }
                else
                {
                    Console.WriteLine("try again \n");
                    run = true;
                }
            }
            if (lastNumber != 0 && firstNumber != 0)
            {
                uint resultDegree;
                uint maxDegree = 0;
                uint number = 1;
                uint result = 1;
                while (result != 0)
                {
                    number = number * 2;
                    result = lastNumber / number;
                    maxDegree = maxDegree + result;
                }
                uint minDegree = 0;
                number = 1;
                result = 1;
                firstNumber = firstNumber - 1;
                while (result != 0)
                {
                    number = number * 2;
                    result = firstNumber / number;
                    minDegree = minDegree + result;
                }
                resultDegree = maxDegree - minDegree;
                Console.WriteLine("the maximum power of two is " + resultDegree);
            }
            else
            {
                Console.WriteLine("the maximum power of two is 0");
            }
        }
    }
}
