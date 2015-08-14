using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Salary!");
            Double salary = Convert.ToDouble(Console.ReadLine());
            Double hallo = salary * 0.1;
            Double Tallo = salary * 0.03;
            Double total = salary + hallo + Tallo;
            Console.WriteLine("Total Income is: {0:c} ", total);
        }
    }
}
