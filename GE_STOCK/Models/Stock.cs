using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Models
{
    /// <summary>
    /// Classe servant d'inventaire
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// Quantité à la création
        /// </summary>
        private int createQty;
        public void setCreateQty(int createQty)
        {
            this.createQty = createQty;
        }
        public int getCreateQty()=>this.createQty;
        public int Id { get; set; }
        public int ProduitId { get; set; }
        public virtual Produit Produit { get; set; }
        public string CodBarre =>$"{ProduitId}Inv{Id}";
     
        public string NomFournisseur { get; set; }
        public string TelFournisseur { get; set; }
        public string EmailFournisseur { get; set; }
        public DateTime? DateExpiration { get; set; }
        public string Emplacement { get; set; }
        public ICollection<OperationStock> OperationStocks { get; set; }
        public int QTY_Act { get; set; }
        public override string ToString()
        {
            return CodBarre;
        }

    }
}
