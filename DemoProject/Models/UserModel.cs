using System.ComponentModel.DataAnnotations;

namespace DemoProject.Models;

public class UserModel : BaseModel
{
    [Required]
    [MaxLength(50)]
    public string UserName { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    public UserDescriptionModel UserDescriptionModel { get; set; }
}