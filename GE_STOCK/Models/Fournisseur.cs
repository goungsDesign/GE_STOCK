namespace GE_STOCK.Models
{
    public class Fournisseur
    {
        public int Id { get; set; }
        public int TypeFournisseurId { get; set; }
        public TypeFournisseur TypeFrounisseur { get; set; }
        public string Nom { get; set; }
    }
}