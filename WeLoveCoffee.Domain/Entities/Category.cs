using System.Collections.Generic;
using WeLoveCoffee.Domain.Validation;

namespace WeLoveCoffee.Domain.Entities
{
    public sealed class Category : Base
    {
        private int v1;
        private string v2;

        // from anemic model for rich model

        // applies the single responsibility principle enriching the class and setting
        // specific attributes, validanting your properties in construnction.

        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public ICollection<Product> Products { get; set; }

        public Category(string name, string description)
        {
            this.Validate(name, description);
        }

        public Category(int id, string name, string description)
        {
            DomainExceptionValidation.Check(id <= 0,
                "Código da Categoria inválido!");

            Id = id;

            this.Validate(name, description);
        }

        private void Validate(string name, string description)
        {
            DomainExceptionValidation.Check(string.IsNullOrEmpty(name),
                "Informe o Nome da Categoria!");

            Name = name;
            Description = description;
            Active = true;
        }
    }
}