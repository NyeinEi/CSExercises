using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Please Enter a Number");
            //int num = Convert.ToInt32(Console.ReadLine());
            int a = 2;
            for (int i = 5; i < 10000; i++)
            {
                //if (i == 0 || i == 1)
                //{
                //    Console.WriteLine(i + " is not prime number");
                //    Console.ReadLine();
                //}
                //else
                //{
                if (i % a != 0)
                {
                    Console.WriteLine(i + " is  prime number");
                }
                //else
                //{
                //    Console.WriteLine(i + " is a prime number");
                //}
            }
        }
    }
}
