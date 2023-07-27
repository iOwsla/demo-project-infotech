using System.ComponentModel.DataAnnotations;

namespace DemoProject.Data.Entities;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}