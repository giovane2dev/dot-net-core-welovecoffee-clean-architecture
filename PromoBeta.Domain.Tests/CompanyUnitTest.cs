using FluentAssertions;
using PromoBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PromoBeta.Domain.Tests
{
    public class CompanyUnitTest
    {
        [Fact(DisplayName = "create a first company with valid parameters")]
        public void CreateCompany_WithValidParameters()
        {
            Action action = () => new Company(id:1, taxIdNumber:"8983", name:"DEXS", description:"");

            action.Should().NotThrow<PromoBeta.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "creates a first company with invalid parameters")]
        public void CreateCompany_WithoutValidParameters()
        {
            Action action = () => new Company(id: 1, taxIdNumber: "8983", name: String.Empty, description: "");

            action.Should().NotThrow<PromoBeta.Domain.Validation.DomainExceptionValidation>();
        }
    }
}
