using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2CartModels
{
    public class ProductCategory
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("Product")]
        public int product_id { get; set; }


        [ForeignKey("Category")]
        public int category_id { get; set; }
    }
}
