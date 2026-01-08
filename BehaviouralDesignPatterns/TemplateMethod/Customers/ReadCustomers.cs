using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Customers
{
    internal class ReadCustomers
    {
        public IEnumerable<Customer> Customers;
        public ReadCustomers()
        {
            Customers = new List<Customer>() {
                new Customer{Id =1,Name="Nour",CustomCatogery = Category.gold},
                 new Customer{Id =2,Name="Ali",CustomCatogery=Category.silver}
            };

        }
    }
}
