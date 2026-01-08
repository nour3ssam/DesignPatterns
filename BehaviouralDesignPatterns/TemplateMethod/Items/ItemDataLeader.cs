using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Items
{
    internal class ItemDataLeader
    {
        public IEnumerable<Item> GetItems()
        {
            return new[]
            {
               new Item (){Id=1,Name="laptop",UnitPrice=2000},
               new Item (){Id=2,Name="Keyboard",UnitPrice=1000},
               new Item (){Id=3,Name="Mouse",UnitPrice=500},
               new Item (){Id=4,Name="Hub",UnitPrice=200}
           };

        }
    }
}
