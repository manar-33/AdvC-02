using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_02.ArrayList
{
    using System;
    using System.Collections;

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

    }

    public class ShoppingCart
    {
        private ArrayList items = new ArrayList();

        public void AddItem(Product product)
        {
            items.Add(product);
        }

        public void RemoveItem(Product product)
        {
            items.Remove(product);
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (Product product in items)
            {
                total += product.Price;
            }
            return total;
        }
    }

}
