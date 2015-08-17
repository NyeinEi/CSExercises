using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string name, gender;
            int age;

            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Gender, 'M' for Male and 'F' for Female");
            gender = Console.ReadLine();

            Console.WriteLine("Please Enter  Your Age");
            age = Convert.ToInt32(Console.ReadLine());

            if (gender == "F" && age > 40)
            {
                Console.WriteLine("Good Morning Aunty " + name);
            }
            else if (gender == "M" && age > 40)
            {
                Console.WriteLine("Good Morning Uncle " + name);
            }
            else
            {
                Console.WriteLine("Please Type Correct information");
            }
        }
    }
}