using DemoProject.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace DemoProject.Models;

public class RequestModel : BaseModel
{
    [Required]
    [MaxLength(500)]
    public string Details { get; set; }

    [Required]
    public RequestStatus Status { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}