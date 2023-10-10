using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Feedback
    {
        public Feedback()
        {
            FeedbackReplies = new HashSet<FeedbackReply>();
        }

        public string? Description { get; set; }
        public int? OrderId { get; set; }
        public bool? Processed { get; set; }
        public int? Rate { get; set; }
        public string? Reason { get; set; }
        public DateTime? Time { get; set; }
        public string? Type { get; set; }
        public string? VideoUrl { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public int Id { get; set; }

        public virtual ProductFeedbackImage IdNavigation { get; set; } = null!;
        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<FeedbackReply> FeedbackReplies { get; set; }
    }
}
