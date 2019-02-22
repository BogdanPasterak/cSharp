using System;

namespace Practicals_7
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
            int hours, minutes;
            Console.Write("Enter the hours: ");
            int.TryParse(Console.ReadLine(), out hours);
            Console.Write("Enter the minutes: ");
            int.TryParse(Console.ReadLine(), out minutes);
            if (hours < 0)
                Console.WriteLine("Hours Invalid (< 0)");
            else if (hours > 23)
                Console.WriteLine("Hours Invalid (> 23)");
            else
                Console.WriteLine("Hours Valid");
            if (minutes < 0)
                Console.WriteLine("Minutes Invalid (< 0)");
            else if (minutes > 59)
                Console.WriteLine("Minutes Invalid (> 59)");
            else
                Console.WriteLine("Minutes Valid");
        }
    }
}
