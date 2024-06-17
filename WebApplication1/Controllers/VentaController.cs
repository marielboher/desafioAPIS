using Desafio2Boher.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sistemaGestionBussines;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly VentaService ventaService;

        public VentaController()
        {
            ventaService = new VentaService();
        }

        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> GetVentas()
        {
            return ventaService.ListaDeVentas();
        }

        [HttpGet("{id}", Name = "GetVentaById")]
        public ActionResult<Venta> GetVentaById(int id)
        {
            var venta = ventaService.GetVentaById(id);
            if (venta == null)
            {
                return NotFound();
            }
            return venta;
        }

        [HttpPost(Name = "CreateVenta")]
        public IActionResult CreateVenta([FromBody] Venta venta)
        {
            if (ventaService.CreateVenta(venta))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}", Name = "UpdateVenta")]
        public IActionResult UpdateVenta(int id, [FromBody] Venta venta)
        {
            if (ventaService.UpdateVenta(id, venta))
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}", Name = "DeleteVenta")]
        public IActionResult DeleteVenta(int id)
        {
            if (ventaService.DeleteVenta(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
