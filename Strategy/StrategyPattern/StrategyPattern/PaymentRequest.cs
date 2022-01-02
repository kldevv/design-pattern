namespace StrategyPattern
{
    public class PaymentRequest
    {
        public PaymentRequest(string paymentMethod, PaymentRequestDetail detail)
        {
            PaymentMethod = paymentMethod;
            Detail = detail;
        }
        public string PaymentMethod { get; private set; }
        public PaymentRequestDetail Detail { get; private set; }
    }
}