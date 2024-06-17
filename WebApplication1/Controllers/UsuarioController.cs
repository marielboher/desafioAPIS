using Desafio2Boher.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sistemaGestionBussines;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService usuarioService;

        public UsuarioController()
        {
            usuarioService = new UsuarioService();
        }

        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> GetUsuarios()
        {
            return usuarioService.ListaDeUsuarios();
        }

        [HttpGet("{id}", Name = "GetUsuarioById")]
        public ActionResult<Usuario> GetUsuarioById(int id)
        {
            var usuario = usuarioService.GetUserById(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return usuario;
        }

        [HttpPost(Name = "CreateUsuario")]
        public IActionResult CreateUsuario([FromBody] Usuario usuario)
        {
            if (usuarioService.CreateUser(usuario))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}", Name = "UpdateUsuario")]
        public IActionResult UpdateUsuario(int id, [FromBody] Usuario usuario)
        {
            if (usuarioService.UpdateUser(id, usuario))
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}", Name = "DeleteUsuario")]
        public IActionResult DeleteUsuario(int id)
        {
            if (usuarioService.DeleteUser(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
