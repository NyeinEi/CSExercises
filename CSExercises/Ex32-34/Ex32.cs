using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] sales=new int[4];
            int i;

            for (i = 0; i < sales.Length;i++ )
            {
                Console.WriteLine("Enter Sale for Month "+i+" :");
                sales[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int green = 0; green < sales.Length; green++)
            {
                for (int red = green + 1; red < sales.Length; red++)
                {
                    if (sales[red] < sales[green])
                    {
                        int temp = sales[red];
                        sales[red] = sales[green];
                        sales[green] = temp;
                    }
                }
            }
            for (int j = 0; j < sales.Length; j++)
            {
                Console.Write("{0} \t", sales[j]);
            }
            
        }
    }
}
