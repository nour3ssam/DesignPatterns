using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Customers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category CustomCatogery { get; set; }

    }

    public enum Category
    {
        silver,
        gold
    }
}
