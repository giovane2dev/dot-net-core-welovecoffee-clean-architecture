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
            Action action = () => new Product(1, "Banana", "Banana (kg)", 5, String.Empty);

            action.Should().NotThrow<Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "create a second product with invalid parameters")]
        public void CreateProductWithInvalidParameters()
        {
            Action action = () => new Product(name: "Uva", "Uva verde sem caroço", 0 ,String.Empty);

            action.Should().NotThrow<Validation.DomainExceptionValidation>();
        }
    }
}