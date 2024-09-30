using System.ComponentModel.DataAnnotations;
using Entities.Entites.Abctract;

namespace Entities.Concrete;

public class Product : BaseEntity
{
    [Key]
    public Int64 ProductCode { get; set; }
    [Required]
    [MaxLength(50)]
    [MinLength(2)]
    public string ProductName { get; set; }
    [Required]
    public decimal ProductPrice { get; set; }
    [Required]
    public int Stock { get; set; }

    public Category Category { get; set; }
}