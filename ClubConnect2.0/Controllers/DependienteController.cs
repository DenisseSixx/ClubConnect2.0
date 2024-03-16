using DataManagment.Models;
using DataManagment;
using Microsoft.AspNetCore.Mvc;
using Rules;

namespace ClubConnect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DependienteController : Controller
    {
        IConsultas consulta;

        private readonly CuotasV100Context _context;
        private Dependientes _dependientes;

        public DependienteController(

            CuotasV100Context context
            )
        {

            _context = context;
            _dependientes = new Dependientes();

        }

        [HttpGet("ObtenerDependientes/{CodUsuario}")]
        public ActionResult<List<SaDependiente>> ObtenerDependientes(string CodUsuario)
        {
            var dependientes = _dependientes.ObtenerDependientesDeUsuario(CodUsuario);

            if (dependientes == null)
            {
                return NotFound(); // Retorna 404 si no se encuentran dependientes para el usuario
            }

            return dependientes;
        }

        [HttpGet("ObtenerDependientes/{CodUsuario}/{CodDependiente}")]
        public ActionResult<List<SaDependiente>> ObtenerConCodDep(string CodUsuario, decimal CodDependiente)
        {
            var dependiente = _dependientes.ObtenerDependientesCod(CodUsuario, CodDependiente);

            if (dependiente == null)
            {
                return NotFound(); // Retorna 404 si no se encuentran dependientes para el usuario
            }

            return dependiente;
        }

        /*[HttpGet("ObtenerDependientes/{CodUsuario}")]
        public ActionResult<SaDependiente> ObtenerDependientes(string CodUsuario)
        {
            var dependientes = _dependientes.ObtenerDependientesDeUsuario(CodUsuario);

            if (dependientes == null)
            {
                return NotFound(); // Retorna 404 si no se encuentra un dependiente para el usuario
            }

            return dependientes;
        }*/

        [HttpGet("ObtenerDependientesOb/{CodUsuario}/{CodDependiente}")]
        public ActionResult<List<SaDependiente>> ObtenerDependientesCodOb(string CodUsuario, decimal CodDependiente)
        {
            var dependiente = _dependientes.ObtenerDependientesCod(CodUsuario, CodDependiente);

            if (dependiente == null)
            {
                return NotFound(); // Retorna 404 si no se encuentran dependientes para el usuario
            }

            return dependiente;
        }
    }


}