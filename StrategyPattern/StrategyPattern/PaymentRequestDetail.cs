using System.Runtime.InteropServices;

namespace StrategyPattern
{
    public class PaymentRequestDetail
    {
        public PaymentRequestDetail(string information)
        {
            Info = information;
        }
        public string Info { get; private set; }
    }
}