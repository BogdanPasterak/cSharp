using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals_12
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
                Console.Write("\nChoise Question ( 1 - B, 0 -> Quit) : ");
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
                    case 'A': QA(); break;
                    case 'B': QB(); break;
                }
            } while (c != '0');
        }


        private static void Q1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        private static void Q2()
        {
            int limit;
            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine(), out limit);
            if (limit < 1)
                Console.WriteLine("Invalid value");
            else
            {
                for (int i = 0; i < limit; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void Q3()
        {
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void Q4()
        {
            for (int i = 10; i >= 5; i--)
            {
                Console.Write(i);
                if (i != 5)
                    Console.Write(", ");
                else
                    Console.Write(".");
            }
            Console.WriteLine();
        }

        private static void Q5()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum = " + sum);
        }

        private static void Q6()
        {
            int sum = 0;
            int limit;
            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine(), out limit);
            if (limit < 1)
                Console.WriteLine("Invalid value");
            else
            {
                for (int i = 1; i <= limit; i++)
                {
                    sum += i;
                }
                Console.WriteLine("The sum of consecutive numbers to {0} is {1}", limit, sum);
            }
        }

        private static void Q7()
        {
            int sum = 0;
            for (int i = 2; i <= 100; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sum = " + sum);
        }

        private static void Q8()
        {
            int sum = 0, age, number;
            Console.Write("Enter the number of persons: ");
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 1; i <= number; i++)
            {
                Console.Write("Enter the age of person {0}: ", i );
                int.TryParse(Console.ReadLine(), out age);
                sum += age;
            }
            Console.WriteLine("Average of age is {0:n2}", sum / (double)number);
        }

        private static void Q9()
        {
            int number;
            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine(), out number);

            if (number < 1)
                Console.WriteLine("The number is less than 1");
            else
            {
                Console.WriteLine("{0,-12}{1,-12}{2,-12}", "Number", "Square", "Cube");
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine("{0,-12}{1,-12}{2,-12}", i, i * i, i * i * i);
                }
            }
        }

        private static void QA()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && i % 4 == 0)
                    sum += i;
            }
            Console.WriteLine("Sum = " + sum);
        }

        private static void QB()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 || i % 4 == 0)
                    sum += i;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
