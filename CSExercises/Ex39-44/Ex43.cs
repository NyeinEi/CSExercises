using System;
namespace CSExercises
{
    public class Ex43
    {
        static void printHexa()
        {
            string result = null;

            for (int i = 1; i <= 100; i++)
            {
                int remain = i % 16;
                int divi = i / 16;
                int remain2 = divi % 16;

                result = remain.ToString();

                switch (result)
                {
                    case "10":
                        result = "A";
                        break;
                    case "11":
                        result = "B";
                        break;
                    case "12":
                        result = "C";
                        break;
                    case "13":
                        result = "D";
                        break;
                    case "14":
                        result = "E";
                        break;
                    case "15":
                        result = "F";
                        break;
                }

                Console.WriteLine(remain2 + result);
            }
        }

        static void Main(string[] args)
        {
            printHexa();
        }
    }
}
