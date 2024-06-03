using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Accounts")]
public class Accounts
{ 
    [Key]
    [Column("PK_account")]
    public int AccountId { get; set; }
    
    [Column("first_name")]
    [MaxLength(50)]
    public string AccountFirstName { get; set; }
    
    [Column("last_name")]
    [MaxLength(50)]
    public string AccountLastName { get; set; }
    
    [Column("email")]
    [MaxLength(80)]
    public string AccountEmail { get; set; }
    
    [Column("phone")]
    [MaxLength(9)]
    public string? AccountPhone { get; set; }
    
    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
    public virtual ICollection<Shopping_Carts> ShoppingCarts { get; set; } = new List<Shopping_Carts>();
}