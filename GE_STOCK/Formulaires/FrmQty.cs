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
    public partial class FrmQty : Form
    {
        public FrmQty(string Libelle)
        {
            InitializeComponent();
        }
        public  int Qty_Selectionnee { get; set; }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                UIHelper.ReleaseCapture();
                UIHelper.SendMessage(Handle, UIHelper.WM_NCLBUTTONDOWN, UIHelper.HT_CAPTION, 0);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Qty_Selectionnee =(int) txtQty.Value;
        }
    }
}
