using System;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str=Console.ReadLine();

            string[] timstr = str.Split('.');
            for (int i = 0; i < timstr.Length; i++)
            {
                Console.Write(timstr[i]);
            }

            string rev=null;
            for (int i = str.Length - 1; i >= 0;i-- )
            {
                rev += str[i].ToString();
            }
            if (rev == str)
            {
                Console.WriteLine(" This String is Plaindrome");
            }
            else 
            {
                Console.WriteLine(" This String is not Plaindrome");
            }
        }
    }
}
