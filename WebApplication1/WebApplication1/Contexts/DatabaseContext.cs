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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Products>().HasData(new List<Products>
        {
            new Products
            {
                ProductId = 1,
                ProductName = "Ściągi na egzamin z APBD"
            }
        });
        
        modelBuilder.Entity<Role>().HasData(new List<Role>
        {
            new Role
            {
                RoleId = 1,
                RoleName = "User"
            }
        });

        modelBuilder.Entity<Accounts>().HasData(new List<Accounts>
        {
            new Accounts
            {
                AccountId = 1,
                AccountFirstName = "Jan",
                AccountLastName = "Kowalski",
                AccountEmail = "j@k.com",
                AccountPhone = "999888777",
                RoleId = 1
            }
        });
        
        modelBuilder.Entity<Shopping_Carts>().HasData(new List<Shopping_Carts>
        {
            new Shopping_Carts
            {
                ProductId = 1,
                AccountId = 1,
                ShoppingCartAmount = 10
            }
        });
    }
}