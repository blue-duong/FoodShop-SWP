using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartProducts = new HashSet<CartProduct>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }

        public virtual ICollection<CartProduct> CartProducts { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
