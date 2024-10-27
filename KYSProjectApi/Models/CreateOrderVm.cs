using System.ComponentModel.DataAnnotations;

namespace KYSProjectApi.Models;

public class CreateOrderVm
{
    public ICollection<CreateOrderProductsVm> Products { get; set; }

    [Required(ErrorMessage = "Shipper code is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Shipper code must be a valid value.")]
    public int ShipperCode { get; set; }

    [Required(ErrorMessage = "User email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address format.")]
    public string UserEmail { get; set; }
}