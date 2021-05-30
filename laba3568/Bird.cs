using System;
using System.Collections.Generic;
using System.Text;

namespace laba3568
{
    class Bird : IComparable<Bird>
    {
        public Bird()
        {
        }
        public Bird(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
        public Bird(string name, double weight, int age, string color, gender gender)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Color = color;
            Gender = gender;
        }
        private double weight;
        private int age;
        public enum gender
        {
            Male,
            Female
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("enter correct weight value");
                }
                else
                {
                    weight = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("enter correct age");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Name { get; set; }
        public string Color { get; set; }
        public gender Gender { get; set; }

        public virtual void Move(short flag, int dist)
        {
            Console.WriteLine("Птица закончила путешествие");
        }
        public override string ToString()
        {
            return string.Format("Птица {0}, Weight={1}, Age={2}", Name, Weight, Age);
        }
        public void Winter()
        {
            Console.WriteLine("Winter where there is food");
        }
        public int CompareTo(Bird otherBird)
        {
            if (Weight > otherBird.Weight)
            {
                return -1;
            }
            else
            {
                if (Weight < otherBird.Weight)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public bool AbilityToFly { set; get; }
    }
}
