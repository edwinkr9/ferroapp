using FerroApp.Consume.Controllers;
using FerroApp.Consume.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsume
{
    class TestEdwin
    {
        [SetUp]
        public void Setup()
        {
        }
        //Actualizar Producto Con Campos Correctos
        [Test]
        public void ActualizarCampoCompleto()
        {
                var controller = new ProductoController();
                var product = new Producto()
                {
                    Codigo = 222,
                    Nombre = "AAAA",
                    Precio = "11111",
                    Marca = "BBB",
                    Categoria = "CCCC"
                };
                var respuesta = (RedirectToActionResult)controller.Update(product);
                Assert.AreEqual("Index", respuesta.ActionName);
        }
        //[Test]
        ////Actualizar Producto Con Campos Vacios
        //public void ActualizarCamposVacios()
        //{
        //    var controller = new ProductoController();
        //    var producto = new Producto();
        //    ViewResult result = controller.Update(2, producto) as ViewResult;
        //    Assert.IsNotNull(result/*.ViewData["Message"]*/);
        //}
        ////Actualizar producto con un campo vacio
        //[Test]
        //public void ActualizarUnCampoVacio()
        //{
        //    var controller = new ProductoController();
        //    var producto = new Producto()
        //    {
        //        Codigo = 222,
        //        Nombre = "",
        //        Precio = "11111",
        //        Marca = "BBB",
        //        Categoria = "CCCC"
        //    };

        //    ViewResult result = controller.Update(2, producto) as ViewResult;
        //    Assert.IsNotNull(result/*.ViewData["Message"]*/);
        //}
        ////Eliminar un producto
        //[Test]
        //public void EliminarProducto()
        //{
        //    ProductoController controller = new ProductoController();
        //    var response = (RedirectToActionResult)controller.DeleteProduct(222);
        //    Assert.AreEqual("Index", response.ActionName);
        //}
    }
}
