namespace TigerTix.Web.Models;
using Microsoft.EntityFrameworkCore;

// Model inherits from context so that it can manage db connections
public class DbModel : DbContext
{
    // Define the get and set for users
    public DbSet<LoginModel> Users { get; set; }
    // Set the db to sql lite and define the path to the db
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite(@"Data Source=" + Directory.GetCurrentDirectory() + "\\TigerTix.db");
}