using System.ComponentModel.DataAnnotations;

namespace DemoProject.Models;

public class UserDescriptionModel
{
    [Required]
    [MaxLength(100)]
    public string FullName { get; set; }

    [Required]
    [MaxLength(20)]
    public string Phone { get; set; }

    [Required]
    [MaxLength(200)]
    public string Address { get; set; }

    public int CityId { get; set; }
    public string CityName { get; set; }

    public int DistrictId { get; set; }
    public string DistrictName { get; set; }
}