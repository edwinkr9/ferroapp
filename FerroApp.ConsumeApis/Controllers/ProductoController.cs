using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using FerroApp.ConsumeApis.Models;
using FerroApp.ConsumeApis.Responses;
using Newtonsoft.Json;

namespace FerroApp.ConsumeApis.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public bool status = true;
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var Json = await httpClient.GetStringAsync("https://localhost:44367/api/producto");
            var ListProductos = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Producto>>>(Json);
            return View(ListProductos.Data);
        }
        public ActionResult Create()
        {
            if(HttpContext.Session.GetString("Id") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public async Task<ActionResult> Create(Producto requestDto)
        {
            requestDto.Codigo = Int32.Parse(HttpContext.Session.GetString("Id"));
            var httpClient = new HttpClient();
            var Json = await httpClient.PostAsJsonAsync("https://localhost:44367/api/producto", requestDto);
            return View(requestDto);
        }

    }
}