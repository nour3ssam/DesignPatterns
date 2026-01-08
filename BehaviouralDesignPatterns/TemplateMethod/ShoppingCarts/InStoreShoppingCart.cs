using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.ShoppingCarts
{
    internal class InStoreShoppingCart : ShoppingCart
    {
        public override void ApplyDicount(Invoice invoice)
        {
            if(invoice.TotalPrice > 10000)
            {
                invoice.DiscountPercentage = 0.05;
            }
        }
    }
}
