using System;
using System.Collections.Generic;
using System.Text;

namespace Currency
{
    public abstract class Currency  //base or parent class
    {
        //Properties

        public string Name;
        public string CountryCode; //US, CA, MX
        public float Value;

        //Constructor
        public Currency()
        {
            Console.WriteLine("Currency Created!");
        }

        public Currency(string name, string countryCode, float value)
        {
            Name = name;
            CountryCode = countryCode;
            Value = value;
        }
        //Method
        public void Describe()
        {
            Console.WriteLine("\nDescription for " + Name);
            Console.WriteLine("\tCounty Code:" + CountryCode);
            Console.WriteLine("\tValue:" + Value);
        }




    }
}
