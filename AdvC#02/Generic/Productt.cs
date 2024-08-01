using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_02.Generic
{

    public class Productt
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        

    }

    public class OrderItem
    {
        public Productt Product { get; set; }
        public int Quantity { get; set; }
    }

    public class Order
    {
        public int OrderId
        { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);

        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Product.Price * item.Quantity;
            }
            return total;
        }
    }
}
