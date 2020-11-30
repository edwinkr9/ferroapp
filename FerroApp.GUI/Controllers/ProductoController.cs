using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FerroApp.GUI.Models;
using FerroApp.GUI.Reponses;
using Microsoft.AspNetCore.Mvc;

namespace FerroApp.GUI.Controllers
{
    public class ProductoController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://localhost:44367/api/producto");
            var productolist = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<ProductoResponseDto>>>(json);
            return View(productolist.Data);
        }
    }
}
