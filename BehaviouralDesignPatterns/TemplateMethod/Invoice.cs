using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Customers;

namespace TemplateMethod
{
    public class Invoice
    {
        public Customer Customer { get; set; }
        public IEnumerable<InvoiceLine> Lines { get; set; }
        public double TotalPrice => Lines.Sum(s => s.Quantity * s.UnitPrice);
        public double DiscountPercentage { get; set; }
        public double NetPrice => TotalPrice + Taxes - TotalPrice * DiscountPercentage;
        public double Taxes { get; set; }
    }
}
