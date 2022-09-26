using Microsoft.AspNetCore.Mvc;
using SeyahatWebProje.Models.Siniflar;
using System.Linq;
using SeyahatWebProje.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace SeyahatWebProje.Controllers
{
    public class ContactController : Controller
    {
        private AppContext _context;

        public ContactController(AppContext context)
        {
            _context = context;
        }
        IletisimModel modelbilgi = new IletisimModel();
        [HttpGet]
        public IActionResult Index()
        {
            modelbilgi.bilgi = _context.AdresBlogs.ToList();
            return View(modelbilgi);
        }
        [HttpPost]
        public IActionResult Index(iletisim iletisimF)
        {
            _context.iletisims.Add(iletisimF);
            _context.SaveChanges();
            return View();
        }
    }
}
