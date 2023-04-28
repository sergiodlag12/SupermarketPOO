using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPOO
{
    public class Invoice : IPay
    {
       
        private string _products;

        public Invoice(string products)
        {
            Console.WriteLine("RECEIPT");
            Console.WriteLine("-------------------------------------");
            _products = products;
        }

        //public string AddProduct()
        //{

        //}
        
        public decimal ValueToPay()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
