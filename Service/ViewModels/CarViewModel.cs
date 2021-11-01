using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModels
{
    public class CarViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Paciente")]
        [Required(ErrorMessage = "Preencha o campo Nome do Paciente")]
        [MinLength(10, ErrorMessage = "O Campo precisa ter mais que 10 caracteres")]
        [MaxLength(100, ErrorMessage = "O Campo precisa ter menos que 100 caracteres")]
        public string Name { get; set; }

    }
}
