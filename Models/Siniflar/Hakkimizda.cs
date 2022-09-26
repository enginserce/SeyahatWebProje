using System.ComponentModel.DataAnnotations;

namespace SeyahatWebProje.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string imageURL { get; set; }
        public string Aciklama { get; set; }
    }
}
