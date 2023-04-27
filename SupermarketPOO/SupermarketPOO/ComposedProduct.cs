using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SupermarketPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List Products { get; set; }

        public override decimal ValueToPay()
        {
            return ValueToPay();
        }

        public override string ToString()
        {
            return $"{ValueToPay()}";
        }
    }
}