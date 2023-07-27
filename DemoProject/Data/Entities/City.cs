using System.ComponentModel.DataAnnotations;

namespace DemoProject.Data.Entities;

public class City : BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public ICollection<UserDescription> UserDescriptions { get; set; }

    public ICollection<Service> Services { get; set; }

    public ICollection<District> Districts { get; set; }
}