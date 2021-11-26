using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisApp.Entities
{
    public class Product
    {

        public int Id { get; set; }
        public string Name{ get; set; }
        public string ImageURL{ get; set; }
        public decimal Price  { get; set; }

        // ürünler ve kategoriler arasında  çok - Çok  ilişki mevcuttur
        // bir ürünün 1 kategorisi olacak Birden fazla da olabilir Zaten Bir kategoride birsürü de ürün olacak.
        // tablet düşün hem android hemde tablet kategorisinde yer alacaktır. 
        // bu sebeple CategoryProduct isimli bir adet sınıf oluşturuldu
        

        public List<ProductCategory> ProductCategories { get; set; }

    }
}
