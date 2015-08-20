using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            int green, red, temp;
            for (green = 0; green < arr.Length - 1; green++)
            {
                for (red = green + 1; red < arr.Length; red++)
                {
                    if (arr[red] > arr[green])
                    {
                        temp = arr[red];
                        arr[red] = arr[green];
                        arr[green] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}\t", arr[i]);
            }
            Console.WriteLine();

        }
    }
}
