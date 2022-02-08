using System;

namespace MainEmployee {
    public class Employee {
        string _firstName;
        string _lastName;
        double _monthlySalary;

        public Employee(string firstName,string lastName,double monthlySalary) {
                _firstName = firstName;
                _lastName = lastName;
                _monthlySalary = monthlySalary;
        }

        public string FirstName {
            get{return  _firstName;}
            set{_firstName = value;}
        } 
        public string LastName {
            get{return _lastName;}
            set{_lastName = value;}
        } 

        public double MonthlySalary {
            get {
                return _monthlySalary;
            }
            set {
                _monthlySalary = value < 0 ? 0.0 : value;
            }
        } 

        public virtual void GiveRaise(double raise) {
            _monthlySalary = _monthlySalary + (_monthlySalary*raise/100);
        }

        public override string ToString() {
            return $"First Name : {_firstName}\nLast Name : {_lastName}\nSalary : {_monthlySalary*12}";
        }  
    }

    public class PermanentEmployee : Employee {
        double _housingRentAllowance;
        double _dearnessAllowance;
        double _providentFund;
        string _joiningDate;
        string _retirementDate;
        
        public PermanentEmployee(string firstName, string lastName, string joiningDate, string retirementDate, double monthlySalary, double housingRentAllowance, double dearnessAllowance, double providentFund) : base(firstName,lastName,monthlySalary) {
            this._housingRentAllowance = housingRentAllowance;
            this._dearnessAllowance = dearnessAllowance;
            this._providentFund = providentFund;
            this._joiningDate = joiningDate;
            this._retirementDate = retirementDate;
            this.MonthlySalary = this.MonthlySalary + _housingRentAllowance + _dearnessAllowance;
        }

        public double HRA {
            get => _housingRentAllowance;
        }

        public double DA {
            get => _dearnessAllowance;
        }

        public double PF {
            get => _providentFund;
        }
        
        public string JoiningDate {
            get => _joiningDate;
            set => _joiningDate=value;
        }

        public string RetirementDate {
            get => _retirementDate;
            set => _retirementDate=value;
        }
        
        public override void GiveRaise(double raise) {
            this.MonthlySalary = this.MonthlySalary + (this.MonthlySalary * raise) / 100 + _dearnessAllowance + _housingRentAllowance;
        }

        public override string ToString() {
            return $"{base.ToString()}\nJoining date: {_joiningDate}\nRetirement date:{_retirementDate}";
        }
    }
}