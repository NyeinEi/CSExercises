using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0 || num == 1)
            {
                Console.WriteLine(num + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= num / 2; a++)
                {
                    if (num % a == 0)
                    {
                        Console.WriteLine(num + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(num + " is a prime number");
                Console.ReadLine();
            }
        }
    }
}
