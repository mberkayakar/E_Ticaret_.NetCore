using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisApp.Models
{
    public class Product
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
 
        public string ImageUrl { get; set; }

        #region Kategori ile ürünler arasındaki ilişki (1-N)

        [Required]
        public int CategoryId{ get; set; }
        [ForeignKey("CategoryId")]
        public Category Category{ get; set; }
        #endregion


    }
}
