namespace InternetShop
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQty { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, decimal price, int stockQty)
        {
            Id = id;
            Name = name;
            Price = price;
            StockQty = stockQty;
        }
    }
}