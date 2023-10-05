using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Models
{
    /// <summary>
    /// Détails de la commande envoyée à un fournisseur
    /// </summary>
    public class Details_commande
    {
        public int Id { get; set; }
        public int CommandeId { get; set; }
        public Produit Produit { get; set; }
        public int QTY { get; set; }
        public decimal PU { get; set; }
    

    }
}
