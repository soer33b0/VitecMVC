using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VitecMVC.Models;
using System.Net.Http;
using System.Net;


namespace VitecMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        private static readonly HttpClient client = new HttpClient();
        public IActionResult Products()
        {
            _logger.LogDebug("User has accessed products");
            IEnumerable<Product> products = new List<Product>();
            using (WebClient client = new WebClient())
            {
                var json = client.DownloadString("http://localhost:44365/api/products");
                products = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
            }
            return View(products);
        }
    }
}
