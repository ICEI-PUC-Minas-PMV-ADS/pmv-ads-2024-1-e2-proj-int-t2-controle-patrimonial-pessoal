using economus_cpp.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace economus_cpp.ViewModels
{
    public class ReceiptViewModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Obrigatório inserir o campo Descrição")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o campo Tipo")]
        [Display(Name = "Tipo")]
        public ReceiptType Type { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o Valor")]
        [Display(Name = "Valor")]
        public decimal ReceiptAmount { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o Data")]
        [Display(Name = "Data")]
        public DateOnly ReceiptDate { get; set; }
    }
}
