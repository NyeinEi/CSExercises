using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double x1, x2, y1, y2, distance;
            Console.WriteLine("Please Enter 'x1' value ");
             x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter 'x2' value ");
             x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter 'y1' value ");
             y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter 'y2' value ");
             y2 = Convert.ToDouble(Console.ReadLine());
             distance = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
             Console.WriteLine("Distance between these two points is: " + distance);
        }
    }
}
