using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Please Enter Number");
                num = Convert.ToInt32(Console.ReadLine());
            }while(num!=88);
            Console.WriteLine("Lucky You!");
        }
    }
}
