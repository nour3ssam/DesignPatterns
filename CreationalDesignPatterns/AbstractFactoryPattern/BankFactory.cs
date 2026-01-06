using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class BankFactory : IBankFactory
    {
        public IBank GetBank(string BankCode)
        {
            if (string.IsNullOrWhiteSpace(BankCode))
                throw new ArgumentException("BankCode is required");
            if (BankCode == "123")
            {
                return new BankA();
            }
            else 
            {
                return new BankB();
            }
            
           
        }

        public IPaymentCard GetPaymentCard(string CardNumber)
        {
            if (string.IsNullOrWhiteSpace(CardNumber))
                throw new ArgumentException("CardNumber is required");
            if (CardNumber == "123")
            {
                return new VisaCard();
            }
            else
            {
                return new MasterCard();
            }
         
        }
    }
}
