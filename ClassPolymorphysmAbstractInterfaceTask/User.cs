using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPolymorphysmAbstractInterfaceTask
{
    class User:IAccount
    {
        public string FullName;
        public string Email;
        private string _password;
        public User(string fullname,string email, string password)
        {
            FullName = fullname;
            Email = email;
            Password = password;

        }
        public string Password 
        {
            get
            {
                return _password;
            }
            set
            {
                while (!PasswordChecker(value))
                {
                    Console.WriteLine("duzgun parol daxil et...");
                   value= Console.ReadLine();
                }
                _password = value;
            }
        }
        public bool PasswordChecker(string password)
        {
            if(password.Length>=8)
            {
                bool checkUpper = false;
                bool checkLower = false;
                bool CheckDigit = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if(char.IsDigit(password[i]))
                    {
                        CheckDigit = true;
                    }
                    else if(char.IsLower(password[i]))
                    {
                        checkLower = true;
                    }
                    else if(char.IsUpper(password[i]))
                    {
                        checkUpper = true;
                    }

                }
                if(checkUpper&&checkLower&&CheckDigit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Adi- {FullName}\n Soyadi- {Email}");
        }
    }
}
