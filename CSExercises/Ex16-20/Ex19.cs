using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
           Double distanceinkm,distanceinm;
            double fare = 0.0;
            Console.WriteLine("Please Enter your Distance in km");
            distanceinkm = Convert.ToDouble(Console.ReadLine());
            distanceinm=Math.Round(distanceinkm*1000,2);
            //Console.WriteLine("Distance in Meter is " + distanceinm);
            
            if(distanceinm<=500)
            {
                fare = 2.40;
            }
            else if(distanceinm>500 && distanceinm<850)
            {
                fare=85*0.04;
            }
            else if(distanceinm>900)
            {
                fare=(distanceinm-90)*0.05;
            }
        }
    }
}