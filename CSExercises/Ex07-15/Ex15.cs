using System;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int sum=0,j,i,l;
            Console.WriteLine("Please Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());

           for (i=num; i > 0; i = i/10)
           {
               j= i%10;
               sum += j*j*j;
           }

            if(num==sum) {
                Console.WriteLine("This is  armstrong number");
            }
            else {
                Console.WriteLine("This is not armstrong number.");
            }
        }
    }
}