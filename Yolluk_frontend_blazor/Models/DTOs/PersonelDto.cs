using System.ComponentModel.DataAnnotations.Schema;

namespace Yolluk_frontend_blazor.Models.DTOs
{
    public class PersonelDto
    {
        public string SicilNo { get; set; }
        public string? TCNo { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public int? fkUnvanKod { get; set; }
        public int? fkYollukTuruKod { get; set; }
        public int? fkMudurlukServisSubeKod { get; set; }
        public string? fkMudurlukKod { get; set; }
        public string? fkYollukMudurlukKod { get; set; }
        public string? ePosta { get; set; }
        public bool? Aktif { get; set; }
        public DateTime? GirisTarihi { get; set; }
        public string? Aciklama { get; set; }
        public int? LimitTutar { get; set; }
        public int? izinOncekiYil { get; set; }
        public int? izinCariYil { get; set; }
        public bool? YollukFeragat { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? AyrilisTarihi { get; set; }
        [NotMapped] // EF'nin bu alanı veritabanına yansıtmaması için
        public decimal ToplamTutar { get; set; }
    }
}
