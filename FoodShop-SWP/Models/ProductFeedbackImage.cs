using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class ProductFeedbackImage
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public int? FeedbackId { get; set; }

        public virtual Feedback? Feedback { get; set; }
    }
}
