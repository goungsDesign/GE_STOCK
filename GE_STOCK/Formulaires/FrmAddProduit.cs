using GE_STOCK.Models;
using GE_STOCK.Repository;
using System.Text;

namespace GE_STOCK.Formulaires
{
    public partial class FrmAddProduit : Form
    {
        GE_STOCKDbContext _dbcontext;
        Produit? _currentProduit;
        public FrmAddProduit(GE_STOCKDbContext dbcontext)
        {
            InitializeComponent();
            _dbcontext = dbcontext;
            btnmodifierproduit.Enabled = false;
        }
        public FrmAddProduit(GE_STOCKDbContext dbcontext, Produit p)
        {
            InitializeComponent();
            _dbcontext = dbcontext;
            _currentProduit = p;
            btnEnregistrer.Enabled = false;
            showProduit(p);
        }

        private void showProduit(Produit p)
        {
            txtId.Text = p.Id.ToString();
            txtDescription.Text = p.Description.ToString();
            txtLibelle.Text = p.Nom;
            txtStockMaxi.Value = p.StockMaxi;
            txtStockSecurite.Value = p.SeuilStock;
            foreach (var item in comboCategorie.Items)
            {
                if (((CategoryProduit)item).Id == p.CategoryProduitId)
                {
                    comboCategorie.SelectedItem = item;
                    break;
                }
            }
            foreach (var item in comboProvenance.Items)
            {
                if (((Provenance)item).Id == p.ProvenanceId)
                {
                    comboProvenance.SelectedItem = item;
                    break;
                }
            }
            foreach (var item in comboConditionnement.Items)
            {
                if (item.ToString().Equals(p.Conditionnement))
                {
                    comboConditionnement.SelectedItem = item;
                    break;
                }
            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                UIHelper.ReleaseCapture();
                UIHelper.SendMessage(Handle, UIHelper.WM_NCLBUTTONDOWN, UIHelper.HT_CAPTION, 0);
            }
        }

        private void FrmAddProduit_Load(object sender, EventArgs e)
        {
            comboProvenance.DataSource = _dbcontext.Provenances.ToList();
            comboCategorie.DataSource = _dbcontext.CategoryProduits.ToList();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (txtLibelle.Text.Length < 2 || listBoxMolecules.Items.Count == 0)
            {
                MessageBox.Show("Le libellé et les molécules sont obligatoires!", "GE-STOCK", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Produit p = new Produit();
            p.DateCreation = DateTime.Now;
            p.StockMaxi = (int)txtStockMaxi.Value;
            p.SeuilStock = (int)txtStockSecurite.Value;
            p.Nom = txtLibelle.Text;
            p.Description = txtDescription.Text;
            if (comboProvenance.SelectedItem!=null)
                p.ProvenanceId = ((Provenance)comboProvenance.SelectedItem as Provenance).Id;
            if (comboCategorie.SelectedItem != null)
                p.CategoryProduitId = ((CategoryProduit)comboCategorie.SelectedItem as CategoryProduit).Id;
            if (comboConditionnement.SelectedItem != null)
                p.Conditionnement = ((string)comboConditionnement.SelectedItem);
            p.Molecules = getmolecules();
            try
            {
                _dbcontext.Produits.Add(p);
                _dbcontext.SaveChanges();
                MessageBox.Show("Produit enrégistré avec succès!", "GE-STOCK");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GE-STOCK");
            }
        }

        private string getmolecules()
        {
            StringBuilder molecules = new StringBuilder();
            for (int i = 0; i < listBoxMolecules.Items.Count; i++)
            {
                molecules.Append(listBoxMolecules.Items[i]);
                if (i < listBoxMolecules.Items.Count - 1)
                    molecules.Append(";");
            }

            return molecules.ToString();
        }

        private void btnmodifierproduit_Click(object sender, EventArgs e)
        {
            Produit p = this._currentProduit;
            p.ProvenanceId = ((Provenance)comboProvenance.SelectedItem).Id;
            p.DateCreation = DateTime.Now;
            p.CategoryProduitId = ((CategoryProduit)comboCategorie.SelectedItem).Id;
            p.StockMaxi = (int)txtStockMaxi.Value;
            p.SeuilStock = (int)txtStockSecurite.Value;
            p.Conditionnement = ((string)comboConditionnement.SelectedItem);
            p.Nom = txtLibelle.Text;
            p.Description = txtDescription.Text;
            try
            {
                _dbcontext.Produits.Add(p);
                _dbcontext.SaveChanges();
                MessageBox.Show("Produit modifié avec succès!", "GE-STOCK");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GE-STOCK");
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMolecule_Click(object sender, EventArgs e)
        {
            if (txtAdMolecule.Text.Length > 2)
            {
                listBoxMolecules.Items.Add(txtAdMolecule.Text);
            }

        }
    }
}
