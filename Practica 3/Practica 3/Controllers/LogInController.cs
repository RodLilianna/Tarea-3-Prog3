using Microsoft.AspNetCore.Mvc;
using Practica_3.Models;

namespace Practica_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : Controller
    {
            private FachadaLogIn _logIn;

            public LogInController()
            {
                _logIn = new FachadaLogIn();
            }

        [HttpGet("Registro")]
        public bool RegistrarUsuario(string Nombusuario, string Contrasena)
        {
            if (_logIn.RegistrarUsuario(Nombusuario, Contrasena))
            {
                return true;
            }
            return false;
        }

        [HttpGet("InicioSesion")]
        public bool IniciarSesion(string Nombusuario, string Contrasena)
        {
            if (_logIn.IniciarSesion(Nombusuario, Contrasena))
            {
                return true;
            }
            return false;
        }

        [HttpPost("Cerrar-sesion")]
            public IActionResult CerrarSesion()
            {
                if (_logIn.CerrarSesion())
                {
                    return Ok("Cierre de sesión exitoso.");
                }
                return BadRequest("No se ha iniciado sesión.");
            }

            [HttpGet("Autenticado")]
            public IActionResult EstaAutenticado()
            {
                return Ok(_logIn.EstaAutenticado());
            }

            [HttpGet("Registros")]
            public IActionResult ObtenerRegistros()
            {
                var registros = _logIn.ObtenerRegistros();
                return Ok(registros);
            }
        }
    }

    public class RegistroRequest
    {
        public string Nombusuario { get; set; }
        public string Contrasena { get; set; }
    }

    public class InicioSesionRequest
    {
        public string Nombusuario { get; set; }
        public string Contrasena { get; set; }
    }

