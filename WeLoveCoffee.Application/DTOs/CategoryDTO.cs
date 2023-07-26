using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WeLoveCoffee.Application.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome da Categoria!")]
        [MinLength(5)]
        [MaxLength(150)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [MinLength(0)]
        [MaxLength(250)]
        [DisplayName("Descrição")]
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}