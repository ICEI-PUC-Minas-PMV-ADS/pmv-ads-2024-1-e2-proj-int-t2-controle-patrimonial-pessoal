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
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,}$", ErrorMessage = "A {0} deve conter pelo menos uma letra minúscula, uma letra maiúscula, um número e um caractere especial.")]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "A senha e a senha de confirmação não coincidem.")]
        [Display(Name = "Confirmar Senha:")]
        public string ConfirmPassword { get; set; }
    }
}
