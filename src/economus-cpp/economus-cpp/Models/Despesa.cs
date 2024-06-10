using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace economus_cpp.Models
{
    [Table("Despesa")]
    public class Despesa
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Tipo")]
        public TipoDespesa tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Valor")]
        public double valor { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Data")]
        public DateOnly data { get; set; }

        [Display(Name = "Usuario")]
        public int usuarioId { get; set; }

        [ForeignKey("usuarioId")]
        public Usuario usuario { get; set; }
    }
    public enum TipoDespesa
    {
        Fixo,
        Variável
    }
}
