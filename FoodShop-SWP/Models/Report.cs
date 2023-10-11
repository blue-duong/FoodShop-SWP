using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Report
    {
        public string? Action { get; set; }
        public string? ReasonSpecified { get; set; }
        public string? ReasonType { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public int Id { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
        public virtual User? User { get; set; }
    }
}
