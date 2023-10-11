using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Message
    {
        public Message()
        {
            MessageImages = new HashSet<MessageImage>();
        }

        public int Id { get; set; }
        public int? ConId { get; set; }
        public string? Content { get; set; }
        public DateTime? SendTime { get; set; }
        public int? SenderId { get; set; }
        public string? SenderImage { get; set; }
        public string? SenderType { get; set; }
        public string? Type { get; set; }
        public string? Video { get; set; }
        public int? ConversationId { get; set; }

        public virtual Conversation? Conversation { get; set; }
        public virtual ICollection<MessageImage> MessageImages { get; set; }
    }
}
