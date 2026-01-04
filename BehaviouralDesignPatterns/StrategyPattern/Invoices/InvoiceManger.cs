using Strategy.Customers;
using Strategy.DiscountStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Invoices
{
    public class InvoiceManger // ال context class
    {
        private readonly IDiscountStrategy _discountStrategy;
        public InvoiceManger(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }
        public Invoice CreateInvoice(Customer customer, double price, int _Quantity)
        {

            var invoice = new Invoice()
            {
                Customer = customer,
                lines = new List<LineInvoice>()
                {
                    new LineInvoice(){UnitPrice = price,Quantity =_Quantity },
                },
            };
            invoice.DiscountPercentage =
                _discountStrategy.CalcDiscount(invoice.TotalPrice); // this is strategy
            return invoice;
        }
    }
}
