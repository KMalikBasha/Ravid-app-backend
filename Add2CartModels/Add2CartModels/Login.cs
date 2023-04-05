using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2CartModels
{
    public class Login
    {
        [Key]
        public int userid { get; set; }

        public string user_password { get; set; }

        public string username { get; set; }
        
    }
}
