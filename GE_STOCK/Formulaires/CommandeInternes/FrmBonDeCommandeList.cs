using GE_STOCK.Formulaires.CommandeInternes;
using GE_STOCK.Models;
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

namespace GE_STOCK.Formulaires
{
    public partial class FrmBonDeCommandeList : Form
    {
        GE_STOCKDbContext _dbContext;
        public FrmBonDeCommandeList(GE_STOCKDbContext context)
        {
            InitializeComponent();
            _dbContext = context;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmBonDeCommandeList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dbContext.BonDeCommandes.ToList();
            labRésultat.Text = $"{dataGridView1.Rows.Count} Bons trouvé(s)";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var bon = dataGridView1.CurrentRow.DataBoundItem as BonDeCommande;
            if (bon is null) return;
            listBoxDetailBondeCommande.DataSource = _dbContext.DetailBonDeCommandes
                .Where(d => d.BonDeCommandeId == bon.Id)
                .Include(p => p.Produit)
                .ToList();
            labResultDetailBon.Text = $"{listBoxDetailBondeCommande.Items.Count} produit(s)";
        }

        private void servirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cmde = dataGridView1.CurrentRow.DataBoundItem as BonDeCommande;
            if (cmde is BonDeCommande)
            {
                FrmServirCmde frmServirCmde = new FrmServirCmde(_dbContext, cmde);
                if(frmServirCmde.ShowDialog()==DialogResult.Yes) {
                
                }
            }
        }
    }
}
