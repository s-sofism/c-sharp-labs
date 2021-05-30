using System;
using System.Collections.Generic;
using System.Text;

namespace laba3568
{
    class Duck : Bird, ILiving
    {
        public Duck()
        {
        }
        public Duck(string name, double weight, int age) : base (name, weight, age)
        {
        }

        // event
        public delegate void Moving(string message);
        public event Moving Notify;
        public override void Move(short flag, int dist)
        {
            switch (flag)
            {
                case 0:
                    Console.WriteLine("Утка должна пройти {0} км", dist);
                    Notify?.Invoke($"Это была отличная прогулка"); // events
                    break;
                case 1:
                    Console.WriteLine("Утка должна пролететь {0} км", dist);
                    Notify?.Invoke($"Я устал летать"); // events
                    break;
                case 2:
                    Console.WriteLine("Утка должна проплыть {0} км", dist);
                    Notify?.Invoke($"Все лапы мокрые"); // events
                    break;
                default: break;
            }
            base.Move(flag, dist);
        }
        public override string ToString()
        {
            return string.Format("Утка {0}, Weight={1}, Age={2}", Name, Weight, Age);
        }
        public new void Winter()
        {
            Console.WriteLine("Go to Europe");
        }
        public void Relax()
        {
            Console.WriteLine("Swim in the lake");
        }
        public void Dinner()
        {
            Console.WriteLine("To eat bread");
        }
    }
}
