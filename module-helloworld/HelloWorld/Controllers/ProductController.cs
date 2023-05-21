using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using fITness.Dnn.HelloWorld.Components;
using fITness.Dnn.HelloWorld.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace fITness.Dnn.HelloWorld.Controllers
{
    public class ProductController : DnnController
    {
        private static String BASE_URL = "http://20.234.113.211:8094//DesktopModules/Hotcakes/API/rest/v1/";

        // GET: Default

        private async Task<List<ProductDto>> GetProducts()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BASE_URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("products?key=1-af60ed8e-94ff-4da2-a167-8b716ab5629a");

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ProductsResponseRootDto>(data);
                return result.Content.Products;
            }

            throw new Exception("Error ocurred while fetching products from Whimsical");
        }
        [ModuleAction(ControlKey = "Edit", TitleKey = "AddItem")]
        public async Task<ActionResult> Index()
        {
            var items = await GetProducts();
            return View(items);
        }
    }
}