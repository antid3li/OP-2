using System.Collections.Generic;

namespace InternetShop
{
    public class Admin : User
    {
        public Admin() : base()
        {
        }

        public Admin(int id, string name, string email) : base(id, name, email)
        {
        }

        public void AddProduct(List<Product> products, Product product)
        {
            products.Add(product);
        }

        public void EditProduct(Product product, string newName, decimal newPrice, int newStockQty)
        {
            product.Name = newName;
            product.Price = newPrice;
            product.StockQty = newStockQty;
        }

        public void DeleteProduct(List<Product> products, Product product)
        {
            products.Remove(product);
        }
    }
}