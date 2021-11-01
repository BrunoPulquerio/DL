using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModels
{
    public class PatientViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Preencha o campo Nome do Paciente")]
        [MinLength(10, ErrorMessage = "O Campo precisa ter mais que 10 caracteres")]
        [MaxLength(100, ErrorMessage = "O Campo precisa ter menos que 100 caracteres")]
        public string Name { get; set; }

        [Display(Name = "CPF do Cliente")]
        [Required(ErrorMessage = "Preencha o campo CPF do Paciente")]
        [MaxLength(11, ErrorMessage = "O Campo precisa ter menos que 11 caracteres")]
        public string CPF { get; set; }
    }
}
