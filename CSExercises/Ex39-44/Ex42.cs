using System;
namespace CSExercises
{
    public class Ex42
    {
        static int InString(string first, string second)
        {
            int result = 0;
            
            for (int j = 0; j < second.Length; j++)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] == second[j])
                    {
                        result = i;
                    }
                }
                break;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First String!");
            string str1 = Console.ReadLine();

            Console.WriteLine("Please Enter Second String!");
            string str2 = Console.ReadLine();

            Console.WriteLine(InString(str1, str2));
        }
    }
}
