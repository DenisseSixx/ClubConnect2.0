using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Objects;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DataManagment.Models;
using Rules;
using System;
using NuGet.Common;


namespace ClubConnect2._0.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AppusuariosController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _config;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly CuotasV100Context _context;
        // private readonly TokenService _tokenService;

        public AppusuariosController(

        UserManager<IdentityUser> userManager,
        IConfiguration config,
        SignInManager<IdentityUser> signInManager,
        CuotasV100Context context)

        {
            _userManager = userManager;
            _config = config;
            _signInManager = signInManager;
            _context = context;
            // _tokenService = tokenService;
        }


        [HttpGet("ObtenerUsuarios")]
        public async Task<IActionResult> ObtenerUsuarios()
        {
            return Ok(await _context.Appusuarios.ToListAsync());
        }

        [HttpGet("ObtenerPorID/{CodUsuario}")]
        public async Task<IActionResult> ObtenerPorID(string CodUsuario)
        {
            if (CodUsuario == null)
            {
                return NotFound();
            }

            var appusuario = await _context.Appusuarios
                .FirstOrDefaultAsync(m => m.CodUsuario == CodUsuario);
            if (appusuario == null)
            {
                return NotFound();
            }

            return Ok(appusuario);
        }

        [HttpGet("ObtenerPorIDCodTercero/{CodUsuario}")]
        public async Task<IActionResult> ObtenerPorIDCodTercero(string CodUsuario)
        {
            if (CodUsuario == null)
            {
                return NotFound();
            }

            var appusuario = await _context.Appusuarios
                .Where(m => m.CodUsuario == CodUsuario)
                .Select(m => m.CodTercero)
                .FirstOrDefaultAsync();

            if (appusuario == null)
            {
                return NotFound();
            }

            return Ok(appusuario);
        }


        //         [HttpPost("CrearUsuario")]
        //         public async Task<ActionResult<RespuestaAutenticacion>> CrearUsuario(Appusuario appusuario)
        //        {
        //            try
        //            {

        //                var usuarioExistente = await _context.Appusuarios.FirstOrDefaultAsync(u => u.CodUsuario == appusuario.CodUsuario);

        //                if (usuarioExistente != null)
        //                {
        //                    return BadRequest("El usuario ya existe");
        //                }

        //                _context.Appusuarios.Add(appusuario);
        //                await _context.SaveChangesAsync();

        //                // Construir y devolver el nuevo token
        //                //var tokenResponse = await ConstruirToken(appusuario);
        //                //    return tokenResponse;
        //            }
        //            catch (Exception ex)
        //            {

        //                return BadRequest($"Error al registrar usuario: {ex.Message}");
        //            }
        //}
        //        private async Task<ActionResult<RespuestaAutenticacion>> ConstruirToken(Appusuario appusuario)
        //        {
        //            try
        //            {
        //                var claims = new List<Claim>()
        //        {
        //            new Claim("email", appusuario.CodUsuario)

        //        };

        //                var llave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["LlaveJWT"]));
        //                var creds = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);
        //                var expiracion = DateTime.UtcNow.AddDays(1);

        //                var securityToken = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiracion, signingCredentials: creds);

        //                return new RespuestaAutenticacion
        //                {
        //                    token = new JwtSecurityTokenHandler().WriteToken(securityToken),
        //                    expiracion = expiracion
        //                };
        //            }
        //            catch (Exception ex)
        //            {

        //                return BadRequest($"Error al construir el token: {ex.Message}");
        //            }
        //        }
        [HttpPost("CrearUsuario")]
        public async Task<ActionResult> CrearUsuario(Appusuario appusuario)
        {
            try
            {
                var usuarioExistente = await _context.Appusuarios.FirstOrDefaultAsync(u => u.CodUsuario == appusuario.CodUsuario);

                if (usuarioExistente != null)
                {
                    return BadRequest("El usuario ya existe");
                }

                _context.Appusuarios.Add(appusuario);
                await _context.SaveChangesAsync();
                var tablaLogin = new TablaLogin();
                tablaLogin.AgregarDatosLogin();
                // El usuario se ha creado correctamente, devolver un código 201 (Created)
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                // Verificar la excepción interna para obtener detalles específicos
                var innerExceptionMessage = (ex.InnerException != null) ? ex.InnerException.Message : "";

                // Devolver un código 400 (BadRequest) junto con un mensaje de error detallado
                return BadRequest($"Error al registrar usuario. Detalles: {ex.Message}. Excepción interna: {innerExceptionMessage}");
            }
        }



        /*[HttpGet("RenovarToken")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        public async Task<ActionResult<RespuestaAutenticacion>> Renovar()
        {
            var emailClaims = HttpContext.User.Claims.Where(x => x.Type == ClaimTypes.Email).Select(x => x.Value).FirstOrDefault();
            var appusuario = new Appusuario() { CodUsuario = emailClaims };
            return await ConstruirToken(appusuario);
        }
        */

        [HttpGet("RenovarToken")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<Apprespuestaautenticacion>> Renovar()
        {
            try
            {
                var emailClaims = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "email")?.Value;

                if (string.IsNullOrEmpty(emailClaims))
                {
                    return BadRequest("No se pudo obtener el email del token.");
                }

                var appusuario = new Appusuario() { CodUsuario = emailClaims };
                return await ConstruirToken(appusuario);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al renovar el token: {ex.Message}");
            }
        }

        [HttpPost("Login")]
        public async Task<ActionResult<Apprespuestaautenticacion>> Login(Applogin applogin)
        {
            try
            {
                // Verificar las credenciales del usuario manualmente
                var usuarioExistente = await _context.Applogin
                    .FirstOrDefaultAsync(u => u.CodUsuario == applogin.CodUsuario && u.ClaUsuario == applogin.ClaUsuario);

                if (usuarioExistente == null)
                {
                    return BadRequest("Login Incorrecto");
                }

                var appusuario = new Appusuario { CodUsuario = applogin.CodUsuario, ClaUsuario = applogin.ClaUsuario };
                var tokenResponse = await ConstruirToken(appusuario);

                var respuestaAutenticacion = new RespuestaAutenticacion();

                respuestaAutenticacion.AgregarRespuestaAute(appusuario.CodUsuario, token2, expiraion2);

                return tokenResponse;

            }
            catch (Exception ex)
            {
                return BadRequest($"Error al realizar el login: {ex.Message}");
            }
        }

        string token2;
        DateTime expiraion2;
        private async Task<ActionResult<Apprespuestaautenticacion>> ConstruirToken(Appusuario appusuario)
        {
            try
            {
                var claims = new List<Claim>()
                    {
                        new Claim("CodUsuario", appusuario.CodUsuario)

                    };

                var llave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["LlaveJWT"]));
                var creds = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);
                var expiracion = DateTime.UtcNow.AddDays(1);

                var securityToken = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiracion, signingCredentials: creds);
                token2 = new JwtSecurityTokenHandler().WriteToken(securityToken);
                expiraion2 = expiracion;
                return new Apprespuestaautenticacion
                {
                    token = new JwtSecurityTokenHandler().WriteToken(securityToken),
                    expiracion = expiracion,
                    CodUsuario = appusuario.CodUsuario
                };

            }
            catch (Exception ex)
            {

                return BadRequest($"Error al construir el token: {ex.Message}");
            }
        }





        [HttpPut("EditarUsuario/{CodUsuario}")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarUsuario(string CodUsuario, [FromBody] Appusuario appusuario)
        {
            if (CodUsuario != appusuario.CodUsuario)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appusuario);
                    await _context.SaveChangesAsync();
                    var tablaLogin = new TablaLogin();
                    tablaLogin.AgregarDatosLogin();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppusuarioExists(appusuario.CodUsuario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return NoContent();
            }
            return BadRequest(ModelState);
        }



        /* [HttpDelete("EliminarUsuario/{CodUsuario}")]
         public async Task<IActionResult> EliminarUsuario(string CodUsuario)
         {
             if (CodUsuario  == null)
             {
                 return NotFound();
             }

             var appusuario = await _context.Appusuarios
                 .FirstOrDefaultAsync(m => m.CodUsuario == CodUsuario);
             if (appusuario == null)
             {
                 return NotFound();
             }

             return Ok(appusuario);
         }
        */


        [HttpDelete("EliminarUsuarioConfirmado/{CodUsuario}")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarUsuarioConfirmado(string CodUsuario)
        {
            var appusuario = await _context.Appusuarios.FindAsync(CodUsuario);
            if (appusuario != null)
            {
                _context.Appusuarios.Remove(appusuario);
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }

        private bool AppusuarioExists(string CodUsuario)
        {
            return _context.Appusuarios.Any(e => e.CodUsuario == CodUsuario);
        }

    
        [HttpPut("EditarContrasena/{CodUsuario}")]
        public async Task<IActionResult> CambiarContrasena(string CodUsuario, [FromBody] string claUsuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingAppusuarios = await _context.Appusuarios.FirstOrDefaultAsync(x => x.CodUsuario == CodUsuario);
                    if (existingAppusuarios == null)
                    {
                        return NotFound();
                    }

                    existingAppusuarios.ClaUsuario = claUsuario; // Actualiza el campo claUsuario con el valor proporcionado

                    await _context.SaveChangesAsync(); // Guarda los cambios en la base de datos
                    var tablaLogin = new TablaLogin();
                    tablaLogin.AgregarDatosLogin();
                    // El usuario se ha creado correctamente, devolver un código 201 (Created)
                    return StatusCode(201);
                    return NoContent();
                }
                catch (DbUpdateConcurrencyException)
                {

                }
               
            }
            return BadRequest(ModelState);


        }
    }
}