// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Amazon;

namespace AccessModifiers
{

    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            this.CalculateRating(excludeOrders: true); //so the CalculateRating does not exist anymore because we deleted it from the parent. Again, here is where encapsulation is broken. So try to avoid protexted unless you have a valid reason to use it.
        }
    }


    class Program
    {
        static void Main(string[] arg)
        {
            var customer = new Customer();
            //var rating = customer.CalculateRating();

            Amazon.RateCalculator calculator = new Amazon.RateCalculator();
        }




    }




}