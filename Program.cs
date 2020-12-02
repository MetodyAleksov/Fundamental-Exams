using System;
using System.Text.RegularExpressions;

namespace Fundamental_Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();


            while (input != "Generate")
            {
                string[] commands = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Contains")
                {
                    string substring = commands[1];
                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (commands[0] == "Flip")
                {
                    int startindex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);

                    bool toUpper = false;
                    if (commands[1] == "Upper")
                    {
                        toUpper = true;
                    }

                    for (int i = startindex; i < endIndex; i++)
                    {
                        char curr = key[i];
                        string newchar = key[i].ToString();
                        if (toUpper)
                        {
                            newchar = key[i].ToString().ToUpper();
                        }
                        else
                        {
                            newchar = key[i].ToString().ToLower();
                        }
                        key = key.Replace(curr, newchar[0]);
                    }
                    Console.WriteLine(key);
                }
                else if (commands[0] == "Slice")
                {
                    int start = int.Parse(commands[1]);
                    int end = int.Parse(commands[2]);
                    int count = end - start;
                    key = key.Remove(start, count);
                    Console.WriteLine(key);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
