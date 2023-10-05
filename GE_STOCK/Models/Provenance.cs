namespace GE_STOCK.Models
{
    public class Provenance
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string   Ville { get; set; }
        public override string ToString()
        {
            return $"{Ville},{Nom}";
        }
    }
}