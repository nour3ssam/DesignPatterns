using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Interfaces
{
    internal interface IBankFactory
    {
        public IBank GetBank(string BankCode);
        public IPaymentCard GetPaymentCard(string CardNumber);

    }
}
