using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals_9
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
                Console.Write("\nChoise Question ( 1 - C, 0 -> Quit) : ");
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
                    case 'C': QC(); break;
                }
            } while (c != '0');
        }

        private static void Q1()
        {
            Console.Write("Press a digit: ");
            char d = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (Char.IsDigit(d))
            {
                switch (d)
                {
                    case '0':
                        Console.WriteLine("Zero");
                        break;
                    case '1':
                        Console.WriteLine("One");
                        break;
                    case '2':
                        Console.WriteLine("Two");
                        break;
                    case '3':
                        Console.WriteLine("Three");
                        break;
                    case '4':
                        Console.WriteLine("Four");
                        break;
                    case '5':
                        Console.WriteLine("Five");
                        break;
                    case '6':
                        Console.WriteLine("Six");
                        break;
                    case '7':
                        Console.WriteLine("Seven");
                        break;
                    case '8':
                        Console.WriteLine("Eight");
                        break;
                    case '9':
                        Console.WriteLine("Nine");
                        break;
                }
            }
        }

        private static void Q2()
        {
            Console.Write("Press a digit (1 - 7): ");
            char d = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (d)
            {
                case '1':
                    Console.WriteLine("Monday");
                    break;
                case '2':
                    Console.WriteLine("Tuesday");
                    break;
                case '3':
                    Console.WriteLine("Wednesday");
                    break;
                case '4':
                    Console.WriteLine("Thursday");
                    break;
                case '5':
                    Console.WriteLine("Friday");
                    break;
                case '6':
                    Console.WriteLine("Saturday");
                    break;
                case '7':
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Inproper value.");
                    break;
            }
        }

        private static void Q3()
        {
            Console.Write("Press a grade letter ( A - F): ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (ch)
            {
                case 'A':
                    Console.WriteLine("Excellent Student.");
                    break;
                case 'B':
                    Console.WriteLine("Good Student.");
                    break;
                case 'C':
                case 'D':
                    Console.WriteLine("Fair Student.");
                    break;
                case 'E':
                case 'F':
                    Console.WriteLine("Poor Student.");
                    break;
                default:
                    Console.WriteLine("Invalid Grade.");
                    break;
            }
        }

        private static void Q4()
        {
            Console.Write("Press a grade letter ( A - F ): ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            ch = Char.ToUpper(ch);

            switch (ch)
            {
                case 'A':
                    Console.WriteLine("Excellent Student.");
                    break;
                case 'B':
                    Console.WriteLine("Good Student.");
                    break;
                case 'C':
                case 'D':
                    Console.WriteLine("Fair Student.");
                    break;
                case 'E':
                case 'F':
                    Console.WriteLine("Poor Student.");
                    break;
                default:
                    Console.WriteLine("Invalid Grade.");
                    break;
            }
        }

        private static void Q5()
        {
            Console.Write("Press some letter: ");
            char ch = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            ch = Char.ToUpper(ch);

            switch (ch)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Vowel.");
                    break;
                default:
                    Console.WriteLine("Not vowel.");
                    break;
            }
        }

        private static void Q6()
        {
            Console.Write("Press a digit: ");
            char d = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (Char.IsDigit(d))
            {
                if (d == '0')
                    Console.WriteLine("Zero");
                else if (d == '1')
                    Console.WriteLine("One");
                else if (d == '2')
                    Console.WriteLine("Two");
                else if (d == '3')
                    Console.WriteLine("Three");
                else if (d == '4')
                    Console.WriteLine("Four");
                else if (d == '5')
                    Console.WriteLine("Five");
                else if (d == '6')
                    Console.WriteLine("Six");
                else if (d == '7')
                    Console.WriteLine("Seven");
                else if (d == '8')
                    Console.WriteLine("Eight");
                else
                    Console.WriteLine("Nine");
            }
        }

        private static void Q7()
        {
            Console.Write("Press a digit (1 - 7): ");
            char d = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (d == '1')
                Console.WriteLine("Monday");
            else if (d == '2')
                Console.WriteLine("Tuesday");
            else if (d == '3')
                Console.WriteLine("Wednesday");
            else if (d == '4')
                Console.WriteLine("Thursday");
            else if (d == '5')
                Console.WriteLine("Friday");
            else if (d == '6')
                Console.WriteLine("Saturday");
            else if (d == '7')
                Console.WriteLine("Sunday");
            else
                Console.WriteLine("Inproper value.");
        }

        private static void Q8()
        {
            Console.Write("Press a grade letter ( A - F ): ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            ch = Char.ToUpper(ch);

            if (ch == 'A')
                Console.WriteLine("Excellent Student.");
            else if (ch == 'B')
                Console.WriteLine("Good Student.");
            else if (ch == 'C' || ch == 'D')
                Console.WriteLine("Fair Student.");
            else if (ch == 'E' || ch == 'F')
                Console.WriteLine("Poor Student.");
            else
                Console.WriteLine("Invalid Grade.");
        }

        private static void Q9()
        {
            Console.Write("Press some letter: ");
            char ch = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            ch = Char.ToUpper(ch);

            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                Console.WriteLine("Vowel.");
            else
                Console.WriteLine("Not vowel.");
        }

        private static void QA()
        {
            Console.WriteLine("Both forms are useful.");
        }

        private static void QB()
        {
            Console.WriteLine("Calculation Menu:");
            Console.WriteLine("  1. ADD");
            Console.WriteLine("  2. SUBTRACT");
            Console.Write("Please Enter Choice: ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (choice == '1' || choice == '2')
            {
                int num1, num2;
                Console.WriteLine("Enter the number 1: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Enter the number 2: ");
                int.TryParse(Console.ReadLine(), out num2);
                switch (choice)
                {
                    case '1':
                        Console.WriteLine("Sum = {0}", num1 + num2);
                        break;
                    case '2':
                        Console.WriteLine("Difference = {0}", num2 - num1);
                        break;
                }
            }
            else
                Console.WriteLine("Incorrect Option Chosen.");
        }

        private static void QC()
        {
            int num1, num2;
            Console.WriteLine("Enter the number 1: ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Enter the number 2: ");
            int.TryParse(Console.ReadLine(), out num2);

            Console.Write("Type the operator ( +, -, *, / or % ): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (operation)
            {
                case '+':
                    Console.WriteLine("Result of {1} is {0}", num1 + num2, operation);
                    break;
                case '-':
                    Console.WriteLine("Result of {1} is {0}", num1 - num2, operation);
                    break;
                case '*':
                    Console.WriteLine("Result of {1} is {0}", num1 * num2, operation);
                    break;
                case '/':
                    Console.WriteLine("Result of {1} is {0}", num1 / num2, operation);
                    break;
                case '%':
                    Console.WriteLine("Result of {1} is {0}", num1 % num2, operation);
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }
}
