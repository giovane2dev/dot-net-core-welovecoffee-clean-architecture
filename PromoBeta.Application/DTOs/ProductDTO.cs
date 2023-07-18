using PromoBeta.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PromoBeta.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Produto!")]
        [MinLength(5)]
        [MaxLength(150)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [MinLength(0)]
        [MaxLength(250)]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Valor do Produto inválido!")]
        [DisplayName("Valor R$")]
        public decimal Price { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public bool Active { get; set; }

        [DisplayName("Categoria")]
        public Category Category { get; set; }

        [DisplayName("Empresa")]
        public Company Company { get; set; }
    }
}