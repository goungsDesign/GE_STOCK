using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Models
{
    /// <summary>
    /// Enregistre les entrées/sorties du stock
    /// </summary>
    public class OperationStock
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }
        public int Qty { get; set; }
        public DateTime Date { get; set; }
        public string Action { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// Décrit le contexte de l'opération
        /// </summary>
        public string Description { get; set; }
        public override string ToString()
        {
            return $"{Stock.Produit}-{StockId}";
        }
    }
}
