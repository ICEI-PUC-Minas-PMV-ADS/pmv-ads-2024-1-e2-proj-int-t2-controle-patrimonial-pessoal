using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace economus_cpp.Models
{
    [Table("Receipts")]
    public class Receipt
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
        public ReceiptType Type { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Valor")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ReceiptAmount { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        [Display(Name = "Data")]
        public DateOnly ReceiptDate { get; set; }
    }
    public enum ReceiptType
    {
        Fixo,
        Variável
    }
}
