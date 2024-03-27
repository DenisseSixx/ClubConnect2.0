using DataManagment;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Objects;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DataManagment.Models;
using Rules;


namespace ClubConnect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CuentasController : Controller
    {
        IConsultas consulta;

        private readonly CuotasV100Context _context;
        private readonly EstadoCuentaItem _estadoCuenta;
        public string codter;

        public CuentasController(

            CuotasV100Context context
            )
        {

            _context = context;
            _estadoCuenta = new EstadoCuentaItem();
        }

      /*  [HttpGet("{codtercero}")]
        public IActionResult EstadosCuenta(string codtercero)
        {
            EstadoCuenta estadoCuenta = new EstadoCuenta();
            var resultados = estadoCuenta.EstadosCuenta(codtercero);

            if (resultados != null)
            {
                return Ok(resultados); // Devuelve los resultados como una respuesta HTTP 200 OK
            }
            else
            {
                return NotFound(); // Devuelve una respuesta HTTP 404 Not Found si no se encontraron resultados
            }
        }
      */
        [HttpGet("ObtenerEstadoCuenta/{codUsuario}")]
        public IActionResult EstadosCuenta2(string codUsuario)
        {
            // Consulta la tabla AppUsuarios para obtener el codTercero asociado al codUsuario
            var appUsuario = _context.Appusuarios.FirstOrDefault(u => u.CodUsuario == codUsuario);
            if (appUsuario == null)
            {
                return NotFound(); // Devuelve una respuesta HTTP 404 Not Found si no se encuentra el usuario en la tabla AppUsuarios
            }
            string codTercero = appUsuario.CodTercero;

            // Llama al método EstadosCuenta con el codTercero obtenido
            EstadoCuenta estadoCuenta = new EstadoCuenta();
            var resultados = estadoCuenta.EstadoCuentaGeneral(codTercero);

            if (resultados != null)
            {
                return Ok(resultados); // Devuelve los resultados como una respuesta HTTP 200 OK
            }
            else
            {
                return NotFound(); // Devuelve una respuesta HTTP 404 Not Found si no se encontraron resultados
            }
        }
    }
}

