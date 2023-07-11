using System;
using Xunit;
using FluentAssertions;
using PromoBeta.Domain;
using PromoBeta.Domain.Entities;


namespace PromoBeta.Domain.Tests
{
    public class ProductUnitTest
    {
        [Fact(DisplayName = "create a first product with valid parameters")]
        public void CreateProduct_WithValidParameters()
        {
            Action action = () => new Product(id:1, name:"Banana", description:"Banana (kg)", price:5, image:String.Empty);

            action.Should().NotThrow<Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "create a second product with invalid parameters")]
        public void CreateProductWithInvalidParameters()
        {
            Action action = () => new Product(id: 1, name: "Banana", description: "Banana (kg)", price: 0, image: String.Empty);

            action.Should().NotThrow<Validation.DomainExceptionValidation>();
        }
    }
}