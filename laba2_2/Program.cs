using System;

namespace laba2_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now);
            string data = Convert.ToString(DateTime.Now);
            int[] numbers = new int[10];
            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case '0':
                        {
                            numbers[0]++;
                            break;
                        }
                    case '1':
                        {
                            numbers[1]++;
                            break;
                        }
                    case '2':
                        {
                            numbers[2]++;
                            break;
                        }
                    case '3':
                        {
                            numbers[3]++;
                            break;
                        }
                    case '4':
                        {
                            numbers[4]++;
                            break;
                        }
                    case '5':
                        {
                            numbers[5]++;
                            break;
                        }
                    case '6':
                        {
                            numbers[6]++;
                            break;
                        }
                    case '7':
                        {
                            numbers[7]++;
                            break;
                        }
                    case '8':
                        {
                            numbers[8]++;
                            break;
                        }
                    case '9':
                        {
                            numbers[9]++;
                            break;
                        }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i + " : " + numbers[i]);
            }
            Console.WriteLine('\n');
            Console.WriteLine(DateTime.UtcNow);
            string dataUtc = Convert.ToString(DateTime.UtcNow);
            int[] number = new int[10];
            for (int i = 0; i < dataUtc.Length; i++)
            {
                switch (dataUtc[i])
                {
                    case '0':
                        {
                            number[0]++;
                            break;
                        }
                    case '1':
                        {
                            number[1]++;
                            break;
                        }
                    case '2':
                        {
                            number[2]++;
                            break;
                        }
                    case '3':
                        {
                            number[3]++;
                            break;
                        }
                    case '4':
                        {
                            number[4]++;
                            break;
                        }
                    case '5':
                        {
                            number[5]++;
                            break;
                        }
                    case '6':
                        {
                            number[6]++;
                            break;
                        }
                    case '7':
                        {
                            number[7]++;
                            break;
                        }
                    case '8':
                        {
                            number[8]++;
                            break;
                        }
                    case '9':
                        {
                            number[9]++;
                            break;
                        }
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(i + " : " + number[i]);
            }
        }
    }
}
