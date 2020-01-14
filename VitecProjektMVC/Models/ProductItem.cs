using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace VitecProjektMVC.Models
{
    public class ProductItem
    {
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        [JsonProperty("productDescription")]
        public string ProductDescription
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public string Price
        {
            get;
            set;
        }

    }
}
