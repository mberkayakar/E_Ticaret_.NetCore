using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisApp.Entities
{
    public class Category  // ürünler ve kategoriler arasında bire çok ilişki mevcuttur bir ürünün 1 kategorisi olacak ama bir kategoride birden fazla ürün olacaktır
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Bir kategori için birden fazla ürün olarbilir 

        public List<ProductCategory> ProductCategories { get; set; }

   
    }
}
