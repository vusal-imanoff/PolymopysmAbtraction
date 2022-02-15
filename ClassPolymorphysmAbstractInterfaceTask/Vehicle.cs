using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPolymorphysmAbstractInterfaceTask
{
    abstract class Vehicle
    {
        public string Brand;
        public string Color;
        public double Milage;
        public Vehicle(string brand,string color,double milage)
        {
            Brand = brand;
            Color = color;
            Milage = milage;

        }
        
        
        public virtual void ShowInfo()
        {
            Console.WriteLine($" Brand- {Brand} \n Color- {Color} \n Distance- {Milage}"); 
        }
        public abstract void Drive(double km);
    }
}
