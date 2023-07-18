using System.Collections.Generic;
using PromoBeta.Domain.Validation;

namespace PromoBeta.Domain.Entities
{
    public sealed class Company : Base
    {
        // from anemic model for rich model

        // applies the single responsibility principle enriching the class and setting
        // specific attributes, validanting your properties in construnction.

        // equivalent to CNPJ in Brazil (EIN)
        public string TaxIdNumber { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public ICollection<Product> Products { get; set; }

        public Company(string taxIdNumber, string name, string description)
        {
            this.Validate(taxIdNumber, name, description);
        }

        public Company(int id, string taxIdNumber, string name, string description)
        {
            DomainExceptionValidation.Check(id <= 0,
                "Código da Empresa inválido!");

            Id = id;

            this.Validate(taxIdNumber, name, description);
        }

        public void Validate(string taxIdNumber, string name, string description)
        {
            DomainExceptionValidation.Check(string.IsNullOrEmpty(taxIdNumber),
               "Informe o CNPJ da Empresa!");

            DomainExceptionValidation.Check(string.IsNullOrEmpty(name),
                "Informe o Nome da Empresa!");

            TaxIdNumber = taxIdNumber;
            Name = name;
            Description = description;
            Active = true;
        }
    }
}
