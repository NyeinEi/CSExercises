using System;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("No:" + "\t" + "INVERSE" + "\t" + "SQUARE ROOT" + "\t" + "SQUARE");
            for (double i = 1; i <= 10; i++)
            {
                
                Console.WriteLine(i + "\t" + Math.Round((1 / i), 3) + "\t" + Math.Round((Math.Sqrt(i)), 3) + "\t" + "\t" + (i*i));
            }
            Console.ReadLine();
        }
    }
}
