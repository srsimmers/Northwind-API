using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Northwind_API.Models
{
    public class ProductInfo
    {
        [Key]
        public string description { get; set; }
        public string category_name { get; set; }
        public int supplier_id { get; set; }

        public string product_name { get; set; }
        public string company_name { get; set; }

        public double unit_price { get; set; }

        public int units_in_stock { get; set; }

        
    }
}
