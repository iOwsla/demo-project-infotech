using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoProject.Data.Entities;

public class Service : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [MaxLength(500)]
    public string Description { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    [Required]
    [ForeignKey("Category")]
    public int CategoryId { get; set; }

    [Required]
    [ForeignKey("Provider")]
    public int ProviderId { get; set; }

    [Required]
    [ForeignKey("City")]
    public int CityId { get; set; }

    [Required]
    [ForeignKey("District")]
    public int DistrictId { get; set; }

    public ServiceCategory Category { get; set; }

    public User Provider { get; set; }

    public City City { get; set; }

    public District District { get; set; }

    public ICollection<Request> Requests { get; set; }
}