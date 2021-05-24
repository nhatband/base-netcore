using Dapper;
using Ecommerce.Context;
using Ecommerce.DTO.Request;
using Ecommerce.Interface;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Service
{
    public class ProductService : IProductService
    {
        private readonly IEcommerceContext ecommerceContext;
        public ProductService(IEcommerceContext ecommerceContext)
        {
            this.ecommerceContext = ecommerceContext;
        }
        public async Task<string> AddProduct(AddProductRequest request) {
            using var db = ecommerceContext.ecommerce;
            var product = await db.ExecuteAsync("usp_Product_Add", new
            {
                Sku = request.Sku,
                Name = request.Name,
                Price = request.Price,
                CategoryId = request.CategoryId
            },commandType:CommandType.StoredProcedure);
          
                return "Add Success!";
        }
    }
}
