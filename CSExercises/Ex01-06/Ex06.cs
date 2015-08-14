using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter an Integer!");
            int i = Convert.ToInt32(Console.ReadLine());
            Double s = Convert.ToDouble(Math.Sqrt(i));
            Console.WriteLine("Square Root of your Number is : " + s);
        }
    }
}
