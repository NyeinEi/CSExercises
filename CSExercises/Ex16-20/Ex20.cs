using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Double qtyTV, qtyDVD, qtyMP3, priceTV, priceDVD, pricemp3, totalfor2, totalfor3;
            Console.WriteLine("Please Enter quantity for TV: ");
            qtyTV = Convert.ToDouble(Console.ReadLine());
            priceTV = 900 * qtyTV;

           Console.WriteLine("Please Enter quantity for TV: ");
           qtyDVD = Convert.ToDouble(Console.ReadLine());
           priceDVD = 500 * qtyDVD;

           Console.WriteLine("Please Enter quantity for TV: ");
           qtyMP3 = Convert.ToDouble(Console.ReadLine());
           pricemp3 = 700 * qtyMP3;

           totalfor2 = priceTV + priceDVD;

           if (totalfor2 > 5000 && totalfor2<=10000)
           {
               double discount = totalfor2 - (totalfor2 * 0.1);
               Console.WriteLine("you got 10% discount");
               totalfor3 = discount + pricemp3;
               Console.WriteLine("Total Price is: " + totalfor3);
           }
           else if (totalfor2 > 10000)
           {
               double discount = totalfor2 - (totalfor2 * 0.15);
               Console.WriteLine("you got 15% discount");
               totalfor3 = discount + pricemp3;
               Console.WriteLine("Total Price is: " + totalfor3);
           }
           else
           {
               Console.WriteLine("you can't get any discount");
           }


            
        }
    }
}