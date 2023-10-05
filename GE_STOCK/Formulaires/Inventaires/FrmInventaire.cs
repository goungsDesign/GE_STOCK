using GE_STOCK.Models;
using GE_STOCK.Properties;
using GE_STOCK.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GE_STOCK.Formulaires.Inventaires
{
    public partial class FrmInventaire : Form
    {
        GE_STOCKDbContext _dbContext;
        List<Inventaire> _inventaireList;
        int invSeuilMaxiAtteint = 0;
        int invSeuilMinAtteint = 0;
        public FrmInventaire(GE_STOCKDbContext context)
        {
            InitializeComponent();
            _dbContext = context;
            _inventaireList = new StockRepository(_dbContext).getProduitStock();
            showInventory(_inventaireList);
        }

        private void showInventory(List<Inventaire> inventaireList)
        {
            try
            {
                dataGridView1.Rows.Clear();
                foreach (var detail in inventaireList)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = detail.Stock.ProduitId;
                    row.Cells[1].Value = detail.Stock.CodBarre;
                    row.Cells[2].Value = detail.Stock.Produit;
                    row.Cells[3].Value = detail.Qty;
                    row.Cells[4].Value = detail.Stock.Produit.Molecules;
                    row.Cells[5].Value = detail.Stock.Produit.Conditionnement;
                    row.Cells[6].Style.BackColor = getColorMaxi(detail);
                    row.Cells[7].Style.BackColor = getColorSeuil(detail);
                    dataGridView1.Rows.Add(row);
                    // dataGridViewProduitCommande.Rows.RemoveAt(dataGridViewProduitCommande.RowCount - 1);
                }
                lbResult.Text = $"{dataGridView1.RowCount} Inv trouvé(s)";
                var alerteSetting = Settings1.Default.AlerteVocale;
                if (alerteSetting)
                {
                    SpeechSynthesizer speech = new SpeechSynthesizer();
                    if (invSeuilMinAtteint >= 1)
                    {
                        speech.SpeakAsync($"Il y'a {invSeuilMinAtteint} inventaires dont le seuil minimum est atteint ou dépassés");
                    }
                    if (invSeuilMaxiAtteint >= 1)
                    {
                        speech.SpeakAsync($"Il y'a {invSeuilMaxiAtteint} inventaires dont le seuil maximum est atteint ou dépassés");
                    }
                }

            }
            catch (ArgumentNullException)
            {
            }
        }

        private Color getColorSeuil(Inventaire detail)
        {
            if (detail == null)
                return Color.Black;
            if (detail.Qty > detail.Stock.Produit.SeuilStock) return Color.Green;
            if (detail.Qty < detail.Stock.Produit.SeuilStock)
            {
                invSeuilMinAtteint++;
                return Color.Red;
            }
            if (detail.Qty == detail.Stock.Produit.SeuilStock)
            {
                invSeuilMinAtteint++;
                return Color.Orange;
            }
            return Color.Wheat;
        }
        private Color getColorMaxi(Inventaire detail)
        {
            if (detail == null)
                return Color.Black;
            if (detail.Qty > detail.Stock.Produit.StockMaxi) return Color.IndianRed;
            if (detail.Qty < detail.Stock.Produit.StockMaxi)
            {
                invSeuilMinAtteint++;
                return Color.Green;
            }
            if (detail.Qty == detail.Stock.Produit.StockMaxi)
            {
                invSeuilMinAtteint++;
                return Color.Orange;
            }
            return Color.Wheat;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtId_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
                return;
            string id = txtId.Text;
            var result = _inventaireList.Where(i => i.Produit.ToLower().StartsWith(txtId.Text.ToLower())).ToList();
            showInventory(result);
        }

        private void FrmInventaire_Load(object sender, EventArgs e)
        {
            comboProvenance.DataSource = _dbContext.Provenances.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
                return;
            string id = txtId.Text;
            var result = _inventaireList.Where(i => i.Produit.ToLower().StartsWith(txtId.Text.ToLower())).ToList();
            showInventory(result);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ComboTri.SelectedIndex == -1) return;
            switch (ComboTri.SelectedItem.ToString())
            {
                case "<":
                    var result1 = _inventaireList.Where(i => i.Qty < (int)txtQtyRecherchee.Value).ToList();
                    showInventory(result1);

                    break;
                case ">":
                    var result2 = _inventaireList.Where(i => i.Qty > (int)txtQtyRecherchee.Value).ToList();
                    showInventory(result2);
                    break;
                case ">=":
                    var result3 = _inventaireList.Where(i => i.Qty >= txtQtyRecherchee.Value).ToList();
                    showInventory(result3);
                    break;
                case "<=":
                    var result4 = _inventaireList.Where(i => i.Qty <= txtQtyRecherchee.Value).ToList();
                    showInventory(result4);
                    break;
            }
        }
    }
}
