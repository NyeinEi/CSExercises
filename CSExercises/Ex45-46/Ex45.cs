using System;
namespace CSExercises
{
    public class Ex45
    {
        static double denomination(double input)
        {
            input = input * 100;
            //double[] arr=new double[5]{100,50,20,10,5};

            if (input >= 0.05 && input <= 350)
            {
                for (int i = 0; i <= input; i++)
                {
                    if (input > 100)
                    {
                        Console.WriteLine(100);
                        input = input - 100;
                    }
                    else if (input > 50)
                    {
                        Console.WriteLine(50);
                        input = input - 50;
                    }
                    else if (input > 20)
                    {
                        Console.WriteLine(20);
                        input = input - 20;
                    }
                    else if (input > 10)
                    {
                        Console.WriteLine(10);
                        input = input - 10;
                    }
                    else
                    {
                        Console.WriteLine(5);
                        input = input - 5;
                    }
                }
            }
            return input;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 cents and 3 dollors 50 cents");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(denomination(num));
        }
    }
}
