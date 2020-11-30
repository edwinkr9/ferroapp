using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using FerroApp.ConsumeApi.Models;
using Newtonsoft.Json;


namespace FerroApp.ConsumeApi.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto}
        //URL donde se ubica nuestra api: https://localhost:44367/api/producto
        string Baseurl = "https://localhost:44367/api/";
        public async Task<ActionResult> Index()
        {
            List<Producto> ProdInfo = new List<Producto>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/productos");
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    ProdInfo = JsonConvert.DeserializeObject<List<Producto>>(EmpResponse);

                }
                return View(ProdInfo);
            }            
        }
    }
}