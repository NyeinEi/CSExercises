using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number, fact;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of Given Number is: " + fact);
            Console.ReadLine();
        }
    }
}
