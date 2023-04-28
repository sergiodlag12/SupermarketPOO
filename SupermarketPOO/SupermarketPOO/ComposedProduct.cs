namespace SupermarketPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product>? Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal totalValues = 0;
            
            foreach (Product product in Products)
            {
                Console.WriteLine(product.Description);
                totalValues += product.ValueToPay();
            }
            decimal discountPer = (totalValues * 12) / 100;
            totalValues -= discountPer;
            return totalValues;
        }

        public override string ToString()
        {
            return $"  {Id}  {Description}" +
                $"\n\tProducts...: {Products}" +
                $"\n\tDiscount...: {$"{Discount:P2}", 14}" +
                $"\n\tValue......: {$"{ValueToPay():C2}", 14}";
        }
    }
}