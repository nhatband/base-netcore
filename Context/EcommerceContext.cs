using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Context
{
    public class EcommerceContext : IEcommerceContext
    {
        private readonly IConfiguration configuration;
        public EcommerceContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IDbConnection ecommerce => new SqlConnection(configuration.GetConnectionString(nameof(ecommerce)));
    }
}
