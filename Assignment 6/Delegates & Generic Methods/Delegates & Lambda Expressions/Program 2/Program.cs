using System;

namespace Assignment {
    public delegate double Maximum(double a,double b);
    class Program {
        public static void CallAnonymousMethod() {
            bool positive = new Func<int, bool>(delegate (int int32) { return int32 > 0; })(1);
            new Action<bool>(delegate (bool value) { Console.WriteLine(value); })(positive);
        }
        public static void CallLambda() {
            bool positive = new Func<int, bool>(int32 => int32 > 0)(1);
            new Action<bool>(value => Console.WriteLine(value))(positive);
        }
        static void Main(string[] args) {
            Console.WriteLine("\n1) Anonymous Function and Action Delegate Without Lamda Expression : ");
            Program.CallAnonymousMethod();

            Console.WriteLine("\n2) Anonymous Function and Action Delegate With Lamda Expression : ");
            Program.CallLambda();

            //delegate with lamda expression
            Console.WriteLine("\n3) Delegate with Lamda Expression : ");
            Maximum parse = (double x, double y) => (x > y ? x : y);
            Console.WriteLine("\nMax(11.5,1.1) = {0}",parse(11.5,1.1)); 

            Console.WriteLine("\n4) Function Delegate with Lamda Expression : ");
            Func<double, double, double> f =(x, y) => { if (x > y) return x;  return y; };
            double a1 = f(40, 30);
            Console.WriteLine("\nMax(40,30) = {0}",a1);
            
            Console.WriteLine("\n5) Function Delegate with Diffrent Lamda Expressions : ");

            double a2;
            Func<double, double, double> f2;
            f2 = (x, y) => {
            if (x > y)
                return x;
            return y;    
            };

            a2 = f2(10, 20);
            Console.WriteLine("\nMax(40,30) = {0}",a2);

            f2 = (x, y) => {
            if (x < y)
                return x;
            return y;    
            };

            a2 = f2(40, 20);
            Console.WriteLine("Min(40,30) = {0}\n",a2);                       
        }
    }
}