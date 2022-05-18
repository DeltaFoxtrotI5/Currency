using System;
using System.Collections.Generic;
using System.Text;

namespace Currency
{
    public class Mastercard : Currency
    {
        //properties
        public float Height;
        public float Width;
        public string Design;
        public float CardNumber;
        public float SVN;
        //Constructor
        public Mastercard(string name, string countryCode, float value, float height, float width, string design, float cardNumber, float sVN) : base(name, countryCode, value)
        {
            Height = height;
            Width = width;
            Design = design;
            CardNumber = cardNumber;
            SVN = sVN;

        }

        //Method
        public new void Describe()
        {
            Console.WriteLine("\n::::Debit::::");
            base.Describe();
            Console.WriteLine($"\tCard Number: {CardNumber} \n\tSeurity Number: {SVN} \n\tDesign: {Design}\n\tDimensions: {Height}x{Width}");


        }





























    }
}
