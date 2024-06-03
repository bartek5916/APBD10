using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Categories")]
public class Categories
{   
    [Key]
    [Column("PK_category")]
    public int CategoryId { get; set; }
    
    [Column("name")]
    [MaxLength(100)]
    public string CategoryName { get; set; }
    
    public virtual IEnumerable<Products> IdProducts { get; set; } = new List<Products>();
}