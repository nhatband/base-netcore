using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Context
{
    public interface IEcommerceContext
    {
        IDbConnection ecommerce { get; }
    }
}
