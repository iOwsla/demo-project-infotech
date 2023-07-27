using System.ComponentModel.DataAnnotations;

namespace DemoProject.Models;

public class ServiceModel  : BaseModel
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [MaxLength(500)]
    public string Description { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    public string ServiceCategory { get; set; }
}