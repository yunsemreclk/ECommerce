namespace Server.Data;

using Microsoft.EntityFrameworkCore;
using Server.Entity;

public class ECContext : DbContext
{
    public ECContext(DbContextOptions<ECContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
}