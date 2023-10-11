using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Token
    {
        public int Id { get; set; }
        public DateTime? ComfirmedAt { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public int? Type { get; set; }
        public string? Value { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
