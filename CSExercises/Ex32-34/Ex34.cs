using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSExercises
{
    public class Ex34
    {
        static void Main(string[] args)
        {
            int[,] mark = new int[12, 5] { { 56, 84, 68, 29, 0 }, { 94, 73, 31, 89, 0 }, { 41, 63, 36, 90, 0 }, { 99, 9, 18, 17, 0 }, { 62, 3, 65, 75, 0 }, { 40, 96, 53, 23, 0 }, { 81, 15, 27, 30, 0 }, { 21, 70, 100, 22, 0 }, { 88, 50, 13, 12, 0 }, { 48, 54, 52, 78, 0 }, { 64, 71, 67, 25, 0 }, { 16, 93, 46, 72, 0 } };
            int sum = 0, avg = 0, totalmark = 0;
            //(a) total mark for each student
            for (int i = 0; i < 12; i++)
            {
                mark[i, 4] = mark[i, 0] + mark[i, 1] + mark[i, 2] + mark[i, 3];
            }

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mark[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            //(b) class average for each subject
            for (int sub1 = 0; sub1 < 12; sub1++)
            {
                sum += mark[sub1, 0];
                avg = sum / 12;
                totalmark += sum;
            }
            Console.WriteLine("Average of the Subject 1 is: " + avg);

            sum = 0; avg = 0;
            for (int sub2 = 1; sub2 < 12; sub2++)
            {

                sum += mark[sub2, 0];
                avg = sum / 12;
                totalmark += sum;
            }
            Console.WriteLine("Average of the Subject 2 is: " + avg);

            sum = 0; avg = 0;
            for (int sub3 = 2; sub3 < 12; sub3++)
            {
                sum += mark[sub3, 0];
                avg = sum / 12;
                totalmark += sum;
            }
            Console.WriteLine("Average of the Subject 3 is: " + avg);

            sum = 0; avg = 0;
            for (int sub4 = 2; sub4 < 12; sub4++)
            {
                sum += mark[sub4, 0];
                avg = sum / 12;
                totalmark += sum;
            }
            Console.WriteLine("Average of the Subject 4 is: " + avg);

            //(c) overall average marks for all subjects
            Console.WriteLine("overall average marks for all subjects is: " + totalmark / 24);
        }
    }
}
