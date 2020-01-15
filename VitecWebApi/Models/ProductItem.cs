using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VitecWebApi.Models
{
    public class ProductItem
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Enter title")]
        [StringLength(30)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductDescription { get; set; }

        [Required]
        [Range(1, 10000)]
        public float Price { get; set; }
    }
}
