using System;
using System.Collections.Generic;
using System.Text;

namespace laba3568
{
    class Swallow : Bird
    {
        public Swallow()
        {
        }
        public Swallow(string name, double weight, int age) : base(name, weight, age)
        {
        }
        public override void Move(short flag, int dist)
        {
            switch (flag)
            {
                case 0:
                    Console.WriteLine("Ласточка должна пройти {0} км", dist);
                    break;
                case 1:
                    Console.WriteLine("Ласточка должна пролететь {0} км", dist);
                    break;
                default: break;
            }
            base.Move(flag, dist);
        }
        public override string ToString()
        {
            return string.Format("Ласточка {0}, Weight={1}, Age={2}", Name, Weight, Age);
        }
        public new void Winter()
        {
            Console.WriteLine("Go to Sahara");
        }
    }
}
