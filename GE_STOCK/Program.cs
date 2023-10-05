using GE_STOCK.Formulaires;
using GE_STOCK.Models;
using GE_STOCK.Properties;
using GE_STOCK.Repository;

namespace GE_STOCK
{
    internal static class Program
    {
        private static readonly int Frm;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var context=new Repository.GE_STOCKDbContext(Settings1.Default.Cnx))
            {
                if(!context.Roles.Any())
                {
                    try
                    {
                        context.Roles.Add(new Role { Libelle = "Admin", Description = "Administrateur du système" });
                        context.Roles.Add(new Role { Libelle = "Magasinier", Description = "Gestionnaire du magasin" });
                        context.Roles.Add(new Role { Libelle = "Gestionnaire", Description = "Gestionnaire du stock" }); 
                        context.SaveChanges();
                    }
                    catch (Exception ex) {MessageBox.Show(ex.Message,"GE-STOCK");}
                }
                if (!context.Users.Any())
                {
                    try
                    {
                        context.Users.Add(new User { Login = "Admin", PWD = "Admin", Role = context.Roles.First() });
                    }catch (Exception ex) { MessageBox.Show(ex.Message, "GE-STOCK"); }
                }
                if (!context.Provenances.Any())
                {
                    context.Provenances.Add(new Provenance { Nom = "France", Ville = "Nancy" });
                    context.Provenances.Add(new Provenance { Nom = "Inde", Ville = "New Dehly" });
                }
                if (!context.CategoryProduits.Any())
                {
                    context.CategoryProduits.Add(new CategoryProduit {Libelle = "Anti-Biotique", Description = "Antibiotique" });
                    context.CategoryProduits.Add(new CategoryProduit { Libelle= "Fortifiant", Description = "Médicaments Foritifiant" });
                }
                if (!context.TypeFournisseurs.Any())
                {
                    context.TypeFournisseurs.Add(new TypeFournisseur { Libelle = "Fournisseur Normal", Description = "Fournisseur Bio étique" });
                    context.TypeFournisseurs.Add(new TypeFournisseur { Libelle = "Fournisseur Générique", Description = "Fournisseur Moba" });
                    context.TypeFournisseurs.Add(new TypeFournisseur { Libelle = "Fournisseur Occasionnel", Description = "Fournisseur d'occasions" });
                }
                context.SaveChanges();
                if (!context.Produits.Any())
                {
                    context.Produits.Add(new Produit
                    {
                        CategoryProduit = context.CategoryProduits.First(),
                        Codbarre = "test001",
                        Conditionnement = "Sirop",
                        DateCreation = DateTime.Now,
                        Description = "test",
                        Molecules = "Mélanine",
                        Nom = "Colamine",
                        Provenance = context.Provenances.First(),
                        SeuilStock = 10,
                        StockMaxi = 100,
                    });
                    context.Produits.Add(new Produit
                    {
                        CategoryProduit = context.CategoryProduits.First(),
                        Codbarre = "test002",
                        Conditionnement = "Sirop",
                        DateCreation = DateTime.Now,
                        Description = "test",
                        Molecules = "Artémisia",
                        Nom = "Artémether",
                        Provenance = context.Provenances.First(),
                        SeuilStock = 10,
                        StockMaxi = 100
                    });
                }
                context.SaveChanges();
                FrmConnexion objConnexion = new FrmConnexion(context);
                if (objConnexion.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmPrincipal(context,objConnexion.ConnectedUser));
                }
            }
           
           
        }
    }
}