using System;
using MainEmployee;

namespace MainProgram {
    class Program {
        public static void Main(string[] args) {
            String e1_fname = "Gaurav";
            String e1_lname = "Ahir";
            String e1_joiningDate = "01-01-01";
            String e1_retirementDate = "01-01-20";
            double e1_monthlySalary = 50000.00;
            double e1_housingRentAllowance = 20000.00;
            double e1_dearnessAllowance = 700.00;
            double e1_providentFund = 12000.00;

            PermanentEmployee e1 = new PermanentEmployee(e1_fname, e1_lname, e1_joiningDate, e1_retirementDate, e1_monthlySalary, e1_housingRentAllowance, e1_dearnessAllowance, e1_providentFund);
            Console.WriteLine($"Employee 1 Details : \n{e1}");
            e1.GiveRaise(10.0);
            Console.WriteLine($"\nEmployee 1 Details after 10% raise : \n{e1}");

            String e2_fname = "Ankit";
            String e2_lname = "Ahir";
            String e2_joiningDate = "24-05-03";
            String e2_retirementDate = "24-05-23";
            double e2_monthlySalary = 48000.00;
            double e2_housingRentAllowance = 18000.00;
            double e2_dearnessAllowance = 600.00;
            double e2_providentFund = 11000.00;

            PermanentEmployee e2 = new PermanentEmployee(e2_fname, e2_lname, e2_joiningDate, e2_retirementDate, e2_monthlySalary, e2_housingRentAllowance, e2_dearnessAllowance, e2_providentFund);
            Console.WriteLine($"\nEmployee 2 Details : \n{e2}");
            e2.GiveRaise(10.0);
            Console.WriteLine($"\nEmployee 2 Details after 10% raise : \n{e2}");
        }
    }
}