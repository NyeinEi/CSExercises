using System;

namespace CSExercises
{
    public class Ex35
    {
        static void Main(string[] args)
        {
            int count = 0;
            int numofa = 0, numofe = 0, numofi = 0, numofo = 0, numofu = 0;

            Console.WriteLine("Please Enter a Phrase: ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                string sub = str.Substring(i, 1);
                Console.WriteLine("Substring: {0}", sub);



                switch (sub)
                {
                    case "a":
                        Console.WriteLine("This is Vowel");
                        count++;
                        numofa++;
                        break;
                    case "e":
                        Console.WriteLine("This is Vowel");
                        count++;
                        numofe++;
                        break;
                    case "i":
                        Console.WriteLine("This is Vowel");
                        count++;
                        numofi++;
                        break;
                    case "o":
                        Console.WriteLine("This is Vowel");
                        count++;
                        numofo++;
                        break;
                    case "u":
                        Console.WriteLine("This is Vowel");
                        count++;
                        numofu++;
                        break;
                    default:
                        Console.WriteLine("This is not Vowel");
                        break;
                }

            }
            Console.WriteLine("Number of total vowels: " + count);
            Console.WriteLine("Number of total a: " + numofa);
            Console.WriteLine("Number of total e: " + numofe);
            Console.WriteLine("Number of total i: " + numofi);
            Console.WriteLine("Number of total o: " + numofo);
            Console.WriteLine("Number of total u: " + numofu);
        }
    }
}
