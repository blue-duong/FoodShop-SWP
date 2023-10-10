using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class User
    {
        public User()
        {
            ConversationChatters = new HashSet<ConversationChatter>();
            Feedbacks = new HashSet<Feedback>();
            Notifications = new HashSet<Notification>();
            Orders = new HashSet<Order>();
            Reports = new HashSet<Report>();
            Subscriptions = new HashSet<Subscription>();
            Tokens = new HashSet<Token>();
        }

        public string Email { get; set; } = null!;
        public bool? Enable { get; set; }
        public string Firrtname { get; set; } = null!;
        public bool Gender { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsLockout { get; set; }
        public byte[]? JoinAt { get; set; }
        public string Lastname { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? Role { get; set; }
        public DateTime? Timeout { get; set; }
        public long? Wallet { get; set; }
        public int? Wrongpasswordcount { get; set; }
        public int? CardId { get; set; }
        public int Id { get; set; }

        public virtual Cart? Card { get; set; }
        public virtual ICollection<ConversationChatter> ConversationChatters { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}
