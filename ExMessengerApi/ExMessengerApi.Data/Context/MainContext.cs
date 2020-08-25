using ExMessengerApi.Data.Configurations;
using ExMessengerApi.Data.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace ExMessengerApi.Data.Context
{
    public class MainContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatUsers> ChatUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;User Id=postgres;Password=postgres;Database=RentalCodeFirst;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new ChatUsersConfiguration());
            modelBuilder.ApplyConfiguration(new ChatConfiguration());
        }
    }
}