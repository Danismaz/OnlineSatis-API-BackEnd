using System.ComponentModel.DataAnnotations;
using Entities.Entites.Abctract;

namespace Entities.Concrete;

public class Category : BaseEntity
{
    [Key]
    public Int64 CategoryCode { get; set; }
    [Required]
    public string CategoryName { get; set; }
    [Required]
    public string CategoryDescription { get; set; }
}