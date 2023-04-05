using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2CartModels
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        public string product_name { get; set; }
        public int product_weight { get; set; }

        public int price { get; set; }
        public string product_description { get; set; }

        public int category { get; set; }
        public DateTime added_on { get; set; }
        public int stock { get; set; }
    }
}
