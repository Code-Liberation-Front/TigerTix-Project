namespace TigerTix.Web.Models;
using Microsoft.EntityFrameworkCore;

// Model inherits from context so that it can manage db connections
public class DbModel : DbContext
{
    // Define separator for paths
    char separator = Path.DirectorySeparatorChar;
    // Define the get and set for users
    public DbSet<LoginModel> Users { get; set; }
    public DbSet<TicketModel> Tickets { get; set; }
    
    // Set the db to sql lite and define the path to the db
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite(@"Data Source=" + Directory.GetCurrentDirectory() + $"{separator}TigerTix.db");
}