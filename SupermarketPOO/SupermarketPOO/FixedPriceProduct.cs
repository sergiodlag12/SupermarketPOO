namespace SupermarketPOO
{
    public class FixedPriceProduct : Product
    {
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue......:{$"{ValueToPay():C2}",15}";
        }

        public override decimal ValueToPay()
        {
            decimal fixedValue = Price * (decimal)Tax;
            return fixedValue + Price;
        }
    }
}