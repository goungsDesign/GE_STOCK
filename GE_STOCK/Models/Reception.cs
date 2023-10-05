using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Models
{
    /// <summary>
    /// Réception d'une commande envoyée à un fournisseur
    /// </summary>
    public class Reception

    {
        public int Id { get; set; }
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }
        /// <summary>
        /// Date de réception
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;
        /// <summary>
        /// Indique si la livraison est conforme à la commande
        /// </summary>
        public bool Conforme { get; set; }
        public string Commentaire { get; set; }
      
    }
}
