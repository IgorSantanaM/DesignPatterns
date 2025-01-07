using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategies
{
    public class CreditCardStrategy(
        string name,
        string cardNumber,
        string cvv,
        string dateOfExpiry) : IPaymentStrategy
    {

        private string _name = name;
        private string _cardNumber = cardNumber;
        private string _cvv = cvv;
        private string _dateOfExpiry = dateOfExpiry;

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ${amount} using credit card");
        }
    }
}
