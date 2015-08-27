using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSExercises
{
    class Ex39
    {
        static double Factorial(double input)
        {
            double result = 1;
            for (int i = 1; i <= input; i++)
            {
                result = result * i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number!");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Factor of the number is: " + Factorial(input));
        }
    }
}
