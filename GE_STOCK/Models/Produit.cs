using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string? Codbarre { get; set; }
        public DateTime DateCreation { get; set; }
        public string? Description { get; set; }

        public string Molecules { get; set; }
        public CategoryProduit CategoryProduit { get; set; }
        public int CategoryProduitId { get; set; }
        public Provenance Provenance { get; set; }
        public int ProvenanceId { get; set; }
        
        public string   Conditionnement { get; set; }
        /// <summary>
        /// Stock de sécurité
        /// </summary>
        public int SeuilStock { get; set; }
        public int StockMaxi { get; set; }

        public override string ToString()
        {
            return Nom;
        }
        public override bool Equals(object? obj)
        {
            if(obj == null) return false;
            if(!(obj is Produit)) return false;
            return ((Produit)obj).Id == this.Id;
        }
    }
}
