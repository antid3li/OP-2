using System.Collections.Generic;

namespace InternetShop
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Cart Cart { get; set; }
        public List<Order> Orders { get; set; }

        public User()
        {
            Cart = new Cart();
            Orders = new List<Order>();
        }

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            Cart = new Cart();
            Orders = new List<Order>();
        }
    }
}