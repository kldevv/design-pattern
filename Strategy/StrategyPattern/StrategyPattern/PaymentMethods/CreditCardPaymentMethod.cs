using System;

namespace StrategyPattern.PaymentMethods
{
    public class CreditCardPaymentMethod : IPaymentMethod
    {
        public CreditCardPaymentMethod()
        {
            Name = "CreditCard";
        }
        public string Name { get; }
        public PaymentResult Process(PaymentRequestDetail request)
        {
            Console.WriteLine("Paying with CreditCard.");
            Console.WriteLine("Payment Details: " + request.Info);
            return null;
        }
    }
}