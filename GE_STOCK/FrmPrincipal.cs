using GE_STOCK.Formulaires;
using GE_STOCK.Formulaires.Approvisionnements;
using GE_STOCK.Formulaires.Inventaires;
using GE_STOCK.Models;
using GE_STOCK.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GE_STOCK
{
    public partial class FrmPrincipal : Form
    {
        GE_STOCKDbContext _dbcontext;
        User _utlisateurCourant;
        public FrmPrincipal(GE_STOCKDbContext context, User user)
        {
            InitializeComponent();
            _dbcontext = context;
            labUser.Text = $"{user.Login} connecté à :{DateTime.Now}";
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter l'application?", "GE-PHARMACIE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            if (btnReduire.Text.Equals("-"))
            {
                this.WindowState = FormWindowState.Normal;
                btnReduire.Text = "O";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnReduire.Text = "-";
            }
        }

        private void btnProduits_Click(object sender, EventArgs e)
        {
            FrmProduit objFormProduits = new FrmProduit(this._dbcontext);
            LoadForm(objFormProduits);
        }
        void dessiner(Panel pan)
        {
            Graphics d = pan.CreateGraphics();
            Pen p = new Pen(Brushes.Black, 5);
            Rectangle gradientRect = new Rectangle(10, 20, 3, 1);
            HatchBrush l = new HatchBrush(HatchStyle.DiagonalBrick, Color.LightGray, Color.White);
            d.FillRectangle(l, pan.ClientRectangle);
            d.DrawRectangle(p, pan.ClientRectangle);

        }

        public Form LoadForm(Object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
                dessiner(MainPanel);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
            return f;

        }

        private void rechercherToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBonDeCommandeList objListBon = new FrmBonDeCommandeList(this._dbcontext);
            LoadForm(objListBon);
        }

        private void approvisionnementToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void approvisionnementParticulierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApprParticulier objCommandeParticulier = new FrmApprParticulier(this._dbcontext);
            objCommandeParticulier.ShowDialog();

        }

        private void rechercherToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmBonDeCommandeList objListBon = new FrmBonDeCommandeList(this._dbcontext);
            LoadForm(objListBon);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FrmInventaire obj = new FrmInventaire(this._dbcontext);
            LoadForm(obj);
        }

        private void opérationsSurStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperationStock objstockOp = new FrmOperationStock(this._dbcontext);
            LoadForm(objstockOp);
        }
    }
}
