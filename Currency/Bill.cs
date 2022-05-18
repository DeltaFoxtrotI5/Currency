using System;
using System.Collections.Generic;
using System.Text;

namespace Currency
{
    public class Bill : Currency
    {
        //properties
        public float Height;
        public float Width;
        public string Color;

        //Constructor
        public Bill(string name, string countryCode, float value, float height, float width, string color) : base(name, countryCode, value)
        {
            Height = height;
            Width = width;
            Color = color;
        }

        //Method
        public new void Describe()
        {
            Console.WriteLine("\n::::BILL:::");
            base.Describe();
            Console.WriteLine($"\tColor: {Color}\n\tDimensions: {Height} x {Width}");

        }










    }
}
