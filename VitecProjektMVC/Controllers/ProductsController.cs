using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VitecProjektMVC.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VitecProjektMVC.Controllers
{
    [Route("products")]
    public class ProductsController : Controller
    {
       
        public IActionResult Index()
        {
            IEnumerable<ProductItem> products = null;
            using (var client = new HttpClient())
            {

                //HTTP GET
                var responseTask = client.GetAsync("https://vitecwebapi20200114035531.azurewebsites.net/api/ProductItems");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ProductItem>>();
                    readTask.Wait();

                    products = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    products = Enumerable.Empty<ProductItem>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
                return View(products);
            }
        }
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult create([FromForm] ProductItem product)
        {
            using (var httpClient = new HttpClient())
            {
               var uri = new Uri("https://vitecwebapi20200114035531.azurewebsites.net/api/ProductItems");

                //HTTP POST
                product.Id = 0;
                var response = httpClient.PostAsJsonAsync(uri, product).Result;
                
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View();
        }
    }
}