using System;
using System.Collections.Generic;
using StrategyPattern.PaymentMethods;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Register some payment methods.
            var paymentMethods = new List<IPaymentMethod>()
            {
                new CashPaymentMethod(),
                new VenmoPaymentMethod(),
                new CreditCardPaymentMethod(),
            };
            PaymentMethodResolver paymentMethodResolver = new PaymentMethodResolver(paymentMethods);
            
            // Incoming payment request.
            var paymentRequests = new List<PaymentRequest>()
            {
                new PaymentRequest(
                    "Cash", 
                    new PaymentRequestDetail("Bob pay with $100.")
                ),
                new PaymentRequest(
                    "Venmo", 
                    new PaymentRequestDetail("Alice pay with venmo account alice123.")
                ),
                new PaymentRequest(
                    "CreditCard",
                    new PaymentRequestDetail("Tom pay with credit card issued by Citi.")
                ),
                // Intentionally created not found payment method
                new PaymentRequest(
                    "DebitCard",
                    new PaymentRequestDetail("Jason pay with debit card.")
                )
            };

            var paymentResults = new List<PaymentResult>();
            foreach (var paymentRequest in paymentRequests)
            {
                paymentResults.Add(paymentMethodResolver.Resolve(paymentRequest.PaymentMethod)
                    .Process(paymentRequest.Detail));
            }
        }
    }
}