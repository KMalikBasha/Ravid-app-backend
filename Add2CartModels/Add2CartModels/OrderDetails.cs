using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2CartModels
{
    public class OrderDetails
    {

        [Key]
        public int id { get; set; }

        [ForeignKey("Product")]
        public int product_id { get; set; }
        public int order_id { get; set; }
        public int price { get; set; }

        [ForeignKey("Customer")]
        public int customer_id { get; set; }

        public string quantity { get; set; }
    }
}
