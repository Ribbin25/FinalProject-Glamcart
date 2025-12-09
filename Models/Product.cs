using System.ComponentModel.DataAnnotations;

namespace GlamCart.Models;

public class Product
{
    public int ProductID { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Name { get; set; } = string.Empty;

    [Display(Name = "Image URL")]
    public string ImageURL { get; set; } = string.Empty;

    [Display(Name = "Product Description")]
    [Required]
    public string ProductDescription { get; set; } = string.Empty;

    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be more than 0")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
}
