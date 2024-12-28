namespace Domen
{
    public class Mesto
    {
        public long Ptt { get; set; }
        public string Naziv { get; set; }

        public override string? ToString()
        {
            return Naziv;
        }
    }
}