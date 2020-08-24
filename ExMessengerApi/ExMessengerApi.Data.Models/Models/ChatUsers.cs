using System;

namespace ExMessengerApi.Data.Models.Models
{
    public class ChatUsers
    {
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }
        
        // navigational properties
        // enum users - from identity
        // enum chats
    }
}