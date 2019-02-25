using System;

namespace Practicals_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // needed to display the Euro sign
            // you also need to change the fonts in the console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char c;

            do
            {
                Console.Write("\nChoise Question ( 1 - 3, 0 -> Quit) : ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                switch (c)
                {
                    case '1': Q1(); break;
                    case '2': Q2(); break;
                    case '3': Q3(); break;
                }
            } while (c != '0');
        }

        private static void Q1()
        {
            int grade;
            Console.Write("Enter the grade of exam: ");
            int.TryParse(Console.ReadLine(), out grade);
            if (grade < 0 || grade > 100)
                Console.WriteLine("Invalid result ");
            else if (grade < 40)
                Console.WriteLine("Fail");
            else
                Console.WriteLine("Pass");
        }

        private static void Q2()
        {
            double temp;
            Console.Write("Enter the temperature of water: ");
            double.TryParse(Console.ReadLine(), out temp);
            if (temp < 0)
                Console.WriteLine("ICE");
            else if (temp <= 100)
                Console.WriteLine("WATER");
            else
                Console.WriteLine("STEAM");
        }

        private static void Q3()
        {
            int age;
            double price;
            Console.Write("Enter your age: ");
            int.TryParse(Console.ReadLine(), out age);
            if (age < 0 )
                Console.WriteLine("Invalid age value");
            else if (age < 12)
                Console.WriteLine("Free");
            else if (age < 18)
                Console.WriteLine("{0:c}", 5);
            else if (age <= 65)
                Console.WriteLine("{0:c}", 6);
            else
                Console.WriteLine("{0:c}", 4.5);
        }

    }
}
