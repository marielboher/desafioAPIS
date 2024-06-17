using Desafio2Boher.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sistemaGestionBussines;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoService productoService;

        public ProductoController()
        {
            productoService = new ProductoService();
        }

        [HttpGet(Name = "GetProductos")]
        public IEnumerable<Producto> GetProductos()
        {
            return productoService.ListaDeProductos();
        }

        [HttpGet("{id}", Name = "GetProductoById")]
        public ActionResult<Producto> GetProductoById(int id)
        {
            var producto = productoService.GetProductoById(id);
            if (producto == null)
            {
                return NotFound();
            }
            return producto;
        }

        [HttpPost(Name = "CreateProducto")]
        public IActionResult CreateProducto([FromBody] Producto producto)
        {
            if (productoService.CreateProducto(producto))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}", Name = "UpdateProducto")]
        public IActionResult UpdateProducto(int id, [FromBody] Producto producto)
        {
            if (productoService.UpdateProducto(id, producto))
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}", Name = "DeleteProducto")]
        public IActionResult DeleteProducto(int id)
        {
            if (productoService.DeleteProducto(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
