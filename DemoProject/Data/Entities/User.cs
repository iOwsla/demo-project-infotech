using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoProject.Data.Entities;

public class User : BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string UserName { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    public byte[] PasswordHash { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    [Required]
    [ForeignKey("Role")]
    public int RoleId { get; set; }

    public UserRole Role { get; set; }

    public UserDescription Description { get; set; }

    public ICollection<Service> Services { get; set; }

    public ICollection<Request> Requests { get; set; }
}