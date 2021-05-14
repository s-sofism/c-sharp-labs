using System;
using System.Collections.Generic;
using System.Text;

namespace laba3568
{
    class Duck : Bird
    {
        public Duck()
        {
        }
        public Duck(string name, double weight, int age) : base (name, weight, age)
        {
        }
        public override void Move(short flag, int dist)
        {
            switch (flag)
            {
                case 0:
                    Console.WriteLine("Утка должна пройти {0} км", dist);
                    break;
                case 1:
                    Console.WriteLine("Утка должна пролететь {0} км", dist);
                    break;
                case 2:
                    Console.WriteLine("Утка должна проплыть {0} км", dist);
                    break;
                default: break;
            }
            base.Move(flag, dist);
        }
        public override string ToString()
        {
            return string.Format("Утка {0}, Weight={1}, Age={2}", Name, Weight, Age);
        }
    }
}
