using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GCook.Models;

[Table("Ingrediente")]
public class Ingrediente
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Required(ErrorMessage = "O Nome é obrigatório")]
    public string Nome { get; set; }
}
