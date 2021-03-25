using System;

namespace laba_3
{
    class Birds
    {
        Bird[] data;
        public Birds()
        {
            data = new Bird[10];
        }
        public Bird this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }

    class Bird
    {
        public Bird()
        {

        }
        private double weight;
        private int age;
        public enum gender
        {
            Male,
            Female
        }
        public bool AbilityToFly;
        public bool AbilityToSwim;
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
        public string Species { get; set; }
        public gender Gender { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Birds birds = new Birds();
            birds[0] = new Bird();
            birds[0].Name = "Natasha";
            birds[0].Species = "dove";
            birds[0].Weight = 0.3;
            birds[0].Age = 2;
            birds[0].Color = "grey";
            birds[0].AbilityToFly = true;
            birds[0].AbilityToSwim = false;
            birds[0].Gender = Bird.gender.Female;
            Console.WriteLine(birds[0].Name);
            Console.WriteLine(birds[0].Species);
            Console.WriteLine(birds[0].Weight);
            Console.WriteLine(birds[0].Age);
            Console.WriteLine(birds[0].Color);
            Console.WriteLine(birds[0].Gender);
        }
    }
}
