using System;
namespace CSExercises
{
    public class Ex41
    {
        static Boolean InString(string first, string second)
        {
            Boolean result = false;
            int count = 0;

            for (int j = 0; j < second.Length; j++)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] == second[j])
                    {
                        count++;
                    }
                }
            }
            if (count == second.Length)
            {
                result = true;
            }
            else
            {
                result = false;
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
