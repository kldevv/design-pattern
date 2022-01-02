namespace StrategyPattern
{
    public interface IPaymentMethod
    {
        // Name property can be made Enum.
        string Name { get; }
        PaymentResult Process(PaymentRequestDetail request);
    }
}