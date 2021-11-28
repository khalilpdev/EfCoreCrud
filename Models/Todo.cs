using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EfCoreCrud.Models;

[Table("Todo")]
public class Todo
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Title { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool Done { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} - Título: {Title} - Concluído: {Done}";
    }
}
