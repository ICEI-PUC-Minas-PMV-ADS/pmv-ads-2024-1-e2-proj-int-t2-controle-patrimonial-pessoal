using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace economus_cpp.Models
{
    [Table("Meta")]
    public class Meta
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Valor Aplicado")]
        public double valorAplicado { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Valor Final")]
        public double valorFinal { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Data Final")]
        public DateOnly DeadLine { get; set; }

        [Display(Name = "Usuario")]
        public int usuarioId { get; set; }

        [ForeignKey("usuarioId")]
        public Usuario usuario { get; set; }
    }
}
