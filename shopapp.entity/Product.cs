using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.entity
{
    public class Product
    {
        public int ProductId { get; set; }
        
        
        public string Name { get; set; }

        // double nullable olmalı yoksa 0 degerı databasede sayı olarak degerlendırılecegı ıcın [required] bir işimize yaramaz.
       
        
        public double? Price { get; set; }
        public string Description { get; set; }
        
        public string ImageUrl { get; set; }

        public List<ProductCategory> ProductCategory { get; set; }

    }
}