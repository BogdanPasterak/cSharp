using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals_11
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
                Console.Write("\nChoise Question ( 1 - 9, 0 -> Quit) : ");
                c = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine("\n");

                switch (c)
                {
                    case '1': Q1(); break;
                    case '2': Q2(); break;
                    case '3': Q3(); break;
                    case '4': Q4(); break;
                    case '5': Q5(); break;
                    case '6': Q6(); break;
                    case '7': Q7(); break;
                    case '8': Q8(); break;
                    case '9': Q9(); break;
                }
            } while (c != '0');
        }

        private static void Q1()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }

        private static void Q2()
        {
            int i = 10;
            do
            {
                Console.WriteLine(i);
                i--;
            } while (i >= 1);
            Console.WriteLine("BLASTOFF!!!");
        }

        private static void Q3()
        {
            int i = 1;
            int sum = 0;

            do
            {
                sum += i;
                i++;
            } while (i <= 10);

            Console.WriteLine("Sum of 1 to 10 = " + sum);
        }

        private static void Q4()
        {
            int i = 1;
            int sum = 0;
            int limit;
            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine(), out limit);
            if (limit < 1)
                Console.WriteLine("Invalid value");
            else
            {
                do
                {
                    sum += i;
                    i++;
                } while (i <= limit);
                Console.WriteLine("The sum of consecutive numbers to {0} is {1}", limit, sum);
            }
        }

        private static void Q5()
        {
            int value;
            do
            {
                Console.Write("Enter a positive integer value: ");
                int.TryParse(Console.ReadLine(), out value);
            } while (value <= 0);
        }

        private static void Q6()
        {
            int totalSum = 0;
            int num;
            do
            {
                Console.Write("Enter a number to add to sumTotal: ");
                int.TryParse(Console.ReadLine(), out num);
                totalSum += num;
            } while (totalSum < 1000);
            Console.WriteLine("The sumTotal = {0}", totalSum);
        }

        private static void Q7()
        {
            int grade;

            do
            {
                Console.Write("Enter a result in a subject: ");
                int.TryParse(Console.ReadLine(), out grade);
            } while (grade < 0 || grade > 100);
            Console.WriteLine("You grade is {0}", grade);
        }

        private static void Q8()
        {
            int i = 0, sum = 0, age;

            do
            {
                Console.Write("Enter the age of person {0}: ", i + 1);
                int.TryParse(Console.ReadLine(), out age);
                sum += age;
                i++;
            } while (i < 10);
            Console.WriteLine("Average of age is {0:n1}", sum / 10.0);
        }

        private static void Q9()
        {
            char choice = '0';
            do
            {
                Console.WriteLine("***MAIN MENU***");
                Console.WriteLine("  1. Option 1");
                Console.WriteLine("  2. Option 2");
                Console.WriteLine("  3. Quit");
                Console.Write("Please Enter Choice: ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        Console.WriteLine("Option 1 Chosen...");
                        break;
                    case '2':
                        Console.WriteLine("Option 2 Chosen...");
                        break;
                    case '3':
                        Console.WriteLine("Quitting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Option Chosen...");
                        break;
                }
            } while (choice != '3');
        }

     }
}
