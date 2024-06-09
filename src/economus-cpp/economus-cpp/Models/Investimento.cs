using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace economus_cpp.Models
{
    [Table("Investimento")]
    public class Investimento
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Tipo")]
        public TipoRendimento tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Valor Investido")]
        public double valorInvestido { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Taxa de Rendimento")]
        public double taxaRendimento { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Taxa de Imposto")]
        public double taxaImposto { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Data Final")]
        public DateOnly dataFinal { get; set; }

        [Display(Name = "Usuario")]
        public int usuarioId { get; set; }

        [ForeignKey("usuarioId")]
        public Usuario usuario { get; set; }
    }
    public enum TipoRendimento
    {
        Fixo,
        Variável
    }
}
