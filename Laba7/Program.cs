using System;
using System.Runtime;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a, b;
            a = Fraction.Parse("-1,75");
            b = Fraction.Parse("4/6");
            bool finish = false;
            Fraction c = new Fraction();
            do
            {
                Console.Clear();
                Console.WriteLine("a = " + a + " = " + a.ToString("correct") + " = " + a.ToString("incorrect")
                    + " = " + a.ToString("float"));
                Console.WriteLine("b = " + b + " = (float)" + b.ToString("float") + " = (decimal)" +
                    b.ToString("decimal") + " = (double)" + b.ToString("double") + " = (double)" +
                    (double)b + " = (long)" + b.ToString("long"));
                if (a > b)
                {
                    Console.WriteLine("a > b");
                }
                if (a < b)
                {
                    Console.WriteLine("a < b");
                }
                if (a == b)
                {
                    Console.WriteLine("a == b");
                }
                if (a != b)
                {
                    Console.WriteLine("a != b");
                }
                if (a <= b)
                {
                    Console.WriteLine("a <= b");
                }
                if (a >= b)
                {
                    Console.WriteLine("a >= b");
                }
                int choose;
                Console.WriteLine("\nselect an action.\n1.c = a + b\n2.c = a - b\n" +
                    "3.c = a * b\n4.c = a/b");
                while (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 4)
                {
                    Console.WriteLine("input error, enter choose value less than 4");
                }
                switch (choose)
                {
                    case 1: c = a + b; Console.WriteLine("c = " + a + " + " + b + " = " + c); break;
                    case 2: c = a - b; Console.WriteLine("c = " + a + " - " + b + " = " + c); break;
                    case 3: c = a * b; Console.WriteLine("c = " + a + " * " + b + " = " + c); break;
                    case 4: c = a / b; Console.WriteLine("c = " + a + " / " + b + " = " + c); break;
                }
                Console.ReadKey();
            } while (!finish);
        }   
    }
}
