using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // key tanımlaması yapılınca otomatik olarak kütüphane çağrıldı . 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisApp.Models
{
   public class Category
    {


        #region İD tanımalama 
        
        [Key]  // bu sayede identity (benzersiz oldu )
        public int Id{ get; set; }
        #endregion


        #region Kategori ismi 
        [Display(Name="Kategori Adı")] // ekranda gözükecek ismi
        [Required] // zorunlu
        [MaxLength(100)] // max Karakter uzunluğu 
        public string Name{ get; set; }
        #endregion


    }
}
