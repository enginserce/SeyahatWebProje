using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SeyahatWebProje.Migrations;
using SeyahatWebProje.Models.Siniflar;
using System.Linq;

namespace SeyahatWebProje.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class AdminController : Controller 
    {
        private AppContext _context;

        public AdminController(AppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            var bloglar = _context.Blogs.ToList();
            return View(bloglar);
        }
        [HttpGet]
        public IActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniBlog(Blog p)
        {
            _context.Blogs.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
      
        public IActionResult BlogSil(int id)
        {
            var sil = _context.Blogs.Find(id);
            _context.Blogs.Remove(sil);
            _context.SaveChanges();
            return RedirectToAction("Blog");
        }
        public IActionResult BlogGetir(int id)
        {
            var bul = _context.Blogs.Find(id);
            return View("BlogGetir", bul);
        }
        public IActionResult BlogGuncelle(Blog guncelle)
        {
            var blogguncelle = _context.Blogs.Find(guncelle.ID);
            blogguncelle.Aciklama = guncelle.Aciklama;
            blogguncelle.Baslik = guncelle.Baslik;
            blogguncelle.Tarih = guncelle.Tarih;
            blogguncelle.BlogImage = guncelle.BlogImage;
            _context.SaveChanges();
            return RedirectToAction("Blog");
        }

        public IActionResult Yorumlar()
        {
            var yorumlar = _context.Yorumlars.ToList();
            return View(yorumlar);
        }

        public IActionResult YorumSil(int id)
        {
            var sil = _context.Yorumlars.Find(id);
            _context.Yorumlars.Remove(sil);
            _context.SaveChanges();
            return RedirectToAction("Yorumlar");
        }
        public IActionResult YorumGetir(int id)
        {
            var ybul = _context.Yorumlars.Find(id);
            return View("YorumGetir", ybul);
        }
        public IActionResult YorumGuncelle(Yorumlar guncelle)
        {
            var yorumguncelle = _context.Yorumlars.Find(guncelle.ID);
            yorumguncelle.KullaniciAdi = guncelle.KullaniciAdi;
            yorumguncelle.Mail = guncelle.Mail;
            yorumguncelle.Yorum = guncelle.Yorum;
            _context.SaveChanges();
            return RedirectToAction("Yorumlar");
        }

        public IActionResult Hakkimizda()
        {
            var about = _context.Hakkimizdas.ToList();
            return View(about);
        }

        public IActionResult HakkimizdaGetir(int id)
        {
            var ybul = _context.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", ybul);
        }

        public IActionResult HakkimizdaGuncelle(Hakkimizda guncelle)
        {
            var yorumguncelle = _context.Hakkimizdas.Find(guncelle.ID);
            yorumguncelle.imageURL = guncelle.imageURL;
            yorumguncelle.Aciklama = guncelle.Aciklama;
            _context.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }

        public IActionResult Iletisim()
        {
            var iletisim = _context.iletisims.ToList();
            return View(iletisim);
        }

        public IActionResult IletisimSil(int id)
        {
            var cSil = _context.iletisims.Find(id);
            _context.iletisims.Remove(cSil);
            _context.SaveChanges();
            return RedirectToAction("Iletisim");
        }
    }
}
