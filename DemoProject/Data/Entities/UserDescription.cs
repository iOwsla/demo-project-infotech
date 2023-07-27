using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoProject.Data.Entities;

public class UserDescription
{
    [Key]
    [ForeignKey("User")]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string FullName { get; set; }

    [Required]
    [MaxLength(20)]
    public string Phone { get; set; }

    [Required]
    [MaxLength(200)]
    public string Address { get; set; }

    [Required]
    [ForeignKey("City")]
    public int CityId { get; set; }

    [Required]
    [ForeignKey("District")]
    public int DistrictId { get; set; }

    public User User { get; set; }

    public City City { get; set; }

    public District District { get; set; }
}