using System.ComponentModel.DataAnnotations;

namespace DemoProject.Models;

public class ServiceCategoryModel : BaseModel
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
}