using StrategyPattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ShoppingCart
    {
        private IPaymentStrategy? _strategy;

        public void SetStrategy(IPaymentStrategy? strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy(decimal amount)
        {
            _strategy?.Pay(amount);
        }
    }
}
