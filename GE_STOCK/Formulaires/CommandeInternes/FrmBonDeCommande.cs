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
    public partial class FrmBonDeCommande : Form
    {
        List<DetailBonDeCommande> mBonDeCommandeList;
        BonDeCommande _currentBonDeCommande;
        GE_STOCKDbContext _dbContext;
        public FrmBonDeCommande(GE_STOCKDbContext context, List<DetailBonDeCommande> details)
        {
            InitializeComponent();
            showDetail(details);
            btnmodifierproduit.Enabled = false;
            mBonDeCommandeList = details;
            _dbContext = context;
        }
        public FrmBonDeCommande(GE_STOCKDbContext context, BonDeCommande BCommande)
        {
            InitializeComponent();

            showDetail(BCommande.DetailBonDeCommandes.ToList());
            btnmodifierproduit.Enabled = false;
            _currentBonDeCommande = BCommande;
            _dbContext = context;
        }

        private void showDetail(List<DetailBonDeCommande> details)
        {
            foreach (var item in details)
            {
                lstProduit.Items.Add(item);
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLibelle.Text) || txtLibelle.Text.Length < 5)
            {
                MessageBox.Show("Le libellé est obligatoire et doit être explicite!", "GE-STOCK-PHARMA");
                return;
            }

            BonDeCommande b = new BonDeCommande();
            b.DetailBonDeCommandes = mBonDeCommandeList;
            b.EstLivree = false;
            b.Priorite = (byte)trackBar1.Value;
            b.Nom = txtLibelle.Text;
            b.Date = DateTime.Now;
            try
            {
                _dbContext.BonDeCommandes.Add(b);
                _dbContext.SaveChanges();
                MessageBox.Show("Bon de commande enrégistré!", "GE-Stock-PHARMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                UIHelper.ReleaseCapture();
                UIHelper.SendMessage(Handle, UIHelper.WM_NCLBUTTONDOWN, UIHelper.HT_CAPTION, 0);
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                UIHelper.ReleaseCapture();
                UIHelper.SendMessage(Handle, UIHelper.WM_NCLBUTTONDOWN, UIHelper.HT_CAPTION, 0);
            }
        }
    }
}
