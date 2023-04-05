using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Add2CartModels
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        public string category_name { get; set; }
        public string category_description { get; set; }


    }
}
