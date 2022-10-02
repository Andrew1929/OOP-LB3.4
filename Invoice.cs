using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB_3._4
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;
        private int price;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

        } 
        public void PriceCalculator()
        {

            Console.Write("Enter article : ");
            article = Console.ReadLine();
            Console.Write("Enter price : ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity : ");
            quantity  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------");
            double priceWithoutPDF = price * quantity;
            double priceWithtPDF = priceWithoutPDF / 100 * 20 + priceWithoutPDF;
            Console.WriteLine($"Account #{account}; Custome - {customer} ; Provider - {provider}");
            Console.WriteLine($"You buy {article} for the sum :{priceWithtPDF} grn (price with PDF)\n" +
                $"Price without PDF : {priceWithoutPDF} grn");
        }
    }
}
