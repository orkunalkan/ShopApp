using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.entity
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Fiyat Girmelisiniz.")]
        [Range(1, 10000)]
        public double? price { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "Ürün ismi 10-60 karakter arası olamlıdır")]
        public string name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string description { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
