using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class FeedbackReply
    {
        public string? Contebt { get; set; }
        public int? FeedbackId { get; set; }
        public int Id { get; set; }

        public virtual Feedback? Feedback { get; set; }
    }
}
