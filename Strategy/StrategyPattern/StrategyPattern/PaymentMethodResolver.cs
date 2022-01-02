using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    internal class PaymentMethodResolver : IPaymentMethodResolver
    {
        private readonly IEnumerable<IPaymentMethod> _paymentMethods;

        public PaymentMethodResolver() 
        { 
            // Blank
        }

        public PaymentMethodResolver(IEnumerable<IPaymentMethod> paymentMethods)
        {
            _paymentMethods = paymentMethods;
        }
        
        // We can include some extension methods such as Register to add new payment methods.
        
        public IPaymentMethod Resolve(string name)
        {
            IPaymentMethod paymentMethod = _paymentMethods.FirstOrDefault(method => method.Name == name);

            if (paymentMethod == null)
            {
                throw new ArgumentException("Payment Method Not Found.");
            }
            
            return paymentMethod;
        }
    }
}