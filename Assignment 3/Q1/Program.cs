﻿using System;

namespace Assignment_3 {
    class Program {
        static void Main(string[] args) {
            int numerator, denom, whole_no;
            float float_quo;

            //Inputs
            Console.WriteLine("Enter Numerator : ");
            numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Denominator : ");
            denom = Convert.ToInt32(Console.ReadLine());
                
            //Int Division
            int int_quo = numerator / denom;
            int int_rem = numerator % denom;
            Console.WriteLine("Integer division result = {0} with a remainder {1}", int_quo, int_rem);

            //Float Division
            float_quo = (float)numerator / denom;
            Console.WriteLine("Floating point division result = {0}", float_quo);

            //Mixed Fraction
            if (numerator >= denom) {
                whole_no = numerator / denom;
                numerator = numerator % denom;
                Console.WriteLine("The result as a mixed fraction is {0} {1}/{2}", whole_no, numerator, denom);
            } else if (numerator % denom == 0) {
                whole_no = numerator / denom;
                Console.WriteLine("The result as a mixed fraction is {0}", whole_no);
            }
        }
    }
}