using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.DiscountStrategy
{
    public class SilverDiscountStrategy : IDiscountStrategy
    {
        public double CalcDiscount(double TotalPrice)
        {
            if (TotalPrice >= 10000)
            {
                return 0.2;
            }
            else
            {
                return 0;
            }
        }
    }
}
