using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace economus_cpp.Models
{
    [Table("Expenses")]
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Tipo")]
        public ExpenseType Type { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Valor")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ExpenseAmount { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Data")]
        public DateTime ExpenseDate { get; set; }
    }

    public enum ExpenseType
    {
        Fixo,
        Variável
    }
}
