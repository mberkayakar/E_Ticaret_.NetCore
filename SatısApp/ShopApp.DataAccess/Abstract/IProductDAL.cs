using SatisApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
    public interface IProductDAL:IRepository<Product>
    {

        IEnumerable<Product> GetPopularProducts();


   





    }
}
