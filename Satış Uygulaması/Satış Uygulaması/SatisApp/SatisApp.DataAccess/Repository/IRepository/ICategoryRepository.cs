using SatisApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisApp.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {

        void Update(Category category);





    }
}
