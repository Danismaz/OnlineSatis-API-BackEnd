using System.ComponentModel.DataAnnotations;
using Entities.Entites.Abctract;

namespace Entities.Concrete;

public class Shipper : BaseEntity
{
    [Key]
    public int ShipperCode { get; set; }
    [Required]
    [MaxLength(50)]
    [MinLength(2)]
    public string ShipperName { get; set; }
    [Required]
    public string DeliveryTime { get; set; }
    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal Price { get; set; }

    // Bir kargo firması birçok ürünü taşıyabilir
    public ICollection<Product> Products { get; set; }
    // Ürünün birçok Satis kaydı olabilir
    public ICollection<Order> Orders { get; set; }
}