using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPolymorphysmAbstractInterfaceTask
{
    class Bycle:Vehicle
    {
        public Bycle(string brand, string color, double milage):base(brand,color,milage)
        {

        }
        public override void Drive(double km)
        {
            Milage += km;
        }
        public override void ShowInfo()
        {
            Console.WriteLine();
            base.ShowInfo();
            Console.WriteLine();
        }
    }
}
