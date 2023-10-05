using GE_STOCK.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Repository
{
    public class GE_STOCKDbContext:DbContext
    {
        public GE_STOCKDbContext()
        {
            
        }
        public GE_STOCKDbContext(string cnx):base(cnx) { }
       
        public DbSet<User>Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<CategoryProduit> CategoryProduits { get; set; }
         public DbSet<Provenance> Provenances { get; set; }
        public DbSet<BonDeCommande> BonDeCommandes { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Reception> Reception { get; set; }
        public DbSet<DetailBonDeCommande> DetailBonDeCommandes { get; set; }
        public DbSet<Details_commande> Details_Commandes { get; set; }
        public DbSet<Fournisseur> Fournisseur { get; set; }
        public DbSet<OperationStock> OperationStocks { get; set; }
        public DbSet<TypeFournisseur> TypeFournisseurs { get; set; }
        public DbSet<Stock> Stocks { get; set; }

    }
}
