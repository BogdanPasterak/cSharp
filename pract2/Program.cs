using System;

namespace Practicals_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // needed to display the Euro sign
            // you also need to change the font in the console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int no = 100;

            do
            {
                Console.Write("\nChoise Question ( 1 - 7, 0 -> Quit) : ");
                ConsoleKeyInfo UserInput = Console.ReadKey();
                Console.WriteLine("\n");

                if (char.IsDigit(UserInput.KeyChar))
                {
                    no = int.Parse(UserInput.KeyChar.ToString());

                    if (no <= 5)
                    {
                        switch (no)
                        {
                            case 1: Q1(); break;
                            case 2: Q2(); break;
                            case 3: Q3(); break;
                            case 4: Q4(); break;
                            case 5: Q5(); break;
                        }

                    }
                }

            } while (no != 0);


        }

        private static void Q5()
        {
            byte math = 79;
            byte programming = 99;
            byte sql = 91;
            float avarage = (math + programming + sql) / 3f;

            Console.WriteLine("***Average Result Calculator***");
            Console.WriteLine("Math:\t\t{0}%", math);
            Console.WriteLine("Programming:\t{0}%", programming);
            Console.WriteLine("SQL Scripting:\t{0}%", sql);
            Console.WriteLine("Avarage:\t{0:0.00}%", avarage);
        }

        private static void Q4()
        {
            int weighs = 174;
            int stone = weighs / 14;
            int pounds = weighs % 14;

            Console.WriteLine("***Weight Converter***");
            Console.WriteLine("Weight in Pounds: {0} Lbs", weighs);
            Console.WriteLine("Weight in Stones and Pounds: {0} Stone and {1} Lbs", stone, pounds);
        }

        private static void Q3()
        {
            byte minutes = 25;
            byte hours = 2;
            int time = minutes + 60 * hours;

            Console.WriteLine("Flight time is {1} hours and {0} minutes.", minutes, hours);
            Console.WriteLine("Flight time in minutes is {0} minutes.", time);
        }

        private static void Q2()
        {
            float rate = 7.8f;
            byte hours = 12;
            float wage = rate * hours;

            Console.WriteLine("***Wage Calculator***");
            Console.WriteLine("Hourly Rate: €{0:0.00}", rate);
            Console.WriteLine("Hours Worked: {0}", hours);
            Console.WriteLine("Weekly Wage (Before Tax): €{0:0.00}", wage);
        }

        private static void Q1()
        {

            ushort stock = 3245;
            byte recives = 120;

            Console.WriteLine("***Book Delivery***");
            Console.WriteLine("Books in Stock Prior to Delivery: {0}", stock);
            Console.WriteLine("Books Received: {0}", recives);
            stock += recives;
            Console.WriteLine("Total Books In Stock: {0}", stock);
        }
    }
}
