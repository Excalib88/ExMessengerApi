using ExMessengerApi.Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExMessengerApi.Data.Configurations
{
    public class ChatUsersConfiguration : IEntityTypeConfiguration<ChatUsers>
    {
        public void Configure(EntityTypeBuilder<ChatUsers> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}