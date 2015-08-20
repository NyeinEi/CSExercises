using System;
using System.Globalization;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            string[] strarr = str.Split(' ');

            for(int i=0;i<strarr.Length;i++)
            {

                string titlecase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(strarr[i]);
                Console.Write(titlecase+" ");
       
            }
       
        }
    }
}
