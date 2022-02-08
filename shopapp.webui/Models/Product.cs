using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60,MinimumLength =10,ErrorMessage ="Ürün ismi için 1-60 karakter arasında isim girmelisiniz")]
        public string Name { get; set; }
        
        // double nullable olmalı yoksa 0 degerı databasede sayı olarak degerlendırılecegı ıcın [required] bir işimize yaramaz.
        [Required(ErrorMessage ="Fiyat Girmelisiniz!")]
        [Range(1,10000)]
        public double? Price { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage ="Lütfen Image Url Giriniz!")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Lütfen CategoryId seçiniz!")]
        public int? CategoryId { get; set; }
    }
}