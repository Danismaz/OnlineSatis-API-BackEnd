using System.ComponentModel.DataAnnotations;
using Entities.Entites.Abctract;
using Entities.Entites.Concrete;

namespace Entities.Concrete;

public class Order : BaseEntity
{
    [Key]
    public Int64 OrderCode { get; set; }
    [Required]
    public DateTime OrderDate { get; set; }

    public Shipper Shipper { get; set; }
    public User User { get; set; }
}