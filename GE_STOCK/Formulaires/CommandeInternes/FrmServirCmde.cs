using GE_STOCK.Models;
using GE_STOCK.Properties;
using GE_STOCK.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GE_STOCK.Formulaires.CommandeInternes
{
    public partial class FrmServirCmde : Form
    {
        GE_STOCKDbContext _dbContext;
        Stock _currentStock;
        List<OperationStock> _lstoperationStocks;
        public FrmServirCmde(GE_STOCKDbContext gE_STOCKDbContext, Models.BonDeCommande cmde)
        {
            InitializeComponent();
            _dbContext = gE_STOCKDbContext;
            showBonDetails(cmde);
            txtIdCommande.Text = cmde.Id.ToString();
            txtLibelleCommande.Text = cmde.Nom;
            _lstoperationStocks = new List<OperationStock>();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UIHelper.ReleaseCapture();
                UIHelper.SendMessage(Handle, UIHelper.WM_NCLBUTTONDOWN, UIHelper.HT_CAPTION, 0);
            }
        }
        void showBonDetails(BonDeCommande BonC)
        {
            try
            {
                if (BonC.DetailBonDeCommandes != null)
                    foreach (var detail in BonC.DetailBonDeCommandes)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewProduitCommande.Rows[0].Clone(); ;
                        row.Cells[0].Value = detail.ProduitId;
                        row.Cells[1].Value = detail.Produit;
                        row.Cells[2].Value = detail.QTY;
                        row.Cells[3].Value = Resources.valid_orange;
                        dataGridViewProduitCommande.Rows.Add(row);
                        // dataGridViewProduitCommande.Rows.RemoveAt(dataGridViewProduitCommande.RowCount - 1);
                    }
                // dataGridViewProduitCommande.DataSource = cmds.ToList();
            }
            catch (ArgumentNullException)
            {
            }
        }

        private void dataGridViewProduitCommande_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var produitId = (int)dataGridViewProduitCommande.Rows[e.RowIndex].Cells[0].Value;
            List<Stock> inventaires = _dbContext.Stocks.Where(i => i.ProduitId == produitId).ToList();
            foreach (var item in inventaires)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewInventaire.Rows[0].Clone();
                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.DateExpiration?.ToShortDateString();
                row.Cells[2].Value = item.Emplacement;
                int value = new StockRepository(this._dbContext).getStockActuel(item.Id);
                row.Cells[3].Value = value;
                row.Cells[4].Value = 0;
                dataGridViewInventaire.Rows.Add(row);
            }
        }

        private void dataGridViewInventaire_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewInventaire.SelectedRows is null)
                return;

            txtIdStock.Text = dataGridViewInventaire.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtExpDate.Text = dataGridViewInventaire.Rows[e.RowIndex].Cells[1]?.Value.ToString();
            txtPosition.Text = dataGridViewInventaire.Rows[e.RowIndex].Cells[2]?.Value.ToString();
            txtQtyActuelle.Text = dataGridViewInventaire.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnAdd.Enabled = true;
            try
            {
                _currentStock = _dbContext.Stocks.Find(Convert.ToInt32(txtIdStock.Text));
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int stockSortie = (int)txtQtySortie.Value;
            int stockactuel = new StockRepository(_dbContext).getStockActuel(_currentStock.Id);
            if (stockactuel < stockSortie)
            {
                MessageBox.Show("La quantité sortie ne peut être supérieure à la quantité en stock", "GE-PHARMACIE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            _lstoperationStocks.Add(new OperationStock
            {
                Action = "SC",
                StockId = _currentStock.Id,
                Date = DateTime.Now,
                Description = "Sortie sur commande",
                Qty = stockSortie,
                UserId = 1
            });
            SetLigneColor(stockSortie);
            this._currentStock = null;
            txtIdStock.ResetText();
            txtExpDate.ResetText();
            txtQtyActuelle.ResetText();
            txtQtySortie.ResetText();
            txtPosition.ResetText();
        }

        private void SetLigneColor(int Qtyproduit)
        {
            for (int i = 0; i < dataGridViewProduitCommande.Rows.Count - 1; i++)
            {
                var ligne = dataGridViewProduitCommande.Rows[i];
                if ((int)dataGridViewProduitCommande.Rows[i].Cells[0].Value == _currentStock.ProduitId)
                    if (Qtyproduit >= (int)dataGridViewProduitCommande.Rows[i].Cells[2].Value)
                        ligne.Cells[3].Value = Resources.valid;
                    else
                        ligne.Cells[3].Value = Resources.valid_orange;
            }
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in _lstoperationStocks)
                {
                    _dbContext.OperationStocks.Add(item);
                }
                _dbContext.SaveChanges();
                MessageBox.Show("Sortie de produit(s) enrégistré!", "GE-PHARMACIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
