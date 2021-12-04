using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SatisApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatisApp.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
          
         }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; } // veri tabanında Product isimli tablo oluşacaktır 
        public DbSet<AppliscationUser> AppliscationUsers { get; set; }  
    }
}
