using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPolymorphysmAbstractInterfaceTask
{
    class Car:Vehicle
    {
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(string brand,string color,double milage,double fuelcapacity,double fuelfor1km,double currentfuel):base(brand,color,milage)
        {
            FuelCapacity = fuelcapacity;
            FuelFor1Km = fuelfor1km;
            CurrentFuel = currentfuel;
        }
        public override void Drive(double km)
        { 
            if(CurrentFuel>=(km*FuelFor1Km))
            {
                CurrentFuel -= (FuelFor1Km * km);
                Milage += km;
            }
            else
            {
                Console.WriteLine("Sizin bu yolu getmek ucun kifayer qeder benzininiz yoxdur");
            }
            
        }

        public override void ShowInfo()
        {

            base.ShowInfo();
            Console.WriteLine($" FuelCapacity- {FuelCapacity} \n FuelFor1Km- {FuelFor1Km} \n CurrentFuel- {CurrentFuel}"); 
        }
    }
}
