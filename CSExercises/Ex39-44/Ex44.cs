using System;
namespace CSExercises
{
    public class Ex44
    {
        static char[] SubStitude(string s, char c1, char c2)
        {
            char[] result = new char[s.Length];

            //Declaring arr array to put the values from string
            char[] arr = new char[s.Length];
            for (int j = 0; j < s.Length; j++)
            {
                arr[j] = s[j];
                //Console.WriteLine(arr[j]);
            }

            //assign c2 value to string
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (arr[i] == c1)
                {
                    arr[i] = c2;
                }
            }

            for (int m = 0; m < s.Length; m++)
            {

                result[m] = arr[m];
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter String: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Please Enter a Character: ");
            char char1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please Enter a Character to substitude: ");
            char char2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(SubStitude(str1, char1, char2));
        }
    }
}
