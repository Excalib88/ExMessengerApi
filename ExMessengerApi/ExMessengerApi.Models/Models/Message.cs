using System;

namespace ExMessengerApi.Models.Models
{
    public class Message
    {
        // this property to be changed to identity type
        public string UserId { get; set; }
        
        public int ChatId { get; set; }
        public string MessageText { get; set; }
        public DateTime DateSent { get; set; }
        
        // navigational property
        // instance of Chat
    }
}