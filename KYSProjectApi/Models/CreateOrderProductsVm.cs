using System.ComponentModel.DataAnnotations;

namespace KYSProjectApi.Models;

public class CreateOrderProductsVm
{
    [Required(ErrorMessage = "Product Code is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "Product Code must be a positive integer.")]
    public Int64 ProductCode { get; set; }

    [Required(ErrorMessage = "Quantity is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive integer.")]
    public int Quantity { get; set; }
}