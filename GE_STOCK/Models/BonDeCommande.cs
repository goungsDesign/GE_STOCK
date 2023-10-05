using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Models
{
    /// <summary>
    /// Demande de produit envoyée au magasinier
    /// </summary>
    public class BonDeCommande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Nom { get; set; } = string.Empty;
        public bool EstLivree { get; set; }
        /// <summary>
        /// Si la demande doit être livré le meme priorite=3. Très urgent
        /// Au plus dans 48 h.Priorité 2
        /// Plus de 48h.Priorite 1
        /// </summary>
        public byte Priorite { get; set; }
        public IList<DetailBonDeCommande> DetailBonDeCommandes { get; set; }
    }
}
