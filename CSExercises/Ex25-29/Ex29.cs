using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int a, b;
            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b < a; b++)
            {
                if (a % b == 0)
                {
                    //Console.WriteLine(b + " is a factor of " + a);
                    sum += b;
                   // Console.WriteLine("The sum of all factors is: "+ sum);
                      
                  
                }
                
            }
            if (sum == a)
            {
                Console.WriteLine("This is Perfect Number");
            }
            else
            {
                Console.WriteLine("This is not Perfect Number");
            }
            Console.ReadLine();
            
        }
    }
}
