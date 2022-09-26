using Microsoft.EntityFrameworkCore;
using SeyahatWebProje.Models.Siniflar;

namespace SeyahatWebProje.Migrations

{
    public class AppContext : DbContext
    {
        
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }



    }
}
