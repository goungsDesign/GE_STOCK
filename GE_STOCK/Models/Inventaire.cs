using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Models
{
    public class Inventaire
    {
        public int StockId { get; set; }
        public Stock Stock { get; set; }
        /// <summary>
        /// Code barre du stock
        /// </summary>
        public string CodeBarre { get; set; }
        public string Produit { get; set; }
        public string Molecules { get; set; }
        public string Conditionnement { get; set; }
        public int Qty { get; set; }

    }
}
