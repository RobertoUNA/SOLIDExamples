using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidExamples.DependencyInversionPrinciple
{
    internal class Store
    {
        public PaymentMethod paymentMethod;
        public Store(PaymentMethod paymentMethod) { this.paymentMethod = paymentMethod; }
        public void Buy()
        {
            paymentMethod.Pay();
        }
    }

    public interface PaymentMethod 
    {
        public void Pay();
    }

    public class CreditCard : PaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("The user paid by Credit Card");
        }
    }

    public class PayPal : PaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("The user paid by PayPal");
        }
    }

}
