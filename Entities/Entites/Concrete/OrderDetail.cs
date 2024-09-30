using System.ComponentModel.DataAnnotations;
using Entities.Entites.Abctract;

namespace Entities.Concrete;

public class OrderDetail : BaseEntity
{
    [Key]
    public Int64 OrderDetailCode { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public int Quantity { get; set; }

    public Order Order { get; set; }
    public ICollection<Product> Products { get; set; }
}