using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoProject.Data.Entities;

public class Request : BaseEntity
{
    [Required]
    [ForeignKey("Service")]
    public int ServiceId { get; set; }

    [Required]
    [ForeignKey("Customer")]
    public int CustomerId { get; set; }

    [Required]
    [MaxLength(500)]
    public string Details { get; set; }

    [Required]
    public RequestStatus Status { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Service Service { get; set; }

    public User Customer { get; set; }
}