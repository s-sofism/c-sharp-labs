using System;

namespace laba3568
{
    class Program
    {
        // delegate 8-20
        public delegate void DangerDelegate();
        private static void FlyingBird()
        {
            Console.WriteLine("In case of danger - fly away");
        }
        private static void NotFlyingBird()
        {
            Console.WriteLine("In case of danger - swim away");
        }
        static void GetWinterPlace(Bird bird)
        {
            bird.Winter();
        }
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
            // мой интерфейс реализован ILiving, используется в Penguin.cs и Duck.cs 
            // IComparable реализован в Bird.cs строки 85-100

            bird1.AbilityToFly = true;
            bird2.AbilityToFly = false;
            bird3.AbilityToFly = true;

            // delegate продолжение
            DangerDelegate danger;  
            if (bird1.AbilityToFly == true)
            {
                danger = FlyingBird;
            }
            else
            {
                danger = NotFlyingBird;
            }
            danger();

            // events
            bird3.Notify += Message;
            bird3.Move(1, 20);
            bird3.Move(2, 20);
            bird3.Move(0, 20);
        }
        private static void Message(string message)
        {
            Console.WriteLine(message);
        }
        // мой event реализован в Duck.cs строки 17-38, используется в Program.cs строки 52-60
    }
}
