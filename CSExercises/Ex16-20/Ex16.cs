using System;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string name,gender;

            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();

            Console.WriteLine("Please Enter gender, 'M' for Male and 'F' for Female");
            gender = Console.ReadLine();

            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr. " + name);
            }
            else if (gender=="F")
            {
                Console.WriteLine("Good Morning Ms. " + name);
            }
            else
            {
                Console.WriteLine("Please Enter 'M' and 'F'");
            }
        }
    }
}