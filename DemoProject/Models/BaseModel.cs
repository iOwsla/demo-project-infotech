using System.ComponentModel.DataAnnotations;

namespace DemoProject.Models;

public class BaseModel
{
    [Key]
    public int Id { get; set; }
}