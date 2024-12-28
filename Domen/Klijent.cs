namespace Domen
{
    public class Klijent
    {
        public long Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrTelefona { get; set; }
        public Mesto Mesto { get; set; }
    }
}