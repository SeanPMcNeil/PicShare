#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace PicShare.Models;
public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) : base(options) { }
     // Database Tables here, change Model Name in <Model> and give name
     // Can have multiple model/table pairs listed here
     // public DbSet<Model> Models { get; set; }
}