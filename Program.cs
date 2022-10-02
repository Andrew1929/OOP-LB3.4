using System;

namespace OOP_LB_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(3432, "Andriy Rachenko", "Andriy Artemenko");
            invoice.PriceCalculator();
            Console.ReadKey();
        }
    }
}
