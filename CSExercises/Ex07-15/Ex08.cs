using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Entere temperature in Centigrade");
            Double temp = Convert.ToDouble(Console.ReadLine());
            Double fer = 1.8 * temp + 32;
            Console.WriteLine("The Temperature in Fahrenheit is : " +fer);
        }
    }
}
