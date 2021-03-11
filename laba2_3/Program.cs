using System;

namespace laba2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int a = 0;
            int b = 0;
            while (run)
            {
                Console.WriteLine("enter value a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter value b");
                b = Convert.ToInt32(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("try again \n");
                    run = true;
                }
                else
                {
                    run = false;
                }
            }
            int resultDegree;
            int maxDegree = 0;
            int number = 1;
            int result = 1;
            while (result != 0)
            {
                number = number * 2;
                result = b / number;
                maxDegree = maxDegree + result;
            }
            int minDegree = 0;
            number = 1;
            result = 1;
            a = a - 1;
            while (result != 0)
            {
                number = number * 2;
                result = a / number;
                minDegree = minDegree + result;
            }
            if (a + 1 <= 0)
            {
                resultDegree = 0;
            }
            else
            {
                resultDegree = maxDegree - minDegree;
            }
            Console.WriteLine("the maximum power of two is " + resultDegree);
        }
    }
}
