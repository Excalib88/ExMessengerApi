using System.Collections.Generic;

namespace ExMessengerApi.Data.Models.Models
{
    public class Chat : BaseEntity
    {
        public string Title { get; set; }

        // navigational properties
        public virtual ICollection<Message> Messages { get; set; }
        public ICollection<ChatUsers> ChatUsers { get; set; }
    }
}