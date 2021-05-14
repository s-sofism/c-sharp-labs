using System;

namespace laba3568
{

    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Swallow("Marca", 0.02, 1);
            Penguin bird2 = new Penguin("Elliot", 3, 3);
            Duck bird3 = new Duck("Scrooge", 1, 5);
            bird1.Move(1, 30);
            bird2.Move(0, 10);
            bird3.Move(2, 20);
            Console.WriteLine(bird1.ToString());
            Console.WriteLine(bird2.ToString());
            Console.WriteLine(bird3.ToString());
        }
    }
}