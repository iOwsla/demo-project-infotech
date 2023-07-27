using System.ComponentModel.DataAnnotations;

namespace DemoProject.Data.Entities;

public class ServiceCategory : BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public ICollection<Service> Services { get; set; }
}