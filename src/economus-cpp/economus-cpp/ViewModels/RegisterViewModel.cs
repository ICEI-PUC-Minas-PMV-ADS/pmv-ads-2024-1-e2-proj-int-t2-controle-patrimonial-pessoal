using System.ComponentModel.DataAnnotations;

namespace economus_cpp.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [Display(Name = "Seu Nome:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [EmailAddress]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "A senha e a senha de confirmação não coincidem.")]
        [Display(Name = "Confirmar Senha:")]
        public string ConfirmPassword { get; set; }
    }
}
