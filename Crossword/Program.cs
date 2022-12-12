using System;

namespace Crossword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ProgrammedbyBerkHamzaOzcan");
            Console.WriteLine();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine("++ 1. Count vowels ++");
            Console.WriteLine("++ 2. Count spaces ++");
            Console.WriteLine("++ 3. Count words  ++");
            Console.WriteLine("++ 4. Replace      ++");
            Console.WriteLine("++ 5. Exit         ++");
            Console.WriteLine("+++++++++++++++++++++");
            Console.Write("Please enter your selection [ ]\b\b");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            string str;
            int counter = 0;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter your text:");
                    str = Console.ReadLine();
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str.Substring(i, 1).ToLower().Equals("a"))
                        { counter++; }
                        else if (str.Substring(i, 1).ToLower().Equals("e"))
                        { counter++; }
                        else if (str.Substring(i, 1).ToLower().Equals("i"))
                        { counter++; }
                        else if (str.Substring(i, 1).ToLower().Equals("o"))
                        { counter++; }
                        else if (str.Substring(i, 1).ToLower().Equals("u"))
                        { counter++; }
                    }
                    Console.WriteLine("Total number of vowels: " + counter);
                    break;
                case 2:
                    Console.WriteLine("Please enter text:");
                    str = Console.ReadLine();
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str.Substring(i, 1).Equals(" "))
                        { counter++; }
                    }
                    Console.WriteLine("Total number of spaces: " + counter);
                    break;
                case 3:
                    Console.WriteLine("Please enter your string");
                    str = Console.ReadLine();
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str.Substring(i, 1).Equals(" ") && !str.Substring(i + 1, 1).Equals(" "))
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine("There are {0} numvber of words", ++counter);
                    break;
                case 4:
                    Console.WriteLine("please enter text");
                    str = Console.ReadLine();
                    string ftext, rtext;
                    int p = -1;
                    Console.WriteLine("please enter what you want to replace from");
                    ftext = Console.ReadLine();
                    Console.WriteLine("please enter what you want to replace to");
                    rtext = Console.ReadLine();
                    do
                    {
                        p = str.IndexOf(ftext, p + 1);
                        if (p == -1) break;
                        str = str.Remove(p, ftext.Length);
                        str = str.Insert(p, rtext);
                    } while (p != -1);
                    //str = str.Replace(ftext, rtext);

                    Console.WriteLine(str);
                    break;
                case 5:
                    Console.WriteLine("GOOD BYE");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Sorry you entered wrong value");
                    break;
                    
            }
    }   }
}
