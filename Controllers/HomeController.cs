using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SeyahatWebProje.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SeyahatWebProje.Models.Siniflar;
using SeyahatWebProje.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using AppContext = SeyahatWebProje.Migrations.AppContext;

namespace SeyahatWebProje.Controllers
{

    public class HomeController : Controller
    {
        private AppContext _context;

        public HomeController(AppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Slider = _context.Blogs.Take(10).ToList();

            var anasayfa = new AnasayfaModel();

            anasayfa.populerGeziler = _context.Blogs.Take(9).ToList(); 
            anasayfa.enIyiGezilerim = _context.Blogs.OrderByDescending(x => x.ID).Take(4).ToList();
            anasayfa.sonGonderiler = _context.Blogs.Take(3).ToList();

            return View(anasayfa);
        }

        public PartialViewResult _Footer()
        {
            return PartialView();
        }

    }
}
