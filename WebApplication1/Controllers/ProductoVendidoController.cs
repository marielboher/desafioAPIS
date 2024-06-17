using Desafio2Boher.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sistemaGestionBussines;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        private readonly ProductoVendidoService productoVendidoService;

        public ProductoVendidoController()
        {
            productoVendidoService = new ProductoVendidoService();
        }

        [HttpGet(Name = "GetProductosVendidos")]
        public IEnumerable<ProductoVendido> GetProductosVendidos()
        {
            return productoVendidoService.ListaDeProductosVendidos();
        }

        [HttpGet("{id}", Name = "GetProductoVendidoById")]
        public ActionResult<ProductoVendido> GetProductoVendidoById(int id)
        {
            var productoVendido = productoVendidoService.GetProductoVendidoById(id);
            if (productoVendido == null)
            {
                return NotFound();
            }
            return productoVendido;
        }

        [HttpPost(Name = "CreateProductoVendido")]
        public IActionResult CreateProductoVendido([FromBody] ProductoVendido productoVendido)
        {
            if (productoVendidoService.CreateProductoVendido(productoVendido))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}", Name = "UpdateProductoVendido")]
        public IActionResult UpdateProductoVendido(int id, [FromBody] ProductoVendido productoVendido)
        {
            if (productoVendidoService.UpdateProductoVendido(id, productoVendido))
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}", Name = "DeleteProductoVendido")]
        public IActionResult DeleteProductoVendido(int id)
        {
            if (productoVendidoService.DeleteProductoVendido(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
