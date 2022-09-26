using SeyahatWebProje.Models.Siniflar;
using System.Collections.Generic;

namespace SeyahatWebProje.Models
{
    public class AnasayfaModel
    {
        public IEnumerable<Blog> blogVerisi { get; set; }
        public IEnumerable<Blog> enIyiGezilerim { get; set; }
        public IEnumerable<Blog> populerGeziler { get; set; }
        public IEnumerable<Blog> sonGonderiler { get; set; }

    }
}
