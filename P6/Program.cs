using System;

namespace Practicals_6
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
                Console.Write("\nChoise Question ( 1 - 6, 0 -> Quit) : ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                switch (c)
                {
                    case '1': Q1(); break;
                    case '2': Q2(); break;
                    case '3': Q3(); break;
                    case '4': Q4(); break;
                    case '5': Q5(); break;
                    case '6': Q6(); break;
                }
            } while (c != '0');
        }

        private static void Q1()
        {
            double number;
            Console.Write("Enter the number: ");
            double.TryParse(Console.ReadLine(), out number);
            if (number == 0)
                Console.WriteLine("The number is equal 0.");
            else if (number < 0)
                Console.WriteLine($"{number} is negative.");
            else
                Console.WriteLine($"{number} is positive.");
        }

        private static void Q2()
        {
            int num1, num2;
            Console.Write("Enter the number 1: ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter the number 2: ");
            int.TryParse(Console.ReadLine(), out num2);
            if (num1 == num2)
                Console.WriteLine("Both numbers are the same");
            else if (num1 < num2)
                Console.WriteLine("The smaller number is " + num1);
            else
                Console.WriteLine("The smaller number is " + num2);
        }

        private static void Q3()
        {
            int grade;
            Console.Write("Enter the grade of exam: ");
            int.TryParse(Console.ReadLine(), out grade);
            if (grade < 0)
                return;
            else if (grade < 40)
                Console.WriteLine("0 – 39: Fail");
            else if (grade < 55)
                Console.WriteLine("40 – 54: Pass");
            else if (grade < 70)
                Console.WriteLine("55 – 69: Merit");
            else if (grade <= 100)
                Console.WriteLine("70 – 100: Distinction");
        }

        private static void Q4()
        {
            double scale;
            Console.Write("Enter the Richter scale value: ");
            double.TryParse(Console.ReadLine(), out scale);
            if (scale < 0)
                Console.WriteLine("Negative numbers are not valid.");
            else if (scale <= 3.5)
                Console.WriteLine("Generally not felt.");
            else if (scale <= 4.5)
                Console.WriteLine("Felt by many people, no destruction.");
            else if (scale <= 6)
                Console.WriteLine("Damage to poorly constructed buildings.");
            else if (scale <= 7)
                Console.WriteLine("Many buildings damaged.");
            else if (scale <= 8)
                Console.WriteLine("Many buildings destroyed.");
            else
                Console.WriteLine("Most structures fall.");
        }

        private static void Q5()
        {
            int hours;
            double  rate, wages;
            Console.Write("Enter the hours worked in the week: ");
            int.TryParse(Console.ReadLine(), out hours);
            Console.Write("Enter the rate per emloyee hour: ");
            double.TryParse(Console.ReadLine(), out rate);
            wages = hours * rate;
            if (hours > 45)
                wages *= 1.2;
            else if (hours > 40)
                wages *= 1.15;
            else if (hours > 37)
                wages *= 1.1;
            Console.WriteLine("The wages is {0:c}", wages);
        }

        private static void Q6()
        {
            Console.WriteLine("Calculation Menu:");
            Console.WriteLine("   1. ADD");
            Console.WriteLine("   2. SUBTRACT");
            Console.Write("Please Enter Choice: ");
            char choise = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (choise == '1' || choise == '2')
            {
                double num1, num2;
                Console.Write("Enter the number 1: ");
                double.TryParse(Console.ReadLine(), out num1);
                Console.Write("Enter the number 2: ");
                double.TryParse(Console.ReadLine(), out num2);
                if (choise == '1')
                    Console.WriteLine("The sum = {0}", num1 + num2);
                else
                    Console.WriteLine("The difference = {0}", num2 - num1);
            }
            else
                Console.WriteLine("Incorrect Option Chosen.");
        }
    }
}
