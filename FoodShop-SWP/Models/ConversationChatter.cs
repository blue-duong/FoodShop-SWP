using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class ConversationChatter
    {
        public int Id { get; set; }
        public int? ConversationId { get; set; }
        public int? UserId { get; set; }

        public virtual Conversation? Conversation { get; set; }
        public virtual User? User { get; set; }
    }
}
