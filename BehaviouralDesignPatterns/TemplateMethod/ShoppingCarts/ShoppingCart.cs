using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Customers;

namespace TemplateMethod.ShoppingCarts
{
    internal abstract class ShoppingCart
    {
        List<InvoiceLine> invoiceLines = new List<InvoiceLine>();
        public void AddItem(int itemid, int quentity, double unitprice)
        {
            invoiceLines.Add(new InvoiceLine()
            {
                ItemId = itemid,
                Quantity = quentity,
                UnitPrice = unitprice
            });
        }
        public void Checkout(Customer customer)
        {
            var invoice = new Invoice()
            {
                Customer = customer,
                Lines = invoiceLines
            };
            ApplyTaxes(invoice);
            ApplyDicount(invoice);
            ProcessPayment(invoice);
        }

        private void ApplyTaxes(Invoice invoice)
        {
            invoice.Taxes = invoice.TotalPrice * 0.15;
        }

        public abstract void ApplyDicount(Invoice invoice); // template method
                                                           
        private void ProcessPayment(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Invoice created for Customer " +   
                $"{invoice.Customer.Name} with net price: {invoice.NetPrice} ");
            Console.ForegroundColor = ConsoleColor.White;

        }


    }
}
