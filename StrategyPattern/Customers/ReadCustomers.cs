using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Customers
{
    public class ReadCustomers
    {
        public IEnumerable<Customer> customers;
        public ReadCustomers()
        {
            customers = new List<Customer>() {
                new Customer{Id =1,Name="Nour",CustomCatogery = Category.gold},
                 new Customer{Id =2,Name="Ali",CustomCatogery=Category.silver}
            };

        }
    }
}
