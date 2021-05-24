using FluentValidation;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.DTO.Request
{
    public class AddProductRequest
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }
    }
    public class AddProductValidator : AbstractValidator<AddProductRequest>
    {
        public AddProductValidator()
        {
            RuleFor(m => m.Sku).NotEmpty();
            RuleFor(m => m.Price).NotEmpty();
        }
    }
    internal class AddProductRequestExample : IMultipleExamplesProvider<AddProductRequest>
    {
        public IEnumerable<SwaggerExample<AddProductRequest>> GetExamples()
        {
            yield return SwaggerExample.Create("eg1.Thêm mới product", new AddProductRequest
            {
                Sku = "PS",
                Name = "pepsi",
                Price = 10000,
                CategoryId = 1
            });
        }
    }
}
