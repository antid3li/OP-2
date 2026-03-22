using System;

namespace InternetShop
{
    public class Demo
    {
        public void RunDemo()
        {
            User user = new User(1, "Іван", "ivan@gmail.com");

            Product product1 = new Product(1, "Ноутбук", 25000, 5);
            Product product2 = new Product(2, "Миша", 800, 10);

            user.Cart.AddProduct(product1);
            user.Cart.AddProduct(product2);

            decimal total = user.Cart.GetTotal();

            Order order = new Order(1, DateTime.Now, total);
            order.Status = OrderStatus.New;

            user.Orders.Add(order);

            string message =
                "Користувач: " + user.Name + "\n" +
                "Email: " + user.Email + "\n\n" +
                "Товарів у кошику: " + user.Cart.Products.Count + "\n" +
                "Загальна сума: " + total + " грн\n\n" +
                "Номер замовлення: " + order.Id + "\n" +
                "Дата: " + order.Date + "\n" +
                "Статус: " + order.Status;

            Console.WriteLine(message);
        }
    }
}