using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Subscription
    {
        public int Id { get; set; }
        public DateTime? SubscriptionTime { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
