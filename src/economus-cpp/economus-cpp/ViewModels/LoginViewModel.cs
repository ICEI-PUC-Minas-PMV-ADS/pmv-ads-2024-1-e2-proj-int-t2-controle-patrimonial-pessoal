using System.ComponentModel.DataAnnotations;

namespace economus_cpp.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [Display(Name = "Senha")]
        public string Password { get; set; }
        [Display(Name = "Guardar Acesso")]
        public bool RememberMe { get; set; }
    }
}
