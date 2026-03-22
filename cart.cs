using System.Collections.Generic;

namespace InternetShop
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }

        public Cart()
        {
            Products = new List<Product>();
        }

        public Cart(int id)
        {
            Id = id;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            Products.Remove(product);
        }

        public decimal GetTotal()
        {
            decimal total = 0;

            foreach (var product in Products)
            {
                total += product.Price;
            }

            return total;
        }
    }
}