using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication1._02_Logica;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    //[AllowAnonymous] ==> indica que la petición será aceptada sin importar el origin
    // o si tiene o no tiene un token asignado
    public class AuthController : ControllerBase
    {
        UsuarioLogica usuarioLogica = new UsuarioLogica();

        [HttpGet]
        public IActionResult get()
        {
            return Ok("el servicio está escuchando");
        }


        [HttpPost]
        public IActionResult post(LoginRequest request)
        {
            //01 VALIDAR LOGIN 
            LoginResponse res = usuarioLogica.login(request);

            if( !(res != null && res.Success))
            {
                return Ok(res);
            }
            res.Token = CreateToken(res.user);

            //01 GENERAR NUESTRO TOKEN DE SEGURIDAD
            //Instalar librería ==> System.IdentityModel.Tokens.Jwt



            return Ok(res);
        }


        private static string CreateToken(UsuarioLoginResponse user)
        {

            //create claims details based on the user information
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();
            // Leemos el archivo de configuración.

            string hahaha = configurationFile["Jwt:Subject"];
            int TimpoVidaToken = int.Parse(configurationFile["Jwt:TimeJWTMin"]);
            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, configurationFile["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", user.Id.ToString()),
                        new Claim("DisplayName", $"{user.FullName}"),
                        new Claim("UserName", user.Username),
                        new Claim(ClaimTypes.Role, user.role.Description),
                        //new Claim("Email", user.email)
                    };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configurationFile["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                configurationFile["Jwt:Issuer"],
                configurationFile["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(TimpoVidaToken),
                signingCredentials: signIn);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}