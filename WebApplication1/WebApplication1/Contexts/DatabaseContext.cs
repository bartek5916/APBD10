using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Contexts;

public class DatabaseContext : DbContext
{   
    public DbSet<Products> Products { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Accounts> Accounts { get; set; }
    public DbSet<Shopping_Carts> ShoppingCarts { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
}