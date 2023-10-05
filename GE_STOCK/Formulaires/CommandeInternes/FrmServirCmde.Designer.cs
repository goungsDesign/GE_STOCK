namespace GE_STOCK.Formulaires.CommandeInternes
{
    partial class FrmServirCmde
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServirCmde));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel5 = new Panel();
            btnquitter = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btnFermer = new Button();
            BtnEnregistrer = new Button();
            label3 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label7 = new Label();
            dataGridViewInventaire = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            DateExpiration = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Qty_Act = new DataGridViewTextBoxColumn();
            Qty_Sortie = new DataGridViewTextBoxColumn();
            txtLibelleCommande = new TextBox();
            panel3 = new Panel();
            txtQtySortie = new NumericUpDown();
            label11 = new Label();
            btnAdd = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtPosition = new TextBox();
            txtQtyActuelle = new TextBox();
            txtExpDate = new TextBox();
            txtIdStock = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            dataGridViewProduitCommande = new DataGridView();
            produitId = new DataGridViewTextBoxColumn();
            Produit = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Etat = new DataGridViewImageColumn();
            txtIdCommande = new TextBox();
            label1 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventaire).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQtySortie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduitCommande).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnquitter);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(855, 63);
            panel5.TabIndex = 11;
            panel5.MouseDown += panel5_MouseDown;
            // 
            // btnquitter
            // 
            btnquitter.Dock = DockStyle.Right;
            btnquitter.FlatAppearance.BorderSize = 0;
            btnquitter.FlatStyle = FlatStyle.Flat;
            btnquitter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnquitter.Location = new Point(763, 0);
            btnquitter.Margin = new Padding(5);
            btnquitter.Name = "btnquitter";
            btnquitter.Size = new Size(90, 61);
            btnquitter.TabIndex = 2;
            btnquitter.Text = "X";
            btnquitter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(209, 6);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 41);
            label2.TabIndex = 1;
            label2.Text = "Sortie dépot";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnFermer);
            panel1.Controls.Add(BtnEnregistrer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 637);
            panel1.TabIndex = 12;
            // 
            // btnFermer
            // 
            btnFermer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFermer.Location = new Point(612, 559);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(227, 72);
            btnFermer.TabIndex = 37;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnEnregistrer.FlatStyle = FlatStyle.Flat;
            BtnEnregistrer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEnregistrer.Location = new Point(379, 559);
            BtnEnregistrer.Margin = new Padding(3, 4, 3, 4);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(227, 72);
            BtnEnregistrer.TabIndex = 36;
            BtnEnregistrer.Text = "Enrégistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(197, 4);
            label3.Name = "label3";
            label3.Size = new Size(270, 31);
            label3.TabIndex = 32;
            label3.Text = "Information commande";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dataGridViewInventaire);
            panel2.Controls.Add(txtLibelleCommande);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dataGridViewProduitCommande);
            panel2.Controls.Add(txtIdCommande);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(11, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 529);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(218, 392);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 34;
            label5.Text = "Information sortie";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(52, 213);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 33;
            label7.Text = "Inventaire liés";
            // 
            // dataGridViewInventaire
            // 
            dataGridViewInventaire.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventaire.Columns.AddRange(new DataGridViewColumn[] { Id, DateExpiration, Position, Qty_Act, Qty_Sortie });
            dataGridViewInventaire.Location = new Point(52, 244);
            dataGridViewInventaire.Name = "dataGridViewInventaire";
            dataGridViewInventaire.RowHeadersWidth = 51;
            dataGridViewInventaire.RowTemplate.Height = 29;
            dataGridViewInventaire.Size = new Size(748, 145);
            dataGridViewInventaire.TabIndex = 36;
            dataGridViewInventaire.RowHeaderMouseClick += dataGridViewInventaire_RowHeaderMouseClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // DateExpiration
            // 
            DateExpiration.HeaderText = "Exp.Date";
            DateExpiration.MinimumWidth = 6;
            DateExpiration.Name = "DateExpiration";
            DateExpiration.ReadOnly = true;
            DateExpiration.Width = 125;
            // 
            // Position
            // 
            Position.HeaderText = "Poisition";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.ReadOnly = true;
            Position.Width = 125;
            // 
            // Qty_Act
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            Qty_Act.DefaultCellStyle = dataGridViewCellStyle3;
            Qty_Act.HeaderText = "Qty_Act";
            Qty_Act.MinimumWidth = 6;
            Qty_Act.Name = "Qty_Act";
            Qty_Act.ReadOnly = true;
            Qty_Act.Width = 125;
            // 
            // Qty_Sortie
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 255, 192);
            Qty_Sortie.DefaultCellStyle = dataGridViewCellStyle4;
            Qty_Sortie.HeaderText = "Qty_Sortie";
            Qty_Sortie.MinimumWidth = 6;
            Qty_Sortie.Name = "Qty_Sortie";
            Qty_Sortie.ReadOnly = true;
            Qty_Sortie.Width = 125;
            // 
            // txtLibelleCommande
            // 
            txtLibelleCommande.Location = new Point(369, 25);
            txtLibelleCommande.Name = "txtLibelleCommande";
            txtLibelleCommande.ReadOnly = true;
            txtLibelleCommande.Size = new Size(354, 27);
            txtLibelleCommande.TabIndex = 35;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtQtySortie);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtPosition);
            panel3.Controls.Add(txtQtyActuelle);
            panel3.Controls.Add(txtExpDate);
            panel3.Controls.Add(txtIdStock);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(52, 404);
            panel3.Name = "panel3";
            panel3.Size = new Size(748, 90);
            panel3.TabIndex = 33;
            // 
            // txtQtySortie
            // 
            txtQtySortie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQtySortie.Location = new Point(491, 39);
            txtQtySortie.Name = "txtQtySortie";
            txtQtySortie.Size = new Size(73, 34);
            txtQtySortie.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(491, 20);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 42;
            label11.Text = "Qty.S";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Enabled = false;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(676, 21);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 49);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(277, 20);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 13;
            label10.Text = "Position";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(409, 20);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 12;
            label9.Text = "Qty.A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 20);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 11;
            label8.Text = "Exp";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(277, 43);
            txtPosition.Name = "txtPosition";
            txtPosition.ReadOnly = true;
            txtPosition.Size = new Size(126, 27);
            txtPosition.TabIndex = 10;
            // 
            // txtQtyActuelle
            // 
            txtQtyActuelle.Location = new Point(409, 43);
            txtQtyActuelle.Name = "txtQtyActuelle";
            txtQtyActuelle.ReadOnly = true;
            txtQtyActuelle.Size = new Size(76, 27);
            txtQtyActuelle.TabIndex = 9;
            // 
            // txtExpDate
            // 
            txtExpDate.Location = new Point(132, 43);
            txtExpDate.Name = "txtExpDate";
            txtExpDate.ReadOnly = true;
            txtExpDate.Size = new Size(139, 27);
            txtExpDate.TabIndex = 7;
            // 
            // txtIdStock
            // 
            txtIdStock.Location = new Point(16, 43);
            txtIdStock.Name = "txtIdStock";
            txtIdStock.ReadOnly = true;
            txtIdStock.Size = new Size(110, 27);
            txtIdStock.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 20);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Id stock";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.boncommande;
            pictureBox1.Location = new Point(17, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 114);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(513, 55);
            label4.Name = "label4";
            label4.Size = new Size(210, 28);
            label4.TabIndex = 33;
            label4.Text = "Produits commandés";
            // 
            // dataGridViewProduitCommande
            // 
            dataGridViewProduitCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduitCommande.Columns.AddRange(new DataGridViewColumn[] { produitId, Produit, Qty, Etat });
            dataGridViewProduitCommande.EnableHeadersVisualStyles = false;
            dataGridViewProduitCommande.Location = new Point(153, 88);
            dataGridViewProduitCommande.Name = "dataGridViewProduitCommande";
            dataGridViewProduitCommande.RowHeadersWidth = 51;
            dataGridViewProduitCommande.RowTemplate.Height = 29;
            dataGridViewProduitCommande.Size = new Size(647, 114);
            dataGridViewProduitCommande.TabIndex = 5;
            dataGridViewProduitCommande.RowHeaderMouseClick += dataGridViewProduitCommande_RowHeaderMouseClick;
            // 
            // produitId
            // 
            produitId.HeaderText = "IdProduit";
            produitId.MinimumWidth = 6;
            produitId.Name = "produitId";
            produitId.Width = 80;
            // 
            // Produit
            // 
            Produit.HeaderText = "Libellé";
            Produit.MinimumWidth = 6;
            Produit.Name = "Produit";
            Produit.ReadOnly = true;
            Produit.Width = 250;
            // 
            // Qty
            // 
            Qty.HeaderText = "Quantité";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            Qty.Width = 70;
            // 
            // Etat
            // 
            Etat.HeaderText = "Etat_sortie";
            Etat.MinimumWidth = 6;
            Etat.Name = "Etat";
            Etat.ReadOnly = true;
            Etat.Resizable = DataGridViewTriState.True;
            Etat.SortMode = DataGridViewColumnSortMode.Automatic;
            Etat.Width = 80;
            // 
            // txtIdCommande
            // 
            txtIdCommande.Location = new Point(253, 25);
            txtIdCommande.Name = "txtIdCommande";
            txtIdCommande.ReadOnly = true;
            txtIdCommande.Size = new Size(110, 27);
            txtIdCommande.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 32);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 1;
            label1.Text = "Id commande";
            // 
            // FrmServirCmde
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 700);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmServirCmde";
            Text = "FrmServirCmde";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventaire).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQtySortie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduitCommande).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Button btnquitter;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtEmail;
        private TextBox txtTel;
        private TextBox txtIdCommande;
        private Label label1;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewProduitCommande;
        private Label label5;
        private Panel panel3;
        private TextBox txtExpDate;
        private TextBox txtIdStock;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox txtLibelleCommande;
        private Label label7;
        private DataGridView dataGridViewInventaire;
        private TextBox txtPosition;
        private TextBox txtQtyActuelle;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnAdd;
        private Button btnFermer;
        private Button BtnEnregistrer;
        private NumericUpDown txtQtySortie;
        private Label label11;
        private DataGridViewTextBoxColumn produitId;
        private DataGridViewTextBoxColumn Produit;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewImageColumn Etat;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn DateExpiration;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Qty_Act;
        private DataGridViewTextBoxColumn Qty_Sortie;
    }
}