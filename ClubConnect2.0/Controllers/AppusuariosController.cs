using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Objects;
using WebApplication1.Models;

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

        [HttpPost("CrearUsuario")]
      
        public async Task<ActionResult<RespuestaAutenticacion>> CrearUsuario( [FromBody]Appusuario appusuario)
        {

            {
                var usuario = new IdentityUser
                {
                 
                    Id = appusuario.CodUsuario,
                    PasswordHash = appusuario.ClaUsuario,
                    UserName = appusuario.NomUsuario,
                   
                };
                var resultado = await _userManager.CreateAsync(usuario, appusuario.ClaUsuario);
                if (resultado.Succeeded)
                {
                    return await ConstruirToken(appusuario);
                }
                return BadRequest(resultado.Errors);
            }

        }
        private async Task<ActionResult<RespuestaAutenticacion>> ConstruirToken(Appusuario appusuario)
        {
            var claims = new List<Claim>()
        {
            new Claim("email",appusuario.CodUsuario)
        };
            var usuario = await _userManager.FindByEmailAsync(appusuario.CodUsuario);
            var claimsRoles = await _userManager.GetClaimsAsync(usuario);

            claims.AddRange(claims);

            var llave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["LlaveJWT"]));
            var creds = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);

            var expiracion = DateTime.UtcNow.AddDays(1);

            var securityToken = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiracion, signingCredentials: creds);

            return new RespuestaAutenticacion
            {
                token = new JwtSecurityTokenHandler().WriteToken(securityToken),
                expiracion = expiracion,
            };
        }
        [HttpPost("Login")]
        public async Task<ActionResult<RespuestaAutenticacion>> Login(Appusuario appusuario)
        {
            var resultado = await _signInManager.PasswordSignInAsync(
                appusuario.CodUsuario,
                appusuario.ClaUsuario,
                isPersistent: false,
                lockoutOnFailure: false);
            if (resultado.Succeeded)
            {
                return await ConstruirToken(appusuario);
            }
            else
            {
                return BadRequest("Login Incorrecto");
            }
        }

        [HttpPut("EditarUsuario/{CodUsuario}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarUsuario(string CodUsuario, [FromBody] Appusuario appusuario)
        {
            if (CodUsuario!= appusuario.CodUsuario)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appusuario);
                    await _context.SaveChangesAsync();
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

        [HttpGet("EliminarUsuario/{CodUsuario}")]
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

        [HttpDelete("EliminarUsuarioConfirmado/{CodUsuario}")]
        [ValidateAntiForgeryToken]
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
    }
}
