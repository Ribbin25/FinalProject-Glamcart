using System.ComponentModel.DataAnnotations;

namespace GlamCart.Models;

public class Review
{
    public int ReviewID { get; set; }

    [Required]
    public int ProductID { get; set; }

    [Range(1, 5)]
    [Required]
    public int Rating { get; set; }

    [Required]
    public string Comment { get; set; } = string.Empty;

  
    public Product Product { get; set; } = null!;
}
