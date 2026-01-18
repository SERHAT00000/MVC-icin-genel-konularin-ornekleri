using System.ComponentModel.DataAnnotations;// VALIDATION


namespace WEB_Kursu.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="İsim lalnı boş geçilemez"), StringLength(50)]
        public string Ad { get; set; }
        [Required, StringLength(50)]
        public string Soyad { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,Phone(ErrorMessage ="Geçersiz telefon formatı")]
        public string Telefon { get; set; }
        [Required(ErrorMessage ="tc boş geçilemez"),
            Display(Name ="Tc Kimlik Numarası"),
            MinLength(11,ErrorMessage ="minimum 11 karakteer olmalıdır"),
            MaxLength(11,ErrorMessage ="Maksimum 11 karakter olamlıdır")]
        public string TcNo { get; set; }
        [Required]
       
        public DateTime DogumTarihi { get; set; }
        [Required]
        public string KullaniciAdi { get; set; }
        [Required(ErrorMessage ="{0} alanı boş geçilemez"),
            StringLength(15,ErrorMessage ="{0}{2} karakterden az olamaz", MinimumLength =5)]

        public string Sifre { get; set; }
        [Required,
            Compare("Sifre")]//compare verilen parametreyle yazıldığı yerdeki parametreyi karşılaştırır
        public string SifreTekrar { get; set; }
    }
}
