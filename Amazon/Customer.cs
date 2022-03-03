using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public void Promote()
        {   

            var calculator = new RateCalculator();
            var rating = calculator.Claculate(this);

            //var rating = CalculateRating(excludeOrders: true);
            //if (rating == 0)
            //    Console.WriteLine("Promoted to Level 1");
            //else
            //    Console.WriteLine("Promoted to Level 2");

            Console.WriteLine("Promote logic changed.");
        }


        //protected int CalculateRating(bool excludeOrders)
        //{
        //    return 0;

        //}



    }
}
