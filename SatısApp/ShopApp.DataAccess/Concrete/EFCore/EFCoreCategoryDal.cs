using SatisApp.Entities;
using ShopApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EFCore
{
    public class EFCoreCategoryDal :EFCoreGenericRepository<Category,SatisContext>,ICategoryDal

    {
     
    }
}
