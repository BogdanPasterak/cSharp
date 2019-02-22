using System;
using System.Globalization;

namespace Practicals_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // needed to display the Euro sign
            // you also need to change the font in the console
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //var cultureInfoGB = CultureInfo.GetCultureInfo("en-GB");
            //Console.WriteLine(String.Format(cultureInfoGB, "{0:C} GBP", 12.345));

            int no = 100;

            do
            {
                Console.Write("\nChoise Question ( 1 - 9, 0 -> Quit) : ");
                ConsoleKeyInfo UserInput = Console.ReadKey();
                Console.WriteLine("\n");

                if (char.IsDigit(UserInput.KeyChar))
                {
                    no = int.Parse(UserInput.KeyChar.ToString());

                    switch (no)
                    {
                        case 1: Q1(); break;
                        case 2: Q2(); break;
                        case 3: Q3(); break;
                        case 4: Q4(); break;
                        case 5: Q5(); break;
                        case 6: Q6(); break;
                        case 7: Q7(); break;
                        case 8: Q8(); break;
                        case 9: Q9(); break;
                    }
                }

            } while (no != 0);

        }

        private static void Q1()
        {
            //Declare Variables

            String firstName;
            String surname;

            //Get Input

            Console.WriteLine("What Is Your First Name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What Is Your Surname?");
            surname = Console.ReadLine();

            //Output

            Console.WriteLine("Hi " + firstName + " " + surname + ", How Are You?");
        }

        private static void Q2()
        {
            //Declare Variables
            string firstName;
            int luckyNo;

            //Get Input
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your favourite number: ");
            luckyNo = int.Parse(Console.ReadLine());

            //Output
            Console.WriteLine("Hello {0}!", firstName);
            Console.WriteLine("Your lucky number is {0}!", luckyNo);
        }

        private static void Q3()
        {
            // print menu
            Console.WriteLine("A - Calculate the sum of two integer.");
            Console.WriteLine("B - Calculate the wages of employee.");
            Console.WriteLine("C - Calculate the time in minutes of film.");
            char choise;

            // get choise
            do
            {
                Console.Write("Make a choise: ");
                choise = char.Parse(Console.ReadKey().KeyChar.ToString().ToUpper());
                Console.WriteLine();
            } while (choise != 'A' && choise != 'B' && choise != 'C');

            // execute choise
            switch (choise)
            {
                case 'A':
                    Console.Write("Enter the first number: ");
                    int first = int.Parse(Console.ReadLine());
                    Console.Write("Enter the secound number: ");
                    int secound = int.Parse(Console.ReadLine());
                    int sum = first + secound;
                    Console.WriteLine("Sum of {0} and {1} is {2}", first, secound, sum);
                    break;
                case 'B':
                    Console.Write("Enter the number of hours: ");
                    byte hours = byte.Parse(Console.ReadLine());
                    Console.Write("Enter the hourly rate: ");
                    float rate = float.Parse(Console.ReadLine());
                    float wage = rate * hours;
                    Console.WriteLine("Weekly Wage (Before Tax): {0:c}", wage);
                    break;
                case 'C':
                    Console.Write("Enter the number of hours of film: ");
                    byte h = byte.Parse(Console.ReadLine());
                    Console.Write("Enter the number of minutes of film: ");
                    byte m = byte.Parse(Console.ReadLine());
                    int time = h * 60 + m;
                    Console.WriteLine("Film time in minutes is {0} minutes.", time);
                    break;
            }
        }

        private static void Q4()
        {
            Console.Write("Enter the number of your years: ");
            int years = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of your months: ");
            int months = int.Parse(Console.ReadLine());
            int days = months * 30 + years * 365;
            Console.WriteLine("You live {0} days.", days);
        }

        private static void Q5()
        {
            Console.Write("Enter the amount of euro to convert to GBP: ");
            double euro = double.Parse(Console.ReadLine());
            double gbp = euro * 0.72;
            Console.WriteLine("After conversion it is £{0:N2} GBP.", gbp);
        }

        private static void Q6()
        {
            double item1, item2, item3, sum, discont, gross;
            Console.Write("Enter the price of item 1: ");
            double.TryParse(Console.ReadLine(), out item1);
            Console.Write("Enter the price of item 2: ");
            double.TryParse(Console.ReadLine(), out item2);
            Console.Write("Enter the price of item 3: ");
            double.TryParse(Console.ReadLine(), out item3);
            sum = item1 + item2 + item3;
            discont = sum * 0.1;
            gross = sum - discont;
            Console.WriteLine("Price before discont = {0:c}", sum);
            Console.WriteLine("Discont = {0:c}", discont);
            Console.WriteLine("Price after discont = {0:c}", gross);
        }

        private static void Q7()
        {
            int age, year;
            Console.Write("Enter your age (at the end of this year): ");
            int.TryParse(Console.ReadLine(), out age);
            Console.Write("Enter the current year: ");
            int.TryParse(Console.ReadLine(), out year);
            Console.WriteLine("You were born in {0} year.", year - age);
        }

        private static void Q8()
        {
            int height, feets, inches;
            Console.Write("Enter your height in inches: ");
            int.TryParse(Console.ReadLine(), out height);
            feets = height / 12;
            inches = height % 12;
            Console.Write("Yuor height is {0} feeds and {1} inches.", feets, inches);
        }

        private static void Q9()
        {
            int length, width, area, perimeter;
            Console.Write("Enter the length of rectangel: ");
            int.TryParse(Console.ReadLine(), out length);
            Console.Write("Enter the width of rectangel: ");
            int.TryParse(Console.ReadLine(), out width);
            area = length * width;
            perimeter = 2 * (length + width);
            Console.WriteLine("Area of rectangle is " + area);
            Console.WriteLine("Perimeter of rectangle is " + perimeter);
        }
    }
}
