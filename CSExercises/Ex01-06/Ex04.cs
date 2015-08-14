using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Double Num!");
            double i = Convert.ToDouble(Console.ReadLine());
            double s = Convert.ToDouble(i*i);
            Console.WriteLine("Square Root of your Number is : " + s);
        }
    }
}
