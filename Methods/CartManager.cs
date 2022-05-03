using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine($"{product.Name} added to cart! ");
        }
        public void Add2(string productName, string description, double price, int unitsOfStock) 
        {
            Console.WriteLine($"{productName} added to cart! ");
        }

    }
}
