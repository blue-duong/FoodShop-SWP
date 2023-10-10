using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Conversation
    {
        public Conversation()
        {
            ConversationChatters = new HashSet<ConversationChatter>();
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }

        public virtual ICollection<ConversationChatter> ConversationChatters { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
