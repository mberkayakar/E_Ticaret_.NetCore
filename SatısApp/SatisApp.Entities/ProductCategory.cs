using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisApp.Entities
{
    public class ProductCategory
    {

        //bu aşamadan Sonra Anvigation Property eklenecektir 
        #region Navigation Property  
        public int CategoryId{ get; set; }
        public Category Category { get; set; }
  
 
        public int ProductId{ get; set; }
        public Product Product { get; set; }

        #endregion

    }
}
