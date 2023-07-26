using System;
using Xunit;
using FluentAssertions;
using WeLoveCoffee.Domain.Entities;


namespace WeLoveCoffee.Domain.Tests
{
    public class CategoryUnitTest
    {
        [Fact(DisplayName = "create a first category with valid parameters")]
        public void CreateCategory_WithValidParameters()
        {
            Action action = () => new Category(id: 1, name: "Geral", description: "");

            action.Should().NotThrow<WeLoveCoffee.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "create a second category with invalid parameters")]
        public void CreateCategory_WithInvalidParameters()
        {
            Action action = () => new Category(id: 1, name: String.Empty, description: "");

            action.Should().NotThrow<WeLoveCoffee.Domain.Validation.DomainExceptionValidation>();
        }
    }
}