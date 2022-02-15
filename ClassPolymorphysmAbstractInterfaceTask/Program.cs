using System;

namespace ClassPolymorphysmAbstractInterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            //Car car = new Car("Nissan", "Blue", 2500, 55, 5, 41);
            //Bycle bycle = new Bycle("Honda", "Yellow", 123);
            //car.ShowInfo();
            //bycle.ShowInfo();

            //car.Drive(8);
            //bycle.Drive(8);

            //car.ShowInfo();
            //bycle.ShowInfo();
            #endregion
            #region Task-2
            Employee employee1 = new Employee("Vusal", 2500, "Developer");
            Employee employee2 = new Employee("Vusal", 2500, "Developer");
            Employee employee3 = new Employee("Ayxan", 2500, "Developer");
            Employee employee4 = new Employee("Vusal", 2500, "Developer");
            Employee employee5 = new Employee("Vusal", 2500, "Developer");
            Employee employee6 = new Employee("Vusal", 2500, "Developer");
            Employee employee7 = new Employee("Vusal", 2500, "Developer");
            Employee employee8 = new Employee("Vusal", 2500, "Developer");

            Company company = new Company("CodeAcademy", 9);
            Company.AddEmployee(employee1);
            Company.AddEmployee(employee2);
            Company.AddEmployee(employee3);
            Company.AddEmployee(employee4);
            Company.AddEmployee(employee5);
            Company.AddEmployee(employee6);
            Company.AddEmployee(employee7);
            Company.AddEmployee(employee8);

            Employee[] employees = company.GetEmployees();
            foreach (var item in employees)
            {
                Console.WriteLine(item.Info());
            }

            Company.RemoveEployees(ref employees, 8);

            foreach (var item in employees)
            {
                Console.WriteLine(item.Info());
            }

            Employee empl = Company.SerachEmployee("Ayxan");
            Console.Write($"No - {empl.No}\nName - {empl.FullName}\nSalary - {empl.Salary}\nPosition {empl.Position}\n");
            #endregion
            #region Task-3
            //Console.WriteLine("ad ve soyadini daxil et: ");
            //string fullname = Console.ReadLine();
            //Console.WriteLine("Email daxil et: ");
            //string email = Console.ReadLine();
            //Console.WriteLine("sifre daxil et: ");
            //string password = Console.ReadLine();


            //User user = new User(fullname, email, password);
            //user.ShowInfo();
            #endregion
        }
    }
}
