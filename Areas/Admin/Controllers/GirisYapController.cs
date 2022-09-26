using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using SeyahatWebProje.Migrations;
using SeyahatWebProje.Models.Siniflar;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace SeyahatWebProje.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    public class GirisYapController : Controller
    {
        private AppContext _context;

        public GirisYapController(AppContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Login(Models.Siniflar.Admin admin)
        {
            var giris = _context.Admins.FirstOrDefault(x => x.Kullanici == admin.Kullanici && x.Sifre == admin.Sifre);
            if (giris != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.Kullanici)
                };
                var user = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(user);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index","Admin");
            }
            else
            {
                ViewBag.Message = "Kullanıcı adı veya şifre yanlış.";
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "GirisYap");
        }
    }
}
