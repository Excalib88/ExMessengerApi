using System;

namespace ExMessengerApi.Data.Models.Models
{
    public class Message
    {
        // this property to be changed to identity type
        public Guid UserId { get; set; }
        
        public Guid ChatId { get; set; }
        public string MessageText { get; set; }
        public DateTime DateSent { get; set; }
        
        // navigational property
        // instance of Chat
    }
}