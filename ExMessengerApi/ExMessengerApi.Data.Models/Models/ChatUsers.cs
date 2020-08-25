using System;

namespace ExMessengerApi.Data.Models.Models
{
    public class ChatUsers
    {
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }
        
        // navigational properties
        public virtual Chat Chat { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}