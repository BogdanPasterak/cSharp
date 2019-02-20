using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = 100;

            do
            {
                Console.Write("\nChoise Question ( 1 - 7, 0 -> Quit) : ");
                ConsoleKeyInfo UserInput = Console.ReadKey();
                Console.WriteLine("\n");

                if (char.IsDigit(UserInput.KeyChar))
                {
                    no = int.Parse(UserInput.KeyChar.ToString());

                    if (no <= 7)
                    {
                        switch (no)
                        {
                            case 1: Q1(); break;
                            case 2: Q2(); break;
                            case 3: Q3(); break;
                            case 4: Q4(); break;
                            case 5: Q5(); break;
                            case 6: Q6(); break;
                            case 7: Q7(); break;
                        }

                    }
                }

            } while (no != 0);

        }

        static void Q1()
        {
            int year;
            year = 2019;
            Console.WriteLine("The current year is " + year);
        }

        static void Q2()
        {
            double price = 10.99;
            int quantity = 120;

            Console.WriteLine("Price of Book:   \t{0:0.00}", price);
            Console.WriteLine("Quantity in Stock: \t{0}", quantity);
        }

        static void Q3()
        {
            int employeeNo = 123;
            char departament = 'B';
            double salary = 27356.78;
            int holidays = 25;

            Console.WriteLine("****Employee Details*****");
            Console.WriteLine("Dept: {0}", departament);
            Console.WriteLine("Employee No: {0}", employeeNo);
            Console.WriteLine("Salary: {0:0.00}", salary);
            Console.WriteLine("Annual Holidays: {0}", holidays);
        }

        static void Q4()
        {
            int day = 20, month = 2, year = 2019;
            Console.WriteLine("Today is {0}/{1}/{2}", day, (((month < 10) ? "0" : "") + month), year);
        }

        static void Q5()
        {
            string name = "Joe Soap";
            string ppsNo = "8069AB";
            string socialWelfarePayment = "Job Seekers Benefit";
            double weeklyPayment = 100.00;

            Console.WriteLine("*!*!*Social Welfare Details*!*!*");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("PPS Number: {0}", ppsNo);
            Console.WriteLine("Social Welfare Payment: {0}", socialWelfarePayment);
            Console.WriteLine("Weekly Payment: {0:0.00}", weeklyPayment);
        }

        static void Q6()
        {
            string type = "Car";
            string make = "Ford";
            string model = "Focus";
            string plate = "01DL12345";

            Console.WriteLine("*%*%*Vehicle Details*%*%*");
            Console.WriteLine("Vehicule Type: {0}", type);
            Console.WriteLine("Vehicule Make: {0}", make);
            Console.WriteLine("Vehicule Model: {0}", model);
            Console.WriteLine("Vehicule Registration: {0}", plate);
        }

        static void Q7()
        {
            int day = 13, month = 3, year = 2015;
            double amount = 100.50;

            Console.WriteLine("£££££RECEIPT£££££");
            Console.WriteLine("Date of Purchase: {0}-{1}-{2}", day, (((month < 10) ? "0" : "") + month), year);
            Console.WriteLine("Amount Sold For: {0:0.00}", amount);
            Console.WriteLine("Thank You For Your Custom.");
        }

    }
}
