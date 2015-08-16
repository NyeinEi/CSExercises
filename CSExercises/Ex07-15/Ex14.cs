using System;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter value of 'a' ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the value of 'b' ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the value of 'c'");
            double c = Convert.ToDouble(Console.ReadLine());

            double s = (a + b + c )/ 2;
            double area = Math.Sqrt(s* (s-a) * (s-b) * (s-c));

            Console.WriteLine("The Area of the triangle is :" + area);
        }
    }
}