using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Double distance, fare;
            Console.WriteLine("Please Enter the Distance");
            distance = Convert.ToDouble(Console.ReadLine());
            fare = 2.40 + distance * 0.4;
            Console.WriteLine("The total fare for this trip is: {0:#.#0} ", fare);
        }
    }
}
