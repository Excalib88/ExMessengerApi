using System;

namespace ExMessengerApi.Data.Models.Models
{
    public class BaseEntity: IEntity
    {
        public Guid Id { get; set; }
    }
}