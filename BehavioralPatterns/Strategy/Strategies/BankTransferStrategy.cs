﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategies
{
    public class BankTransferStrategy(string bankName, string accountNumber) : IPaymentStrategy
    {
        private string _bankName = bankName;
        private string _accountNumber = accountNumber;

        public void Pay(decimal amount)
        {
            Console.WriteLine($"paid ${amount} with bank account");
        }
    }
}
