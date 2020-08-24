namespace ExMessengerApi.Models.Models
{
    public class ChatUsers
    {
        public int ChatId { get; set; }
        public string UserId { get; set; }
        
        // navigational properties
        // enum users - from identity
        // enum chats
    }
}