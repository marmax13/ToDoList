using System.ComponentModel.DataAnnotations;

namespace ToDoList.Web.Models;

public class Priority
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Заголовок")]
    public string? Title { get; set; }

    [DataType(DataType.MultilineText)]
    [Required]
    [Display(Name = "Текст статьи")]
    public string? Text { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Дата последнего обновления")]
    [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
    public DateTime LastUpdate { get; set; }

    [Required]
    public int MyTaskId { get; set; }
    public virtual MyTask? MyTask { get; set; }
}

