using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public DateTime? CreateAt { get; set; }
        public string? ImageUrl { get; set; }
        public bool? Read { get; set; }
        public string? RedirectUrl { get; set; }
        public string? Title { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
