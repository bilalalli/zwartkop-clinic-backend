using System.ComponentModel.DataAnnotations;
namespace Server.Models;

public class Pizza
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    public string? Sauce { get; set; }
    
    public string? Topping { get; set; }

    public bool IsVegan { get; set; }
}