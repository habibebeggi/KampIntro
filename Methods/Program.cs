using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            double price = 12.95;
            string description = "Granny Smith";

            string[] fruits = new string[] { "Apple", "Orange", "Strawberry", "Cherry" };

            Product product1=new Product();
            product1.Name = "Apple";
            product1.Price = 12.95;
            product1.Description = "Granny Smith";

            Product product2=new Product();
            product2.Name = "Orange";
            product2.Price = 15.90;
            product2.Description = "Portugal Orange";

            Product [] products = new Product[] {product1, product2};

            // type-safe 
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine(" ************ ");
            }

            Console.WriteLine("------Methods------");

            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);

            cartManager.Add2("Cherry","Yellow Cherry",15,75);
            cartManager.Add2("Strawberry","Mugla Strawberry",17,85);
        }
    }
}
