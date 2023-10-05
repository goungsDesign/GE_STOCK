using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Models
{
    /// <summary>
    /// Commande envoyé à un fournisseur
    /// </summary>
    public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Fournisseur Fournisseur { get; set; }
        public int FournisseurId { get; set; }
        /// <summary>
        /// Total hors taxe
        /// </summary>
        public decimal Total_HT { get; set; }
        public int TVA => 19;
        /// <summary>
        /// Toute taxes comprises
        /// </summary>
        public decimal TTC { get; set; }
    }
}
