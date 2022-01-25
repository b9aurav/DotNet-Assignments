using System;

namespace Assignment_1 {
    class Program {
        static void Main(string[] args) {
            int user_input = 1;
            Console.WriteLine("---Decision Making---");
            Console.WriteLine("[1] If Statement");
            Console.WriteLine("[2] If Else Statement\n");

            Console.WriteLine("---Loops---");
            Console.WriteLine("[3] While Loop");
            Console.WriteLine("[4] Do While Loop");
            Console.WriteLine("[5] For Loop");
            Console.WriteLine("[6] Nested For Loop");
            Console.WriteLine("[7] Combined For Loop & If Statement\n");

            Console.WriteLine("---Numbers---");
            Console.WriteLine("[8] Explore Integer");
            Console.WriteLine("[9] Order of Operations in Integer");
            Console.WriteLine("[10] Integer Precisions and Limits");
            Console.WriteLine("[11] Explore Double");
            Console.WriteLine("[12] Explore Decimal");
            Console.WriteLine("[13] Challenge using Mathi.PI\n");

            Console.WriteLine("[14] Exit\n");

            while (true) {
                Console.WriteLine("Enter a choice : ");
                user_input = Convert.ToInt32(Console.ReadLine());
                switch (user_input) {
                    case 1:
                        if_statement();
                        break;
                    case 2:
                        if_else_statement();
                        break;
                    case 3:
                        while_loop();
                        break;
                    case 4:
                        do_while_loop();
                        break;
                    case 5:
                        for_loop();
                        break;
                    case 6:
                        nested_for_loop();
                        break;
                    case 7:
                        combined_for_if();
                        break;
                    case 8:
                        explore_integer();
                        break;
                    case 9:
                        order_in_integer();
                        break;
                    case 10:
                        limits_precisions_integer();
                        break;
                    case 11:
                        explore_double();
                        break;
                    case 12:
                        explore_decimal();
                        break;
                    case 13:
                        pi_challenge();
                        break;
                    case 14:
                        System.Environment.Exit(0);
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }

        public static void if_statement() {
            Console.WriteLine("If Statement\n");
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.\n");
        }

        public static void if_else_statement() {
            Console.WriteLine("\n\nIf Else Statement\n");
            int a = 5;
            int b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10\n");
            else
                Console.WriteLine("The answer is not greater than 10\n");
        }

        public static void while_loop() {
            Console.WriteLine("\n\nWhile Loop\n\n");
            int counter = 0;
            while (counter < 10) {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
        }

        public static void do_while_loop() {
            Console.WriteLine("\n\nDo While Loop\n");
            int counter = 0;
            do {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }

        public static void for_loop() {
            Console.WriteLine("\n\nFor Loop\n");
            for (int counter = 0; counter < 10; counter++) {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }
        }

        public static void nested_for_loop() {
            Console.WriteLine("\n\nNested For Loop\n");
            for (int row = 1; row < 11; row++) {
                for (char column = 'a'; column < 'k'; column++) {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }

        public static void combined_for_if() {
            Console.WriteLine("\n\nCombined For Loop and If statement\n");
            int sum = 0;
            for (int number = 1; number < 21; number++) {
                if (number % 3 == 0) {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }

        public static void explore_integer() {
            Console.WriteLine("\n\nPerofrming Basic Operations on Integers\n\n");
            int a = 18;
            int b = 6;
            Console.WriteLine("Addition : " + (a + b));
            Console.WriteLine("Subtraction : " + (a - b));
            Console.WriteLine("Multiplication : " + (a * b));
            Console.WriteLine("Division : " + (a / b));

        }

        public static void order_in_integer() {
            Console.WriteLine("\n\nOrder in Integers\n\n");
            int a = 5;
            int b = 4;
            int c = 2;
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine("(a + b) - 6 * c + (12 * 4) / 3 + 12 = {0}", d);
        }

        public static void limits_precisions_integer() {
            Console.WriteLine("\n\nLimits & Precisions in Integers\n\n");
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        public static void explore_double() {
            Console.WriteLine("\n\nDouble Datatype\n\n");
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        public static void explore_decimal() {
            Console.WriteLine("\n\nDecimal Datatype\n\n");
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        public static void pi_challenge() {
            Console.WriteLine("\n\nChallange using PI\n\n");
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Math.PI * 2.50 * 2.50 i.e., {0} + {1} + {2} = {3}", Math.PI, radius, radius, area);
        }
    }
}