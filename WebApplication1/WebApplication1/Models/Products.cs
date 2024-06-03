using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Products")]
public class Products
{
    [Key]
    [Column("PK_product")]
    public int ProductId { get; set; }
    
    [Column("name")]
    [MaxLength(100)]
    public string ProductName { get; set; }
    
    [Column("weight")]
    public double ProductWeight { get; set; }
    
    [Column("width")]
    public double ProductWidth { get; set; }
    
    [Column("height")]
    public double ProductHeight { get; set; }
    
    [Column("depth")]
    public double ProductDepth { get; set; }
    
    public virtual IEnumerable<Categories> Categories { get; set; } = new List<Categories>();
    
    public virtual ICollection<Accounts> Accounts { get; set; } = new List<Accounts>();
    public virtual ICollection<Shopping_Carts> ShoppingCarts { get; set; } = new List<Shopping_Carts>();
}