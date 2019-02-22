using System;

namespace Practicals_4
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

        private static void Q6()
        {
            int mile;
            double allowance;
            double expenses;
            Console.Write("Enter the miles travelled by employee: ");
            int.TryParse(Console.ReadLine(), out mile);
            Console.Write("Enter the allowance per mile: ");
            double.TryParse(Console.ReadLine(), out allowance);
            expenses = mile * allowance;
            if (mile > 150)
                expenses += 100;
            if (expenses < 50)
                expenses *= 1.06;
            Console.WriteLine("Total expenses payable to an employee is {0:c}", expenses);
        }

        private static void Q5()
        {
            double book1, book2, book3, total;
            Console.Write("Enter the prace of book 1: ");
            double.TryParse(Console.ReadLine(), out book1);
            Console.Write("Enter the prace of book 2: ");
            double.TryParse(Console.ReadLine(), out book2);
            Console.Write("Enter the prace of book 3: ");
            double.TryParse(Console.ReadLine(), out book3);
            total = book1 + book2 + book3;
            if (total > 50)
                total *= 0.9;
            Console.WriteLine("Total amount = {0:c}", total);
        }

        private static void Q4()
        {
            int number;
            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine(), out number);
            if (number > 100)
                Console.WriteLine($"{number} is greater than 100");
        }

        private static void Q3()
        {
            int grade;
            Console.Write("Enter your exam grade: ");
            int.TryParse(Console.ReadLine(), out grade);
            if (grade >= 40)
                Console.WriteLine("Congratulations – you have passed!!!");
        }

        private static void Q2()
        {
            double number;
            Console.Write("Enter the number: ");
            double.TryParse(Console.ReadLine(), out number);
            if (number < 0)
                Console.WriteLine("{0} is negative.", number);
        }

        private static void Q1()
        {
            double accountBalance;

            //Get Input

            Console.WriteLine("Enter Account Balance: ");
            accountBalance = Convert.ToDouble(Console.ReadLine());

            if (accountBalance < 0)
            {

                Console.WriteLine("You are overdrawn...");
            }
        }
    }
}
