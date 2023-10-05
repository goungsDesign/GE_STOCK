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

namespace GE_STOCK.Formulaires.Inventaires
{
    public partial class FrmOperationStock : Form
    {
        GE_STOCKDbContext _dbcontext;
        public FrmOperationStock(GE_STOCKDbContext context)
        {
            InitializeComponent();
            _dbcontext = context;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmOperationStock_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dbcontext.OperationStocks.Include("Stock.Produit").ToList();
            lbResult.Text = $"{dataGridView1.RowCount} ligne(s) trouvée(s)";
        }
    }
}
