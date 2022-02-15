using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPolymorphysmAbstractInterfaceTask
{
    class Company
    {
        private string _name;
       // public int Limit;
        //public  Employee[] Employess;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                while (true)
                {
                    bool checkUpper = false;
                    bool checksymbol = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if(char.IsUpper(value[i]) && i==0)
                        {
                            checkUpper = true;
                            break;
                        }
                        else if(char.IsSymbol(value[i]))
                        {
                            checksymbol = true;
                            break;
                        }
                    }
                    if (checksymbol && checkUpper)
                    {
                        _name = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter correct Email");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        public static int Limit
        {
            get;
            set;
        }
        public Company(string name,int limit)
        {
            _name = name;
            Limit = limit;
        }
        

       public static Employee[] Employees = new Employee[0];
        public Employee[] GetEmployees()
        {
            return Employees;
        }
        public static bool FreeVacation()
        {
            if(Employees.Length<Limit)
            {
                return true;

            }
            return false;
        }
        public static void AddEmployee(Employee worker)
        {
            if (FreeVacation())
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = worker;
            }
            else
            {
                Console.WriteLine("no vacation");
            }
        }
        public static Employee SerachEmployee(string search)
        {
            foreach (var item in Employees)
            {
                if(item.FullName==search)
                { 
                    return item;
                }
            }
            return new Employee("Not found such employee",0, "Not found such employee");
        }
        public static void RemoveEployees(ref Employee[] employees, int no)
        {
            Employee[] arr = new Employee[Employees.Length - 1];
            for (int i = 0; i < Employees.Length; i++)
            {
                if(Employees[i].No==no)
                {
                    for (int j = 0; j < i; j++)
                    {
                        arr[j] = Employees[j];
                    }

                }
                else
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr[k] = Employees[k+1];
                        
                    }
                }
                employees = arr;
            }
        }
    }
}
