using System;
using System.Text.RegularExpressions;
namespace string_laba
{
    class Program
    {
        static void Main()
        {
            string Vowels = "aeiouy";
            string Pattern = "^[a-z]{0,}$";
            string OrignalString;
            while (true)
            {
                Console.WriteLine("Enter the string \n");
                OrignalString = Console.ReadLine();
                if (Regex.IsMatch(OrignalString, Pattern))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("incorrect input \n");
                }
            }
            for (int i = OrignalString.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < Vowels.Length; j++)
                {
                    if (OrignalString[i - 1] == Vowels[j])
                    {
                        char letter = OrignalString[i];
                        if (letter == 'z')
                        {
                            letter = 'a';
                            OrignalString = OrignalString.Remove(i, 1).Insert(i, letter.ToString());
                        }
                        else
                        {
                            int ascii = letter;
                            letter = Convert.ToChar(ascii + 1);
                            OrignalString = OrignalString.Remove(i, 1).Insert(i, letter.ToString());
                        }
                    }
                }
            }
            Console.WriteLine(OrignalString);
        }
    }
}
