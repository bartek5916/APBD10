using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

[Table("Shopping_Carts")]
public class Shopping_Carts
{ 
    [Column("FK_account")]
    public int ShoppingCartAccountId { get; set; }
    
    [Column("FK_product")]
    public int ShoppingCartProductId { get; set; }
    
    [Column("amount")]
    public int ShoppingCartAmount { get; set; }
}