using System;

namespace SandyLab3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, number2;
            string continuing;

            do
            {
                Console.WriteLine("Hello, what is your first name?");
                var name = Console.ReadLine();
                Console.WriteLine("Hello " + name + ", please enter a number between 1-100");

                number = Convert.ToInt32(Console.ReadLine());
                number2 = number % 2;

                {

                    if (number < 25 && number2 == 0)
                    {
                        Console.WriteLine("{0}", number + " is even and less than 25");
                    }

                    else if (number2 == 0)

                        Console.WriteLine("{0} even", number);
                    else
                    {
                        Console.WriteLine("{0} odd", number);
                    }
                    Console.WriteLine("Would you like to continue " + name + "? y/n");
                    continuing = Console.ReadLine();
                }
            }
        while (continuing == "y");
        return;
        }
    }
}
