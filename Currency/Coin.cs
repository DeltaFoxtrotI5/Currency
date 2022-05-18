using System;
using System.Collections.Generic;
using System.Text;

namespace Currency
{
    public class Coin : Currency //Coin=Derived Class = Child OF the base or parent class
    {
        //properties
        public float Diameter;
        public string Alloys;

        //Constructor

        public Coin(string name,string countryCode,float value,float diameter,string alloys) : base(name, countryCode, value)
        {
            Diameter = diameter;
            Alloys = alloys;
        }

        //Method

        public new void Describe()
        {
            Console.WriteLine("\n::::COIN::::");
            base.Describe();
            Console.WriteLine($"\tDiameter:{Diameter}\n\tAlloys: {Alloys}");



        }


























    }
}
