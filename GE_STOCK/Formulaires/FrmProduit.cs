using GE_STOCK.Models;
using GE_STOCK.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GE_STOCK.Formulaires
{
    public partial class FrmProduit : Form
    {
        GE_STOCKDbContext _dbcontext;
        List<DetailBonDeCommande> _currentDetailBonDeCommandes;
        public FrmProduit(GE_STOCKDbContext dbcontext)
        {
            InitializeComponent();
            _dbcontext = dbcontext;
        }

        private void btnajouterproduit_Click(object sender, EventArgs e)
        {
            FrmAddProduit objAddPrd = new FrmAddProduit(_dbcontext);
            if (objAddPrd.ShowDialog() == DialogResult.OK)
            {
                remplirGrilleProduits();
            }
        }

        private void remplirGrilleProduits()
        {
            FrmAddProduit objAddPrd = new FrmAddProduit(_dbcontext);
            dataGridView1.DataSource = _dbcontext.Produits.ToList();
        }

        private void FrmProduit_Load(object sender, EventArgs e)
        {
            remplirGrilleProduits();
            var categories = _dbcontext.CategoryProduits.ToList();
            foreach (var category in categories)
            {
                comboCategorie.Items.Add(category);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtCodBarre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = _dbcontext.Produits
                    .Where(p => p.Codbarre != null && p.Codbarre.Equals(txtCodBarre.Text))
                    .ToList();
                lbResult.Text = $"{dataGridView1.RowCount} produit(s) trouvé(s)";
            }
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dbcontext.Produits
                    .Where(p => p.Nom.ToLower().StartsWith(txtRechercher.Text.ToLower()))
                    .ToList();
            lbResult.Text = $"{dataGridView1.RowCount} produit(s) trouvé(s)";
        }

        private void txtSearchByMolecule_KeyDown(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = _dbcontext.Produits
                    .Where(p => p.Molecules.ToLower().StartsWith(txtSearchByMolecule.Text.ToLower()))
                    .ToList();
            lbResult.Text = $"{dataGridView1.RowCount} produit(s) contient la molécule {txtSearchByMolecule.Text}";
        }

        private void comboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dbcontext.Produits
                               .Where(p => p.CategoryProduitId == ((CategoryProduit)comboCategorie.SelectedItem).Id)
                               .ToList();
            lbResult.Text = $"{dataGridView1.RowCount} produit(s) sont de catégorie ''{((CategoryProduit)comboCategorie.SelectedItem)}''";
        }

        private void chkActiverBonCoùmmande_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActiverBonCoùmmande.Checked)
            {
                PctBoxBon.Visible = true;
                labBonCommande.Visible = true;
            }
            else
            {
                PctBoxBon.Visible = false;
                labBonCommande.Visible = false;
                btnValiderBonDeCommande.Enabled = false;
                if(_currentDetailBonDeCommandes!=null)
                _currentDetailBonDeCommandes.Clear();
                labBonCommande.ResetText();
                PctBoxBon.Visible = false;
            }
        }

        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (chkActiverBonCoùmmande.Checked)
            {
                ajouterAuBonToolStripMenuItem.Enabled = true;

            }
            else
            {
                ajouterAuBonToolStripMenuItem.Enabled = false;
            }
        }

        private void ajouterAuBonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (_currentDetailBonDeCommandes is null)
                _currentDetailBonDeCommandes = new List<DetailBonDeCommande>();

            var produit = dataGridView1.CurrentRow.DataBoundItem as Produit;
            try
            {
                FrmQty objQty = new FrmQty("Quantité Rroduit");
                if (objQty.ShowDialog() == DialogResult.OK)
                {
                    if (_currentDetailBonDeCommandes.Find(d => d.Produit.Equals(produit)) == null)
                    {
                        _currentDetailBonDeCommandes.Add(new DetailBonDeCommande { Produit = produit, ProduitId = produit.Id, QTY = objQty.Qty_Selectionnee });
                        btnValiderBonDeCommande.Enabled = true;
                    }
                    else
                    {
                        foreach (var item in _currentDetailBonDeCommandes)
                        {
                            if (item.Equals(produit))
                                item.QTY += objQty.Qty_Selectionnee;
                        }
                    }
                    labBonCommande.Text = $"{_currentDetailBonDeCommandes.Count} produit(s) ajouté(s) au Bon";
                }

            }
            catch (ArgumentNullException)
            {
            }

        }

        private void btnValiderBonDeCommande_Click(object sender, EventArgs e)
        {
            if (chkActiverBonCoùmmande.Checked)
            {
                if (_currentDetailBonDeCommandes != null && _currentDetailBonDeCommandes.Count > 0)
                {
                    FrmBonDeCommande objDetail = new FrmBonDeCommande(this._dbcontext, _currentDetailBonDeCommandes);
                    objDetail.ShowDialog();
                }
            }
        }
    }
}
