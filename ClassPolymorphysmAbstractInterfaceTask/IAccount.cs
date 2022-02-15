using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPolymorphysmAbstractInterfaceTask
{
    interface IAccount
    {
        public bool PasswordChecker(string pasword);
        public void ShowInfo();
    }
}
