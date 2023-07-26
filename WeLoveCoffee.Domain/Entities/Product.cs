using WeLoveCoffee.Domain.Validation;

namespace WeLoveCoffee.Domain.Entities
{
    public sealed class Product : Base
    {
        // from anemic model for rich model

        // applies the single responsibility principle enriching the class and setting
        // specific attributes, validanting your properties in construnction.

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string Image { get; private set; }
        public int CategoryId { get; private set; }
        public int CompanyId { get; private set; }
        public bool Active { get; private set; }
        public Category Category { get; set; }
        public Company Company { get; set; }

        public Product(string name, string description, decimal price, string image)
        {
            this.Validate(name, description, price, image);
        }

        public Product(int id, string name, string description, decimal price, string image)
        {
            DomainExceptionValidation.Check(id <= 0,
                "Código do Produto inválido!");

            Id = id;
            
            this.Validate(name, description,price,image);            
        }

        private void Validate(string name, string description, decimal price, string image)
        {
            DomainExceptionValidation.Check(string.IsNullOrEmpty(name),
               "Informe o Nome do Produto!");

            DomainExceptionValidation.Check(price <= 0,
                 "Valor do Produto inválido!");
            
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            Active = true;
        }
    }
}