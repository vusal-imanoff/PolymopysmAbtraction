using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPolymorphysmAbstractInterfaceTask
{
    class Employee
    {
        public static int no_employee;
        public int No;
        public string FullName;
        public double Salary;
        public string Position;

        public Employee(string fullname,double salary,string position)
        {
            FullName = fullname;
            Salary = salary;
            Position = position;
            No =  ++no_employee;
        }
        public string Info()
        {
            return $"No- {No} \n Fullname- {FullName} \n Salary- {Salary} \n Position {Position}";
        }
    }
}
