using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2CartModels
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("customer")]
        public int customer_id { get; set; }
        public string shipping_address { get; set; }
        public int total_price { get; set; }

        public string email { get; set; }

        public string order_status { get; set; }

        public DateTime order_placed { get; set; }

        public DateOnly delivery_date { get; set; }
    }

}
