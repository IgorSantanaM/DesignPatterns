using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategies
{
    public class PayPalStrategy(string email, string password) : IPaymentStrategy
    {
        private string _email = email;
        private string _password = password;
        
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ${amount} with paypal");
        }
    }
}
