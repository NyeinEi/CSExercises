using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSExercises
{
     public class Ex32
    {
        static void Main(string[] args)
        {
            int[] sales = new int[4];
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine("Enter Sales for month " + i + " :");
                sales[i] = Convert.ToInt32(Console.ReadLine());
                sum += sales[i];
                avg = sum / 4;
            }
            int green, red, temp;
            for (green = 0; green < sales.Length - 1; green++)
            {
                for (red = green + 1; red < sales.Length; red++)
                {
                    if (sales[red] < sales[green])
                    {
                        temp = sales[red];
                        sales[red] = sales[green];
                        sales[green] = temp;
                    }
                }
            }
            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write("{0}\t", sales[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Maximum Sales: " + sales[3]);
            Console.WriteLine("Minimum Sales: " + sales[0]);
            Console.WriteLine("Average Sales: " + avg);
        }
    }
}
