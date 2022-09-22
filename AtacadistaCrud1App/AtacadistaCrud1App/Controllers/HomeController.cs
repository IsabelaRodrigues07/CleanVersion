using AtacadistaCrud1App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;

namespace AtacadistaCrud1App.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index(bool ErroLogin)
        {
            if (ErroLogin)
            {
                ViewBag.Erro = "Apelido ou senha estão incorretos";
            }
            return View();
        }
        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            var usuarioDB = new Usuario()
            //criando o usuario no codigo, mas não deve ser feito aqui
            {
                apelido = "Isabela",
                password = "12345",
                cargo = "Adm"
            };
            //suponto um metodo de validação de login
            if (!usuarioDB.apelido.Equals(usuario.apelido) ||
                !usuarioDB.password.Equals(usuario.password))
            {
                return RedirectToAction("Index", new {ErroLogin = true} );
                
            }
            await new Services().Login(HttpContext, usuario);
                return RedirectToAction("Index", "Produtos");

            // se a validação acima tiver sucesso continua



        }
        //somente usuarios autorizados naquele momento, através do Authorize
        [Authorize]
        public async Task<IActionResult> Sair()
        {
            await new Services().Logoff(HttpContext);
            return RedirectToAction("Index");
        }

      //  [Authorize]
       // public IActionResult Produtos()
     //   {
       //     ViewBag.Permissoes = HttpContext.User.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value);
         //   return View();
      //  }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}