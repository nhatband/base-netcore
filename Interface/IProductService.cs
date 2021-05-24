using Ecommerce.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface IProductService
    {
        Task<string> AddProduct(AddProductRequest request);
    }
}
