using economus_cpp.Models;
using System.ComponentModel.DataAnnotations;

namespace economus_cpp.ViewModels
{
    public class ExpenseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o campo Descrição")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o campo Tipo")]
        [Display(Name = "Tipo")]
        public ExpenseType Type { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o Valor")]
        [Display(Name = "Valor")]
        public decimal ExpenseAmount { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o Data")]
        [Display(Name = "Data")]
        public DateTime ExpenseDate { get; set; }
    }
}
