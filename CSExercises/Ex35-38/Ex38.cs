using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string str = null;
            string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };

            for (int i = 0; i < name.Length; i++)
            {
                str = name[i].ToLower();
            }

            for (int g = 0; g < str.Length; g++)
            {
                for (int r = g + 1; r < str.Length; r++)
                {
                    if (g.CompareTo(r) == -1)
                    {
                        string temp = name[r];
                        name[r] = name[g];
                        name[g] = temp;
                    }
                }
            }
            for (int j = 0; j < name.Length;j++ )
            {
                Console.WriteLine(name[j]);
            }
        }
    }
}
