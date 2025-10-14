

using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email ou nome de Usuário", Prompt = "Informe seu email ou nome de usuário")]
        [Required(ErrorMessage = "O email ou nome de usuário é obrigatório")]
        public string Email { get; set; }

        [Display(Name = "Senha de acesso", Prompt = "**************")]
        [Required(ErrorMessage = "O senha  é obrigatória")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Manter Conectado?")]
        public bool Lembrar { get; set; } = false;

        public string UrlRetorno { get; set; }
    }
}