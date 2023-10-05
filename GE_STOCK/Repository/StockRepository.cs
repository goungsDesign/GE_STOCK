using GE_STOCK.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Repository
{
    public class StockRepository
    {
        GE_STOCKDbContext _dbContext;
        public StockRepository(GE_STOCKDbContext context) {
            _dbContext = context;

        }
        /// <summary>
        /// Retourne la quantité actuelle de l'inventaire en stock
        /// </summary>
        /// <param name="IdStock"></param>
        /// <returns></returns>
        public int getStockActuel(int IdStock)
        {
           var groupByAction =
             from action in _dbContext.OperationStocks.Where(item=>item.Id==IdStock)
              group action by action.Action into newGroup
              select newGroup;
              int Entrees = 0;
              int sorties = 0;
            foreach (var nameGroup in groupByAction)
            {
                Console.WriteLine($"Key: {nameGroup.Key}");
                if (nameGroup.Key.Equals("E"))
                    foreach (var item in nameGroup)
                    {
                        Entrees += item.Qty;
                    }
                if (nameGroup.Key.Equals("SC"))
                    foreach (var item in nameGroup)
                    {
                        sorties += item.Qty;
                    }
            }
            return Entrees-sorties;// - opSort ;
        }

        public List<Inventaire> getProduitStock()
        {
            List<Inventaire>myList = new List<Inventaire>();
            var groupByAction =
           from stock in _dbContext.Stocks.Include("Produit").Include(o => o.OperationStocks).ToList().Distinct()
           group stock by stock into newGroup
           
           select newGroup;
            int i = 0;
            foreach (var nameGroup in groupByAction)
            {
                myList.Add(
                new Inventaire
                {
                    StockId = nameGroup.Key.Id,
                    Qty = nameGroup.Key.OperationStocks.Where(o => o.Action.Equals("E")).Sum(c => c.Qty) - nameGroup.Key.OperationStocks.Where(o => o.Action.Equals("SC")).Sum(c => c.Qty),
                    CodeBarre = nameGroup.Key.CodBarre,
                    Conditionnement = nameGroup.Key.Produit.Conditionnement,
                    Molecules = nameGroup.Key.Produit.Molecules,
                    Produit = nameGroup.Key.Produit.Nom,
                    Stock = nameGroup.Key
                });
                i++;
            }

            return myList;
        }

    }
}
