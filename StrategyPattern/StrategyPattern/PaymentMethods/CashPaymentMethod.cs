using System;

namespace StrategyPattern.PaymentMethods
{
    public class CashPaymentMethod : IPaymentMethod
    {
        public CashPaymentMethod()
        {
            Name = "Cash";
        }
        
        public string Name { get; private set; }
        public PaymentResult Process(PaymentRequestDetail request)
        {
            Console.WriteLine("Paying with Cash.");
            Console.WriteLine("Payment Details: " + request.Info);
            return null;
        }
    }
}