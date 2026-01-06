using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class VisaCard : IPaymentCard
    {
        public string GetProvider()
        {
            return "This Operation From VisaCard";
        }
    }
}
