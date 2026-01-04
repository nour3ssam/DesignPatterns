using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy02
{
    internal interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal amount);
    }
}
