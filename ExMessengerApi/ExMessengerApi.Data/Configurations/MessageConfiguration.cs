using ExMessengerApi.Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExMessengerApi.Data.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.Property(p => p.ChatId)
                .HasColumnName("chat_id");
            
            builder.Property(p => p.UserId)
                .HasColumnName("user_id");
            
            builder.Property(p => p.MessageText)
                .HasColumnName("message_text");
            
            builder.Property(p => p.DateSent)
                .HasColumnName("date_sent");

            builder.ToTable("messages");
        }
    }
}