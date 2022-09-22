using AtacadistaCrud1App.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace AtacadistaCrud1App
    //essa classe gerencia os cookies 
{
    public class Services
    {
        //criando o cookie
        public async Task Login(HttpContext Ctx, Usuario usuario)
        {
            var claims = new List<Claim>();
            //add claim do nome do usuario
            claims.Add(new Claim(ClaimTypes.Name, usuario.apelido));
            //add claim do Role(função/cargo) do usuario
            claims.Add(new Claim(ClaimTypes.Role, usuario.cargo));

            var claimsIdentity =
                new ClaimsPrincipal(
                    new ClaimsIdentity(
                        claims,
                        CookieAuthenticationDefaults.AuthenticationScheme));
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTime.Now.AddHours(5),
                IssuedUtc = DateTime.Now
            };

            await Ctx.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsIdentity, authProperties);
        }

        public  async Task Logoff(HttpContext Ctx)
        {
            await Ctx.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
