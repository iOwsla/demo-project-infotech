using System.ComponentModel.DataAnnotations;

namespace DemoProject.Data.Entities;

public class UserRole : BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public ICollection<User> Users { get; set; }
}