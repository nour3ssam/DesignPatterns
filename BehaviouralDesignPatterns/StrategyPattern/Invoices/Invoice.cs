using Strategy.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Invoices
{
    public class Invoice
    {
        public Customer Customer { get; set; }
        public IEnumerable<LineInvoice> lines { get; set; }
        public double TotalPrice => lines.Sum(s => s.Quantity * s.UnitPrice);
        public double DiscountPercentage { get; set; }
        public double NetPrice => TotalPrice - TotalPrice * DiscountPercentage;
        public double Taxes { get; set; }
    }
}
