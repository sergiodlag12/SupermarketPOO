namespace SupermarketPOO
{
    public class VariablePriceProduct : Product
    {
        public string? Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            decimal initialValue = (Price * (decimal)Quantity);
            decimal variableValue = (initialValue * (decimal)Tax) + initialValue;
            return variableValue;
        }

        public override string ToString()
        {
            return $"  {Id}\t{Description}" +
                $"\n\tMeasurement: {Measurement}" +
                $"\n\tQuantity...: {$"{Quantity:N2}",14}" +
                $"\n\tPrice......: {$"{Price:C2}",14}" +
                $"\n\tTax........: {$"{Tax:P2}",14}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",14}";
        }

    }
}