using System;

namespace laba2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while ( run )
            {
            Console.WriteLine("enter value a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value b");
            int b = Convert.ToInt32(Console.ReadLine());
            if ( a > b )
            {
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
            a = a-1;
            while (result != 0)
            {
                number = number * 2;
                result = a / number;
                minDegree = minDegree + result;
            }
            if (a % 2 == 0)
            {
                resultDegree = maxDegree - minDegree + 1;
            }
            else
            {
                resultDegree = maxDegree - minDegree;
            }
            Console.WriteLine("the maximum power of two is " + resultDegree);
        }
    }
}
