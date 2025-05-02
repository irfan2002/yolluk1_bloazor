namespace Yolluk_frontend_blazor.Models.DTOs
{
    public class UygunPersonelDto
    {
        public string SicilNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string MudurlukKodu { get; set; }
        public decimal ToplamTutar { get; set; }

        public string AdSoyad => $"{Ad} {Soyad}";
    }
}
