using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FerroApp.Consume.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NUnit.Framework;

namespace FerroApp.Consume.Controllers
{
    public class ProductoController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        // GET: Producto
        //public bool status = true;
        [Test]
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var Json = await httpClient.GetStringAsync("https://localhost:44367/api/producto");
            var ListProductos = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Producto>>>(Json);

            return View(ListProductos.Data);
        }
        //public ActionResult Index()
        //{
        //    IEnumerable<Producto> Producto = null;
        //    using (var Client = new HttpClient())
        //    {
        //        Client.BaseAddress = new Uri("https://localhost:44367/api/");
        //        var responseTask = Client.GetAsync("Producto");
        //        responseTask.Wait();

        //        var result = responseTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            var readjob = result.Content.ReadAsAsync<IList<IEnumerable<Producto>>>();
        //            //var ListProductos = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Producto>>>(Json);

        //            readjob.Wait();
        //            Producto = (IEnumerable<Producto>)readjob.Result;
        //        }
        //    }
        //    return View(Producto);
        //}

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
                    //ViewBag.Message = "Producto agregado correctamente";
                    //return RedirectToAction("Index");
                    return View(CrearProducto);
                //try
                //{
                //if (ModelState.IsValid)
                //}
                //catch
                //{
                //    return View();
                //}
            }
            return View(CrearProducto);
        }

        //[AcceptVerbs("GET", "POST")]
        //public ActionResult VerifyCodigo(int codigo)
        //{
        //    if (!_userService.VerifyCodigo(codigo))
        //    {
        //        return Json($"Email {codigo} is already in use.");
        //    }

        //    return Json(true);
        //}
        //consumo para modificar
        public ActionResult Update(int Codigo, Producto producto)
        {
            Producto productos = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/");
                var responseTask = client.GetAsync("producto/" + Codigo.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ApiResponse<Producto>>();
                    readTask.Wait();

                    producto = readTask.Result.Data;
                }
            }
            return View(productos);
        }
        [HttpPost]
        public ActionResult Update(Producto producto)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/producto");
                var putTask = client.PutAsJsonAsync<Producto>($"/api/Producto/", producto);
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
