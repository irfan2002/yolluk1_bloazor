namespace Yolluk_frontend_blazor.Services
{
    public class MudurlukToYollukService
    {
        public List<string> SeciliMudurlukler { get; set; } = new();
        public DateTime DilekceTarihi { get; set; }
        public string YollukMudurlukKod { get; set; } = string.Empty;
    }
}
