using System.ComponentModel.DataAnnotations;

namespace ToDoList.Web.Models;

[DisplayColumn("Все задачи")]
public class MyTask
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Название задачи")]
    [Required]
    public string? Name { get; set; }

    [Display(Name = "Приоритет задачи")]
    [Required]
    public int ParentId { get; set; } = 0;

    public List<Priority>? Priorities { get; set; } 
}

