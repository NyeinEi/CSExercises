using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int b;
            //Console.WriteLine("Please enter your integer: ");
            for (int a = 1; a < 1000; a++ )
            {
                sum = 0;
                for (b = 1; b < a; b++)
                {
                    if (a % b == 0)
                    {
                        //Console.WriteLine(b + " is a factor of " + a);
                        sum += b;
                        //Console.WriteLine("The sum of all factors is: " + sum);

                    }
                }

                if (sum == a)
                {
                    Console.WriteLine("{0}",a);
                }
               
            }
                
            Console.ReadLine();

        }
    }
}
