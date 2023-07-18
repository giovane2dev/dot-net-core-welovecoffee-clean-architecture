using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PromoBeta.Application.DTOs
{
    public class CompanyDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o CNPJ da Empresa!")]
        [MinLength(10)]
        [MaxLength(15)]
        [Display(Name = "CNPJ")]
        public string TaxIdNumber { get;  set; }

        [Required(ErrorMessage = "Informe o Nome da Empresa!")]
        [MinLength(5)]
        [MaxLength(150)]
        [Display(Name = "Nome")]
        public string Name { get;  set; }

        [MinLength(0)]
        [MaxLength(250)]
        [DisplayName("Descrição")]
        public string Description { get;  set; }
        public bool Active { get;  set; }
    }
}
