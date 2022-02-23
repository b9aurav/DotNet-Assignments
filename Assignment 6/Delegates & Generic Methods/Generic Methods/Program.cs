using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment {
    class SelectionSort {
        static public void Sort<T>(IList<T> sortArray, Func<T,T,bool> comparision) {
            bool swapped = true;
            do {    
                int position , i , j;
                swapped = false;
                for(i=0; i < sortArray.Count - 1; i++) {
                    position = i;
                    for(j = i; j < sortArray.Count; j++) {
                        if(comparision(sortArray[position],sortArray[j])) {
                            position = j;
                        }
                    }
                    if(position!=i){
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i+1];
                        sortArray[i+1] = temp;
                        swapped=true; 
                    }
                }
            } while(swapped);
        }
    }
    public enum Designations {
        CEO=5,
        CFO=4,
        SDE=3,
        BA=2,
        PM=1
    }
    class Employee {
        int empid;
        public float salary;
        public string name;
        public Designations designation;
        public Employee(int EmpId, float Salary, string Name, Designations designation){
            this.empid = EmpId;
            this.salary = Salary;
            this.name = Name;
            this.designation = designation;
        }
        internal static bool CompareSalary(Employee e1, Employee e2) {
            return e1.salary < e2.salary;
        }

        internal static bool CompareNames(Employee e1, Employee e2) {
            if(e1.name.CompareTo(e2.name)== 0) {
                return true;
            } else {
                return false;
            }
        }

        internal static bool CompareDesignations(Employee e1, Employee e2) {
            return e1.designation < e2.designation;
        }  
    }
    
    public class TestGenericMethods {
        public static void Main(string[] args) {
            List<Employee> emplist = new List<Employee>(30); 
            emplist.Add(new Employee(01, 12000000, "Gaurav", Designations.CEO)); 
            emplist.Add(new Employee(03, 755000, "Tushar", Designations.BA));
            emplist.Add(new Employee(02, 900000, "Harsh", Designations.CFO));
            emplist.Add(new Employee(04, 20999,"Virat",Designations.PM));
            emplist.Add(new Employee(05, 78000,"Nikunj",Designations.SDE));
            emplist.Add(new Employee(06, 50000,"Rahil",Designations.PM));

            SelectionSort.Sort<Employee>(emplist, Employee.CompareDesignations);
            Console.WriteLine("Sorted by Designation : ");
            foreach(Employee e1 in emplist) {
                Console.WriteLine(e1.name + " : " + e1.designation);
            }

            SelectionSort.Sort<Employee>(emplist, Employee.CompareSalary);
            Console.WriteLine("\nSorted by Salary : ");
            foreach(Employee e1 in emplist) {
                Console.WriteLine(e1.name + " : " + e1.salary);
            }
        }
    }
}
