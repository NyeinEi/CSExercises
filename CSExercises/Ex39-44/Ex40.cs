using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSExercises
{
    class Ex40
    {
        static int SQT(int input)
        {
            int result = 1;

            if (input >= 1 && input <= 25)
            {
                result =Convert.ToInt32(input *0.5) ;
                Console.WriteLine("Square Root of the number is: " + result);
            }
            else
            {
                Console.WriteLine("Please Enter Number from 1 to 25");
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number!");
            int input = Convert.ToInt32(Console.ReadLine());
            SQT(input);
        }
    }
}
