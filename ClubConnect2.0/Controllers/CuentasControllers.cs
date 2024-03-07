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


namespace ClubConnect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CuentasController : Controller
    {
        IConsultas consulta;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _config;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly CuotasV100Context _context;
    
        public CuentasController(
            UserManager<IdentityUser> userManager,
            IConfiguration config,
            SignInManager<IdentityUser> signInManager,
            CuotasV100Context context
            )
        {
            _userManager = userManager;
            _config = config;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpPost("registrar")]
        public async Task<ActionResult<RespuestaAutenticacion>> Registrar(CredencialesUsuario credencialesUsuario)
        {
            
            var usuario = new IdentityUser
            {
                UserName = credencialesUsuario.CodTercero,
                Email = credencialesUsuario.Clave
            };
            var resultado = await _userManager.CreateAsync(usuario, credencialesUsuario.Clave);
            if (resultado.Succeeded)
            {
                return await ConstruirToken(credencialesUsuario);
            }
            return BadRequest(resultado.Errors);
        }

        private async Task<ActionResult<RespuestaAutenticacion>> ConstruirToken(CredencialesUsuario credencialesUsuario)
        {
            var claims = new List<Claim>()
        {
            new Claim("CodTercero",credencialesUsuario.CodTercero)
        };
            var usuario = await _userManager.FindByEmailAsync(credencialesUsuario.CodTercero);
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


        [HttpGet("RenovarToken")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        public async Task<ActionResult<RespuestaAutenticacion>> Renovar()
        {

            var CodTeceroClaims = HttpContext.User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).Select(x => x.Value).FirstOrDefault();
            var credencialesUsuario = new CredencialesUsuario() { CodTercero = CodTeceroClaims };

            return await ConstruirToken(credencialesUsuario);
        }
        
        [HttpPost("Login")]
        public async Task<ActionResult<RespuestaAutenticacion>> Login(CredencialesUsuario credencialesUsuario)
        {
            var resultado = await _signInManager.PasswordSignInAsync(
                credencialesUsuario.CodTercero,
                credencialesUsuario.Clave,
                isPersistent: false,
                lockoutOnFailure: false);
            if (resultado.Succeeded)
            {
                return await ConstruirToken(credencialesUsuario);
            }
            else
            {
                return BadRequest("Login Incorrecto");
            }
        }
    }
}



    
