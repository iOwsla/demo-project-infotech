using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoProject.Data.Entities;

public class District : BaseEntity
{

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required]
    [ForeignKey("City")]
    public int CityId { get; set; }

    public City City { get; set; }

    public ICollection<UserDescription> UserDescriptions { get; set; }

    public ICollection<Service> Services { get; set; }
}