using ExMessengerApi.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace ExMessengerApi.Data.Contexts
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
            // modelBuilder.ApplyConfiguration(new MoviesConfiguration());
            // modelBuilder.ApplyConfiguration(new CopiesConfiguration());
            // modelBuilder.ApplyConfiguration(new ActorsConfiguration());
            // modelBuilder.ApplyConfiguration(new StarringConfiguration());
            // modelBuilder.ApplyConfiguration(new RentalsConfiguration());
            // modelBuilder.ApplyConfiguration(new ClientsConfiguration());
            // modelBuilder.ApplyConfiguration(new EmployeesConfiguration());
        }
    }
}