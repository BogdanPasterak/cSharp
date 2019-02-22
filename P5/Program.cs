using System;

namespace Practicals_5
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
                Console.Write("\nChoise Question ( 1 - 5, 0 -> Quit) : ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                switch (c)
                {
                    case '1': Q1(); break;
                    case '2': Q2(); break;
                    case '3': Q3(); break;
                    case '4': Q4(); break;
                    case '5': Q5(); break;
                }
            } while (c != '0');
        }

        private static void Q1()
        {
            double accountBalance;
            Console.Write("Enter the balance of an account: ");
            double.TryParse(Console.ReadLine(), out accountBalance);
            if (accountBalance < 0)
                Console.WriteLine("Your account is overdrawn");
            else
                Console.WriteLine("Your account is in credit");
        }

        private static void Q2()
        {
            int grade;
            Console.Write("Enter the grade of exam: ");
            int.TryParse(Console.ReadLine(), out grade);
            if (grade >= 40)
                Console.WriteLine("Congratulations – you have passed!!!");
            else
                Console.WriteLine("You have failed – you must take this course again");
        }

        private static void Q3()
        {
            int num1, num2;
            Console.Write("Enter the number 1: ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter the number 2: ");
            int.TryParse(Console.ReadLine(), out num2);
            if (num1 % num2 == 0)
                Console.WriteLine("The number {0} is divides evenly by the number {1}", num1, num2);
            else
                Console.WriteLine("The number {0} doesn't divides evenly by the number {1}", num1, num2);
        }

        private static void Q4()
        {
            int num1, num2, sum;
            Console.Write("Enter the number 1: ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter the number 2: ");
            int.TryParse(Console.ReadLine(), out num2);
            Console.Write("Enter the sum of this numbers: ");
            int.TryParse(Console.ReadLine(), out sum);
            if (num1 + num2 == sum)
                Console.WriteLine("Well done. {0} is the correct answer.", sum);
            else
                Console.WriteLine("Sorry, you are wrong. The correct answer is {0}", (num1 + num2));
        }

        private static void Q5()
        {
            double hours, rate, wages;
            Console.Write("Enter the hours worked by the emoloyee: ");
            double.TryParse(Console.ReadLine(), out hours);
            Console.Write("Enter the rate per emloyee hour: ");
            double.TryParse(Console.ReadLine(), out rate);
            wages = hours * rate;
            if (hours > 38)
                wages += (hours - 38) * rate * .5;
            Console.WriteLine("Employee wages is {0:c}", wages);
        }
    }
}
