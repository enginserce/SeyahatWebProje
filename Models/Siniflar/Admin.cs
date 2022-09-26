using System.ComponentModel.DataAnnotations;

namespace SeyahatWebProje.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
        public string Kullanici { get; set; }
        [Required(ErrorMessage = "Lütfen şifre giriniz.")]
        public string Sifre { get; set; }
    }
}
