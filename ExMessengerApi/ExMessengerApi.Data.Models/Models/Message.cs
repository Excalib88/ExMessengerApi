using System;

namespace ExMessengerApi.Data.Models.Models
{
    public class Message
    {
        public Guid UserId { get; set; }

        public Guid ChatId { get; set; }
        public string MessageText { get; set; }
        public DateTime DateSent { get; set; }

        // navigational properties
        public virtual ApplicationUser User { get; set; }
        public virtual Chat Chat { get; set; }
    }
}