using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter an Integer");
            double i = Convert.ToDouble(Console.ReadLine());
            double s = Convert.ToDouble(Math.Sqrt(i));
            Console.WriteLine("Square Root of your Number is : " + s);
        }
    }
}
