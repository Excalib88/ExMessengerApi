using ExMessengerApi.Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExMessengerApi.Data.Configurations
{
    public class ChatConfiguration: IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}