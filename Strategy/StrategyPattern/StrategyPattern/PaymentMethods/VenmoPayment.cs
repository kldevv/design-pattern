using System;

namespace StrategyPattern.PaymentMethods
{
    public class VenmoPaymentMethod : IPaymentMethod
    {

        public VenmoPaymentMethod()
        {
            Name = "Venmo";
        }
        public string Name { get; private set; }
        public PaymentResult Process(PaymentRequestDetail request)
        {
            Console.WriteLine("Paying with Venmo.");
            Console.WriteLine("Payment Details: " + request.Info);
            return null;
        }
    }
}