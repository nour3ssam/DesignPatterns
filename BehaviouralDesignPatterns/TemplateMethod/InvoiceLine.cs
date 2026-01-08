using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class InvoiceLine
    {
        public int ItemId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
