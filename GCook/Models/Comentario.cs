using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GCook.Models;

[Table("Comentario")]
public class Comentario
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "A Receita é obrigatória")]
    public int ReceitaId { get; set; }
    [ForeignKey("ReceitaId")]
    public Receita Receita { get; set; }
    
    [Required(ErrorMessage = "O Usuário é obrigatório")]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Display(Name = "Data do Comentário")]
    [Required(ErrorMessage = "A Data é obrigatório")]
    public DateTime DataComentario { get; set; }

    [StringLength(300)]
    [Display(Name = "Texto do Comentário")]
    [Required(ErrorMessage = "O Texto é obrigatório")]
    public string TextoComentario { get; set; }
}
