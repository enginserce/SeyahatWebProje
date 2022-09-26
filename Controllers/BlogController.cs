using Microsoft.AspNetCore.Mvc;
using SeyahatWebProje.Models.Siniflar;
using System.Linq;
using SeyahatWebProje.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System;
using AppContext = SeyahatWebProje.Migrations.AppContext;

namespace SeyahatWebProje.Controllers
{

	public class BlogController : Controller
	{
        private AppContext _context;

        public BlogController(AppContext context)
        {
            _context = context;
        }
        BlogYorum by = new BlogYorum();
        public IActionResult Index()
		{
            //List<Blog> blog = _context.Blogs.ToList();
            by.deger1 = _context.Blogs.ToList();
            //by.deger3 = _context.Blogs.Take(3).ToList();
            by.deger3 = _context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }

        public IActionResult BlogDetay(int id)
        {
            //List<Blog> blogbul = _context.Blogs.Where(x => x.ID == id).ToList();
            by.deger1 = _context.Blogs.Where(x => x.ID == id).ToList();
            by.deger2 = _context.Yorumlars.Where(x => x.Blogid == id).ToList();
            by.deger3 = _context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            by.deger4 = _context.Hakkimizdas.ToList();

            ViewBag.find = id;

            return View(by);
        }
        [HttpPost]
        public IActionResult BlogDetay(Yorumlar yorumBilgisi, int id) 
        {
            Yorumlar yorum = new Yorumlar();

            yorum.KullaniciAdi = yorumBilgisi.KullaniciAdi;
            yorum.Blogid = yorumBilgisi.Blogid;
            yorum.Yorum = yorumBilgisi.Yorum;
            yorum.Mail = yorumBilgisi.Mail;
            _context.Yorumlars.Add(yorum);
            _context.SaveChanges();

            by.deger1 = _context.Blogs.Where(x => x.ID == id).ToList();
            by.deger2 = _context.Yorumlars.Where(x => x.Blogid == id).ToList();
            by.deger3 = _context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            by.deger4 = _context.Hakkimizdas.ToList();
            return View(by);
        }
    }
}
