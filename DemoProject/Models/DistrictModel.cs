using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DemoProject.Data.Entities;

namespace DemoProject.Models;

public class DistrictModel : BaseEntity
{

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
}