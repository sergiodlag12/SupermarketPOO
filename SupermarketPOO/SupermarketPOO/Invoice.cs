using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPOO
{
    public class Invoice : IPay
    {
        private List<Product> _products= null!;

        public Invoice()
        {
            Console.WriteLine("RECEIPT");
            Console.WriteLine("------------------------------------------------------");
        
        }

        public static void AddProduct(Product products)
        {
            Console.WriteLine(products);
        }

        public decimal ValueToPay()
        {
            decimal totalValues = 0;
            foreach (Product product in _products)
            {
                Console.WriteLine(product);
                //totalValues += product.ValueToPay();
            }
            return totalValues;
        }

        public override string ToString()
        {
            return $"{AddProduct}" +
                $"\n\t===========================" +
                $"\n\t{ValueToPay()}";
        }

       
    }
}
