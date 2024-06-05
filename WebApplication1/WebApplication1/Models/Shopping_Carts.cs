using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication1.Models;

[Table("Shopping_Carts")]
[PrimaryKey(nameof(AccountId), nameof(ProductId))]
public class Shopping_Carts
{ 
    [Column("FK_account")]
    public int AccountId { get; set; }

    public virtual Accounts Accounts { get; set; } = null!;
    
    [Column("FK_product")]
    public int ProductId { get; set; }
    
    public virtual Products Products { get; set; } = null!;
    
    [Column("amount")]
    public int ShoppingCartAmount { get; set; }
}