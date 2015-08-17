using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Double mark;
            Console.WriteLine("Please Enter Your marks");
            mark =Convert.ToDouble(Console.ReadLine());

            if (mark >= 80 && mark <= 100)
            {
                Console.WriteLine("Your Grade is 'A'");
            }
            else if (mark >= 60 && mark <= 79)
            {
                Console.WriteLine("Your Grade is 'B'");
            }
            else if (mark >= 40 && mark <= 59)
            {
                Console.WriteLine("Your Grade is 'C'");
            }
            else if (mark >= 0 && mark < 40)
            {
                Console.WriteLine("Your Grade is 'F'");
            }
            else
            {
                Console.WriteLine("Please Enter Your mark between 0 -100");
            }
        }
    }
}