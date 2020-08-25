using ExMessengerApi.Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExMessengerApi.Data.Configurations
{
    public class ChatConfiguration: IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.HasKey(key => key.Id)
                .HasName("chat_id");

            builder.HasMany(mes => mes.Messages)
                .WithOne(mes => mes.Chat);

            builder.Property(p => p.Title)
                .HasColumnName("title");

            builder.ToTable("chats");
        }
    }
}