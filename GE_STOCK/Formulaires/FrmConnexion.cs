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
    public partial class FrmConnexion : Form
    {
        public User ConnectedUser { get; set; }
        public GE_STOCKDbContext _dbContext;
        public FrmConnexion(GE_STOCKDbContext Context)
        {
            InitializeComponent();
            _dbContext = Context;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Pour vider le textBox
            if (txtmotdepasse.Text == "Mot de passe")
            {
                txtmotdepasse.Text = "";
                txtmotdepasse.ForeColor = Color.WhiteSmoke;// Changer la couleur du text
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            // Pour vider le textBox
            if (txtNom.Text == "Nom d'utilisateur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.WhiteSmoke;// Changer la couleur du text
            }
        }

        private void FrmConnexion_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom d'utilisateur";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtmotdepasse_Leave(object sender, EventArgs e)
        {
            if (txtmotdepasse.Text == "")
            {
                txtmotdepasse.Text = "Mot de passe";
                txtmotdepasse.ForeColor = Color.Silver;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            var users=_dbContext.Users
                .Where(u=>u.Login.Equals(txtNom.Text)&&u.PWD.Equals(txtmotdepasse.Text));
            if(users.Count()!=1)
            {
                MessageBox.Show("Login ou mot de passe incorrecte!", "GE-STOCK");
                return;
            }

            this.ConnectedUser=users.First();
        }
    }
}
