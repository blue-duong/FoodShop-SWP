using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class MessageImage
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public int? MessageId { get; set; }

        public virtual Message? Message { get; set; }
    }
}
