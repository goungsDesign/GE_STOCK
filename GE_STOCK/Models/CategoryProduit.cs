namespace GE_STOCK.Models
{
    public class CategoryProduit
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Libelle;
        }
    }
}