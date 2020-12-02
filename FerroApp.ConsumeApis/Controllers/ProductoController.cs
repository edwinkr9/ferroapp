using FerroApp.ConsumeApis.Models;
using FerroApp.ConsumeApis.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

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
            return View();
        }

        [HttpPost]
        public ActionResult Create(Producto CrearProducto)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/producto");
                var CrearProduc = client.PostAsJsonAsync<Producto>("https://localhost:44367/api/producto", CrearProducto);
                CrearProduc.Wait();

                var CreaResult = CrearProduc.Result;
                if (CreaResult.IsSuccessStatusCode)
                    return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Error al agregar producto");
            return View(CrearProducto);
        }
        public ActionResult Update(int Codigo)
        {
            Producto producto = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/producto/");
                var responseTask = client.GetAsync("api/producto/" + Codigo.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Producto>();
                    readTask.Wait();

                    producto = readTask.Result;
                }
            }
            return View(producto);
        }
        [HttpPost]
        public ActionResult Update(Producto producto)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/producto");
                var putTask = client.PutAsJsonAsync<Producto>($"/api/Producto/{producto.Codigo}", producto);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }  
                
            }
            return View(producto);
        }
        //Delete Product
        public ActionResult DeleteProduct(int Codigo)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/");
                var deleteTask = client.DeleteAsync("Producto/" + Codigo.ToString());
                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }

    }
}