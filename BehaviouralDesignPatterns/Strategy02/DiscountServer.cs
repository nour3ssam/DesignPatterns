using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy02
{
    internal class DiscountService // context class
    {
        private readonly IDiscountStrategy discountStrategy;

        public DiscountService(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }
        public decimal GetFinalPrice(decimal amount)
        {
            return discountStrategy.ApplyDiscount(amount);
        }
    }
}
