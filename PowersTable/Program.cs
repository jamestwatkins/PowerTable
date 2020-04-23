using System;
using System.Linq;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;


                Console.WriteLine("Square and Cube Table!");
                Console.WriteLine("----------------------");


            while (again == true)
            {

                int input = ConvertToInt("Enter an Integer:");

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Number   Square   Cube");
                Console.WriteLine("------   ------   ----");



                for (int x = 1; x <= input; x++)
                {

                    Console.WriteLine("   {0, -8} {1, -7} {2, -8}", x, x * x, (Math.Pow(x, 3)));

                    Console.WriteLine();

                    Console.WriteLine();

                }

                Console.WriteLine("Would you like to try another number? (y to continue)");

                

                again = RepeatProgram(Console.ReadLine().ToLower());

                Console.WriteLine();
                Console.WriteLine();


            }

            Console.WriteLine("Goodbye!");
            
        }


        public static int ConvertToInt(string message)
        {
            while (true)
            {

                Console.WriteLine(message);

                string response = Console.ReadLine();

                bool isNum = response.All(Char.IsDigit);

                int num = 0;

                if (isNum)
                {

                    num = int.Parse(response);

                }
                else
                {

                    Console.WriteLine();
                    Console.WriteLine();
                    continue;
                }

                if (num < 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    continue;
                }

                return num;
            }
        }


        public static bool RepeatProgram(string answer)
        {

            if (answer == "y")
            {
                return true;

            }

            return false;

        }
    }
}
