namespace TigerTix.Web.Models;
using Microsoft.EntityFrameworkCore;

public class DbModel : DbContext
{
    public DbSet<LoginViewModel> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite(@"Data Source=" + Directory.GetCurrentDirectory() + "\\TigerTix.db");
}