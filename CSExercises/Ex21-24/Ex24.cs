using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            
            int N;
            Console.WriteLine("Enter a number");
            N = Convert.ToInt32(Console.ReadLine());
           
            Random rdm = new Random();
            Double G = rdm.Next(1, N);

            
        }
    }
}
