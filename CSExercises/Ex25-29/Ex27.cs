using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            for (int x = -5; x < 5; x++)
            {
                int y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("the value of y is " + y);

                for (int j = 1; j <= y; j++)
                {
                    Console.Write("*");
                }
            }

        }
    }
}
