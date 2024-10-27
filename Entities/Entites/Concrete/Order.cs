using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Entites.Abctract;
using Entities.Entites.Concrete;

namespace Entities.Concrete;

public class Order : BaseEntity
{
    [Key]
    public Int64 OrderCode { get; set; }
    [Required]
    public DateTime OrderDate { get; set; }

    public int ShipperCode { get; set; }
    public Int64 UserCode { get; set; }
    
    
    [ForeignKey("UserCode")] // UserCode'un Foreign Key olduğunu belirtiyoruz
    public User User { get; set; }
    [ForeignKey("ShipperCode")] // ShipperCode'un Foreign Key olduğunu belirtiyoruz
    public Shipper Shipper { get; set; }
}