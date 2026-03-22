using System;

namespace InternetShop
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }

        public OrderStatus Status { get; set; }

        public Order()
        {
            Status = OrderStatus.New;
        }

        public Order(int id, DateTime date, decimal totalAmount)
        {
            Id = id;
            Date = date;
            TotalAmount = totalAmount;
            Status = OrderStatus.New;
        }
    }
}