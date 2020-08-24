using System;

namespace ExMessengerApi.Data.Models.Models
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}