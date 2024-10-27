using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

    //  foreign key
    public Int64 OrderCode { get; set; }
    public Int64 ProductCode { get; set; }

    // Navigation property for the Order
    [ForeignKey("OrderCode")]
    public Order Order { get; set; }
    [ForeignKey("ProductCode")]
    public Product Products { get; set; }
}