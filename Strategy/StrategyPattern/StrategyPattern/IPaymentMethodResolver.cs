namespace StrategyPattern
{
    internal interface IPaymentMethodResolver
    {
        public IPaymentMethod Resolve(string name);
    }
}


