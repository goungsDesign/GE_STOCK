using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Models
{
    public class DetailBonDeCommande
    {
        public int Id { get; set; }
        public int BonDeCommandeId { get; set; }
        public BonDeCommande BonDeCommande { get; set; } 
        public Produit Produit { get; set; }
        public int ProduitId { get; set; }
        public int QTY { get; set; }
        public override string ToString()
        {
            return$"{ Produit}=={QTY}";
        }
    }
}
