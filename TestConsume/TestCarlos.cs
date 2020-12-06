using FerroApp.Consume.Controllers;
using FerroApp.Consume.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Threading.Tasks;

namespace TestConsume
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //Obtener la lista de productos de la api
        [Test]
        public async Task GetProductos()
        {
            var controller = new ProductoController();
            var respuesta = await controller.Index() as ViewResult;

            Assert.IsNotNull(respuesta.Model);
        }
        ////Error al obtener la lista de productos de la api
        ////[Test]
        ////public async Task ErrorGetProductos()
        ////{
        ////    var controller = new ProductoController();
        ////    var respuesta = await controller.Index() as ViewResult;

        ////    Assert.IsNull(respuesta.Model);
        ////}
        //[Test]
        //public void AgregarProducto()
        //{
        //    //Agregar Producto con todos los campos validos
        //    ProductoController controller = new ProductoController();
        //    var produc = new Producto()
        //    {
        //        Codigo = 222,
        //        Nombre = "AAAA",
        //        Precio = "11111",
        //        Marca = "BBB",
        //        Categoria = "CCCC"

        //    };

        //    var response = controller.Create(produc) as ViewResult;
        //    Assert.IsNotNull("Index", response.ViewName);
        //}
        //[Test]
        //public void AgregarVacio()
        //{
        //        var controller = new ProductoController();
        //        var producto = new Producto();
        //        var respuesta = controller.Create(producto) as ViewResult;
        //        Assert.IsNull(respuesta.ViewName);
        //}

        //[Test]
        ////Este es el caso de prueba cuado alguno de los campos del formulario no tiene el formato correcto
        //public void ProductoInvalido()
        //{
        //    var controller = new ProductoController();
        //    var produc = new Producto()
        //    {
        //        Codigo = -325,
        //        Nombre = "Pala",
        //        Marca = "Apple",
        //        Precio = "120",
        //        Categoria = "Herramienta",

        //    };
        //    var respuesta = controller.Create(produc) as ViewResult;
        //    Assert.IsNull(respuesta.ViewName);
        //}
    }

}