using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisApp.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        ICategoryRepository Category { get; }
        IProductRepository Product{ get; }
        ISP_Call SP_Call{ get; }
        ApplicationUserRepository ApplicationUser{ get; }
        void Save();




    }
}
