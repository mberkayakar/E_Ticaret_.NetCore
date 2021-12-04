using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisApp.Models
{
    public class AppliscationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public string PostaKodu { get; set; }
        [NotMapped]
        public string Role { get; set; }

    }
}
