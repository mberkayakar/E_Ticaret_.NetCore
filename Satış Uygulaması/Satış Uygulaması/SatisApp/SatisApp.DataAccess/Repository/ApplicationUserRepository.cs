using Microsoft.EntityFrameworkCore;
using SatisApp.DataAccess.Data;
using SatisApp.DataAccess.Repository.IRepository;
using SatisApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisApp.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUserRepository>, IApplicationUserRepository
    {


        private readonly ApplicationDbContext _db;
        

        public ApplicationUserRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
            
        }
 
    }
}
