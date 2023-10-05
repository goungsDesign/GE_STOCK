using GE_STOCK.Models;
using GE_STOCK.Repository;
using System;

namespace GE_STOCK.Formulaires.Approvisionnements
{

    public partial class FrmApprParticulier : Form
    {
        List<Stock> _currentLstStocks;
        GE_STOCKDbContext _dbContext;
        Produit _cuurentProduit;
        public FrmApprParticulier(Repository.GE_STOCKDbContext context)
        {
            InitializeComponent();
            _currentLstStocks = new List<Stock>();
            _dbContext = context;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomprenom.Text))
            {
                MessageBox.Show("Le nom du fournisseur est obligatoire");
                return;
            }
            if (string.IsNullOrEmpty(txtTel.Text) && string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Aumoins un moyen de contact est requis");
                return;
            }
            if (string.IsNullOrEmpty(txtIdProduit.Text))
            {
                MessageBox.Show("L'identifiant du produit est requis");
                return;
            }
            Stock stock = new Stock();
            stock.NomFournisseur = txtNomprenom.Text;
            stock.EmailFournisseur = txtEmail.Text;
            stock.TelFournisseur = txtTel.Text;
            stock.setCreateQty( (int)txtQty.Value);
            stock.Emplacement = txtPlace.Text;
            stock.Produit = _cuurentProduit;
            stock.ProduitId = _cuurentProduit.Id;
            if (txtDateExp.Checked)
            {
                stock.DateExpiration = txtDateExp.Value;
            }
            _currentLstStocks.Add(stock);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _currentLstStocks;
            lbResult.Text = $"{dataGridView1.RowCount} inventaire(s)";
            AnnulerChampProduit();
        }

        private void AnnulerChampProduit()
        {
            txtIdProduit.ResetText();
            txtLibelleProduit.ResetText();
            txtQty.Value= 0;
            txtPlace.ResetText();
            txtDateExp.Value=DateTime.Now;
            _cuurentProduit = null;
        }

        private void txtIdProduit_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProduit.Text))
                return;
            try
            {

                var produit = _dbContext.Produits.Find(Convert.ToInt32(txtIdProduit.Text));
                txtLibelleProduit.Text = produit.Nom;
                _cuurentProduit = produit;
                btnAdd.Enabled = true;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Produit non existant", "GE-PHARMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLibelleProduit.Text = _dbContext.Produits.Find(Convert.ToInt32(txtIdProduit.Text)).Nom;
                btnAdd.Enabled = false;
            }

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            cancelAll();
        }

        private void cancelAll()
        {
            txtDateExp.Value = DateTime.Now;
            txtDateExp.Checked = false;
            txtEmail.ResetText();
            txtTel.ResetText();
            txtQty.Value = txtQty.Minimum;
            txtIdProduit.ResetText();
            txtLibelleProduit.ResetText();
            txtNomprenom.ResetText();
            txtPlace.ResetText();
            btnAdd.Enabled = false;
            _cuurentProduit = null;
            _currentLstStocks = new List<Stock>();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            foreach (var item in _currentLstStocks)
            {
                try
                {
                    _dbContext.Stocks.Add(item);
                    OperationStock operationStock = new OperationStock();
                    operationStock.StockId = item.Id;
                    operationStock.Qty = item.getCreateQty();
                    operationStock.Date = DateTime.Now;
                    operationStock.Action = "E";
                    operationStock.Description = "Création de stock";
                    _dbContext.OperationStocks.Add(operationStock);                  
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                _dbContext.SaveChanges();
                MessageBox.Show($"Produit {_cuurentProduit} approvisionné avec succès!", "GE-PHARMACIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cancelAll();
            }
        }
    }
}
