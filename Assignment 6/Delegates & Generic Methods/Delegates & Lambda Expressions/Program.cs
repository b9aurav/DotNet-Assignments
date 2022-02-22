﻿using System;
using System.Diagnostics;

namespace Assignment_6 {
    class Account {
        string name;
        string acc_no;
        int balance;

        internal Account(string name, string acc_no, int balance) {
            this.name = name;
            this.acc_no = acc_no;
            this.balance = balance;
        }


        internal string Name {
            get { return name; }
            set { name = value; }
        }

        internal string Acc_No {
            get { return acc_no; }
            set { acc_no = value; }
        }

        internal int Balance {
            get { return balance; }
            set { balance = value; }
        }

        public override string ToString() {
            return $"Account Details :\n\nAccount Holder Name : {name}\nAccount Number : {acc_no}\nBalance : {balance}\n";
        }

        internal string CallLambda() {
            return new Func<int, string>(int32 => {
                if (int32 < 0) return "Your are Overdrawn";
                else if (int32 < 10) return "Your Balance is Low";
                else if (int32 < 100) return "Spend Carefully";
                else return $"Your balance is {int32}";
            })(Balance);
        }
    }
    class Program {
        static void Main(string[] args) {
            Account my_acc1 = new Account("Gaurav", "562186281", 25000);
            Console.WriteLine(my_acc1);

            Console.WriteLine("Call to Anonymous Method :\n");
            Console.WriteLine(new Func<int, string>(delegate (int int32) {
                if (int32 < 0) return "Your are Overdrawn";
                else if (int32 < 10) return "Your Balance is Low";
                else if (int32 < 100) return "Spend Carefully";
                else return $"Your balance is {int32}";
            })(my_acc1.Balance));

            Account my_acc2 = new Account("Anand", "456216238", 50);
            Console.WriteLine(my_acc2);

            Console.WriteLine("Call to Lambda Expressions :\n");
            Console.WriteLine(my_acc2.CallLambda());

            //b)
            //Lambda Expressions
            double x = 10, y = 20;
            Func<double, double, bool> compare = (x, y) => x > y;
            Console.WriteLine(compare(x, y));

            //c)
            //Function Delegate with Lambda Expression
            {
                Console.WriteLine("\nFunction Delegate with Lambda Expression - >\n");
                Func<double, double, double> f = (x, y) => { if (x > y) return x; else return y; };

                Console.WriteLine("Enter value 1 - >");
                double var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter value 2 - >");
                double var2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{f(var1, var2)} is greater in {var1} and {var2}");
            }

            //Action Delegate with Lambda Expression
            {
                Console.WriteLine("\nAction Delegate with Lambda Expression - >\n");
                Action<double, double> f = (x, y) => { 
                   if (x > y)
                        Console.WriteLine($"{x} is greater than {y}"); 
                   else 
                        Console.WriteLine($"{y} is greater than {x}"); 
                };

               f(10, 20);
            }

            //d)
            {
                double z;
                Func<double, double, double> f;

                f = (x, y) => { if (x > y) return x; return y; };
                z = f(100, 200);
                // z holds 200.
                Console.WriteLine($"{z} is greater in 100 and 200");

                f = (x, y) => { if (x < y) return x; return y; };
                z = f(100, 200);
                // z holds 100. 
                Console.WriteLine($"{z} is less in 100 and 200");
            }
        }
    }
}