﻿using PromoBeta.Domain.Validation;

namespace PromoBeta.Domain.Entities
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
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, decimal price, string image)
        {
            this.ValidateDomain(name, description, price, image);
        }

        public Product(int id, string name, string description, decimal price, string image)
        {
            DomainExceptionValidation.Check(id < 0,
                "Código do Produto inválido!");

            Id = id;

            this.ValidateDomain(name, description, price, image);
        }

        public void Update(string name, string description, decimal price, string image)
        {
            this.ValidateDomain(name, description, price, image);
        }

        private void ValidateDomain(string name, string description, decimal price, string image)
        {
            DomainExceptionValidation.Check(string.IsNullOrEmpty(name),
                "Informe o Nome do Produto!");

            DomainExceptionValidation.Check(price == 0,
                "Informe o Valor do Produto!");

            Name = name;
            Description = description;
            Price = price;
            Image = image;
        }
    }
}