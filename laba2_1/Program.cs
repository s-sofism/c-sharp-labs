using System;

namespace laba2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string \n");
            string OrignalString = Console.ReadLine();
            string vowels = "aeiouy";
            for (int i = 0; i < OrignalString.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (OrignalString[i] == vowels[j])
                    {
                        int temp = i;
                        int temp1;
                        for (int z = i; z < OrignalString.Length; z++)
                        {
                            if (OrignalString[z] == vowels[0] || OrignalString[z] == vowels[1] || OrignalString[z] == vowels[2] || OrignalString[z] == vowels[3]
                                || OrignalString[z] == vowels[4] || OrignalString[z] == vowels[5])
                            {
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        temp1 = i;
                        while (i > temp)
                        {
                            if (temp == OrignalString.Length - 1)
                            {
                                i = temp1 - 1;
                                break;
                            }
                            else
                            {
                                if (i >= OrignalString.Length)
                                {
                                    i--;
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
                                    i--;
                                }
                                else
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
                                    i--;
                                }
                            }
                        }
                        i = temp1;
                        break;
                    }
                }
            }
            Console.WriteLine(OrignalString);
        }
    }
}
