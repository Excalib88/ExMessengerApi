using ExMessengerApi.Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExMessengerApi.Data.Configurations
{
    public class ChatUsersConfiguration : IEntityTypeConfiguration<ChatUsers>
    {
        public void Configure(EntityTypeBuilder<ChatUsers> builder)
        {
            builder.HasKey(key => new {key.ChatId, key.UserId});

            builder.HasOne(p => p.Chat)
                .WithMany(chat => chat.ChatUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(k => k.ChatId);

            builder.HasOne(u => u.User)
                .WithMany(c => c.ChatUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(k => k.UserId);

            builder.Property(p => p.ChatId)
                .HasColumnName("chat_id");

            builder.Property(p => p.UserId)
                .HasColumnName("user_id");

            builder.ToTable("chat_users");
        }
    }
}