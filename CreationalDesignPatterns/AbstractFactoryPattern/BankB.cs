using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class BankB : IBank
    {
        public string Withdraw()
        {
            return "handling with BankB";
        }
    }
}
