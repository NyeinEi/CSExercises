using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int gnum;

            Random rdm = new Random();
            int rdmnum = rdm.Next(0,9);
            Console.WriteLine("randomS num is: "+rdmnum);
            int count = 0;
            do
            {
                count++;
                if (count == 1)
                {
                    Console.WriteLine("Please Guess and Enter the Number");
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
                
                gnum = Convert.ToInt32(Console.ReadLine());
            } while (gnum != rdmnum);
            Console.WriteLine("Your ans is correct");
            Console.WriteLine("Total count number is: " + count);

            if (count == 2)
            {
                Console.WriteLine("You are a Wizard!");
            }
            else if(count==3)
            {
                Console.WriteLine("You are a Good guess!");
            }
            else
            {
                Console.WriteLine("You are lousy");
            }
        }
    }
}
