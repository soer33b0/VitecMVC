using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitecWebApi.Models
{
    public class ProductItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ProductDescription { get; set; }
        public float Price { get; set; }
    }
}
