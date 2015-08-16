using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Double distance, fare;
            Console.WriteLine("Please Enter the Distance");
            distance = Convert.ToDouble(Console.ReadLine());
            fare = 2.40 + distance * 0.4;
            double fare1= Math.Ceiling(fare*10)/10;
            
            Console.WriteLine("The total fare for this trip is: {0}", fare1);
            
        }
    }
}
