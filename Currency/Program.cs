using System;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Coin Dime = new Coin("Dime", "US", 0.10f, 17.92f, "Curpor-Nickel");
            Dime.Describe();

            Coin Euro = new Coin("Euro", "EU", 1.00f, 23.28f, "Gold and Silver");
            Euro.Describe();

            Bill Canadian5 = new Bill("Five Dollar Canadian Bill", "CA", 5.00f, 70, 150, "Light Blue");
            Canadian5.Describe();

            Mastercard Business = new Mastercard("Business Acount Card", "US", 35000000000, 9.3f, 14, "Huskies", 5789985355481509, 954);
            Business.Describe();









        }
    }
}
