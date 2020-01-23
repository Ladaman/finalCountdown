using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsScore.Models.Products
{
    public class AddProductViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid name")]
        public string Name { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid name")]
        public decimal Price { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid description")]
        public string Desc { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid category")]
        public string Category { get; set; }
    }
}
