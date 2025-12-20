using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy02
{
    internal class PercentageDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount)
        {
            return amount - (amount * 10 / 100);
        }
    }
}
