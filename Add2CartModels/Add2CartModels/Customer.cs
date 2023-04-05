using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2CartModels
{
    public class Customer
    {

        [Key]
        public int id { get; set; }

        public string email { get; set; }
        public string customer_password { get; set; }

        public string full_name { get; set; }

        public string billing_address { get; set; }

        public string default_address { get; set; }

        public string country { get; set; }

        public Int64 phone { get; set; }
    }
}
