using Microsoft.AspNetCore.Mvc;
using SeyahatWebProje.Models.Siniflar;
using System.Linq;
using SeyahatWebProje.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace SeyahatWebProje.Controllers
{

    public class AboutController : Controller
    {
        private AppContext _context;

        public AboutController(AppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Hakkimizda> veri = _context.Hakkimizdas.ToList();
            return View(veri);
        }
    }
}
