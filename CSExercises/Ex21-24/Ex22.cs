using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int firstnum, secondnum,lcm,hcf,C;

            Console.WriteLine("Please Enter first Number");
            firstnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number");
            secondnum = Convert.ToInt32(Console.ReadLine());

            C = firstnum * secondnum;

            do
            {
                if (firstnum > secondnum)
                {
                    firstnum = firstnum - secondnum;
                    hcf=firstnum;
                    Console.WriteLine("HCF is : "+ hcf);
                }
                else
                {
                    secondnum = secondnum - firstnum;
                    hcf=secondnum;
                    Console.WriteLine("HCF is : " + hcf);
                }
            } while (firstnum != secondnum);
            Console.WriteLine("X");

            lcm = C / hcf;
            Console.WriteLine("LCM is: " + lcm);
            
        }
    }
}
