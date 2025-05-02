namespace Yolluk_frontend_blazor.Models.DTOs
{
    public class YollukDto
    {
        public string Yil { get; set; }
        public string Ay { get; set; }
        public string SiraNo { get; set; }
        public string fkPersonelSicilNo { get; set; }
        public string? DilekceNo { get; set; }
        public DateTime DilekceTarihi { get; set; }
        public string? MakbuzNo { get; set; }
        public DateTime? MakbuzTarihi { get; set; }
        public int? fkGuzergahKod { get; set; }
        public int? fkFirmaKod { get; set; }
        public int? fkMusavirKod { get; set; }
        public int? fkHesapKod { get; set; }
        public DateTime? TahakkukTarihi { get; set; }
        public decimal? Tutar { get; set; }
        public DateTime? GirisTarihi { get; set; }
        public string fkGumrukKod { get; set; }
        public string? fkGorevMudurlukKod { get; set; }
        public int? fkTurKod { get; set; }
        public List<string> MudurlukKodlari { get; set; } = new();
    }
}
