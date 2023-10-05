namespace GE_STOCK.Formulaires
{
    partial class FrmProduit
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduit));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel5 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btnmodifierproduit = new Button();
            btnValiderBonDeCommande = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            txtRechercher = new TextBox();
            panel4 = new Panel();
            chkActiverBonCoùmmande = new CheckBox();
            labBonCommande = new Label();
            PctBoxBon = new PictureBox();
            lbResult = new Label();
            label6 = new Label();
            txtSearchByMolecule = new TextBox();
            label5 = new Label();
            comboCategorie = new ComboBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCreationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            provenanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            conditionnementDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            seuilStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockMaxiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ajouterAuBonToolStripMenuItem = new ToolStripMenuItem();
            produitBindingSource = new BindingSource(components);
            btnAddProduit = new Button();
            label1 = new Label();
            label3 = new Label();
            btnFermer = new Button();
            txtCodBarre = new TextBox();
            label13 = new Label();
            toolTip1 = new ToolTip(components);
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctBoxBon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(990, 69);
            panel5.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(248, 18);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(363, 41);
            label2.TabIndex = 1;
            label2.Text = " Formulaire des produits";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnmodifierproduit
            // 
            btnmodifierproduit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnmodifierproduit.FlatStyle = FlatStyle.Flat;
            btnmodifierproduit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmodifierproduit.Location = new Point(276, 491);
            btnmodifierproduit.Margin = new Padding(3, 4, 3, 4);
            btnmodifierproduit.Name = "btnmodifierproduit";
            btnmodifierproduit.Size = new Size(227, 72);
            btnmodifierproduit.TabIndex = 10;
            btnmodifierproduit.Text = "Fiche";
            btnmodifierproduit.UseVisualStyleBackColor = true;
            // 
            // btnValiderBonDeCommande
            // 
            btnValiderBonDeCommande.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnValiderBonDeCommande.Enabled = false;
            btnValiderBonDeCommande.FlatStyle = FlatStyle.Flat;
            btnValiderBonDeCommande.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnValiderBonDeCommande.Location = new Point(509, 491);
            btnValiderBonDeCommande.Margin = new Padding(3, 4, 3, 4);
            btnValiderBonDeCommande.Name = "btnValiderBonDeCommande";
            btnValiderBonDeCommande.Size = new Size(227, 72);
            btnValiderBonDeCommande.TabIndex = 11;
            btnValiderBonDeCommande.Text = "Valider Bon";
            btnValiderBonDeCommande.UseVisualStyleBackColor = true;
            btnValiderBonDeCommande.Click += btnValiderBonDeCommande_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(12, 114);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 4);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 590);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 10);
            panel2.TabIndex = 13;
            // 
            // txtRechercher
            // 
            txtRechercher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRechercher.AutoCompleteCustomSource.AddRange(new string[] { "Id", "Nom", "Prenom", "Adresse" });
            txtRechercher.BorderStyle = BorderStyle.FixedSingle;
            txtRechercher.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRechercher.Location = new Point(737, 77);
            txtRechercher.Margin = new Padding(3, 4, 3, 4);
            txtRechercher.Name = "txtRechercher";
            txtRechercher.Size = new Size(234, 27);
            txtRechercher.TabIndex = 15;
            txtRechercher.TextChanged += txtRechercher_TextChanged;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(chkActiverBonCoùmmande);
            panel4.Controls.Add(labBonCommande);
            panel4.Controls.Add(PctBoxBon);
            panel4.Controls.Add(lbResult);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtSearchByMolecule);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(comboCategorie);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(12, 138);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(959, 336);
            panel4.TabIndex = 16;
            // 
            // chkActiverBonCoùmmande
            // 
            chkActiverBonCoùmmande.AutoSize = true;
            chkActiverBonCoùmmande.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkActiverBonCoùmmande.Image = Properties.Resources.savebottletiny1;
            chkActiverBonCoùmmande.ImageAlign = ContentAlignment.TopRight;
            chkActiverBonCoùmmande.Location = new Point(347, 42);
            chkActiverBonCoùmmande.Name = "chkActiverBonCoùmmande";
            chkActiverBonCoùmmande.Size = new Size(145, 32);
            chkActiverBonCoùmmande.TabIndex = 27;
            chkActiverBonCoùmmande.Text = "+Bon Cmde        ";
            chkActiverBonCoùmmande.TextAlign = ContentAlignment.MiddleRight;
            chkActiverBonCoùmmande.UseVisualStyleBackColor = true;
            chkActiverBonCoùmmande.CheckedChanged += chkActiverBonCoùmmande_CheckedChanged;
            // 
            // labBonCommande
            // 
            labBonCommande.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labBonCommande.Location = new Point(710, 311);
            labBonCommande.Name = "labBonCommande";
            labBonCommande.Size = new Size(230, 20);
            labBonCommande.TabIndex = 26;
            labBonCommande.Text = "//";
            labBonCommande.Visible = false;
            // 
            // PctBoxBon
            // 
            PctBoxBon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PctBoxBon.Image = Properties.Resources.boncommande;
            PctBoxBon.Location = new Point(664, 306);
            PctBoxBon.Name = "PctBoxBon";
            PctBoxBon.Size = new Size(40, 28);
            PctBoxBon.SizeMode = PictureBoxSizeMode.StretchImage;
            PctBoxBon.TabIndex = 25;
            PctBoxBon.TabStop = false;
            PctBoxBon.Visible = false;
            // 
            // lbResult
            // 
            lbResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.Location = new Point(123, 309);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(21, 20);
            lbResult.TabIndex = 24;
            lbResult.Text = "//";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 309);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 23;
            label6.Text = "Résultat(s):";
            // 
            // txtSearchByMolecule
            // 
            txtSearchByMolecule.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchByMolecule.AutoCompleteCustomSource.AddRange(new string[] { "Id", "Nom", "Prenom", "Adresse" });
            txtSearchByMolecule.BorderStyle = BorderStyle.FixedSingle;
            txtSearchByMolecule.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchByMolecule.Location = new Point(755, 42);
            txtSearchByMolecule.Margin = new Padding(3, 4, 3, 4);
            txtSearchByMolecule.Name = "txtSearchByMolecule";
            txtSearchByMolecule.Size = new Size(185, 30);
            txtSearchByMolecule.TabIndex = 22;
            txtSearchByMolecule.KeyDown += txtSearchByMolecule_KeyDown;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(533, 44);
            label5.Name = "label5";
            label5.Size = new Size(216, 28);
            label5.TabIndex = 21;
            label5.Text = "Recherche Mol.similaire";
            // 
            // comboCategorie
            // 
            comboCategorie.FormattingEnabled = true;
            comboCategorie.Location = new Point(178, 44);
            comboCategorie.Name = "comboCategorie";
            comboCategorie.Size = new Size(163, 28);
            comboCategorie.TabIndex = 20;
            comboCategorie.SelectedIndexChanged += comboCategorie_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 44);
            label4.Name = "label4";
            label4.Size = new Size(153, 28);
            label4.TabIndex = 19;
            label4.Text = "Tri par catégorie";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomDataGridViewTextBoxColumn, dateCreationDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, provenanceDataGridViewTextBoxColumn, conditionnementDataGridViewTextBoxColumn, seuilStockDataGridViewTextBoxColumn, stockMaxiDataGridViewTextBoxColumn });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.DataSource = produitBindingSource;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(27, 80);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(913, 225);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContextMenuStripNeeded += dataGridView1_CellContextMenuStripNeeded;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            nomDataGridViewTextBoxColumn.Width = 250;
            // 
            // dateCreationDataGridViewTextBoxColumn
            // 
            dateCreationDataGridViewTextBoxColumn.DataPropertyName = "DateCreation";
            dateCreationDataGridViewTextBoxColumn.HeaderText = "DateCreation";
            dateCreationDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateCreationDataGridViewTextBoxColumn.Name = "dateCreationDataGridViewTextBoxColumn";
            dateCreationDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // provenanceDataGridViewTextBoxColumn
            // 
            provenanceDataGridViewTextBoxColumn.DataPropertyName = "Provenance";
            provenanceDataGridViewTextBoxColumn.HeaderText = "Provenance";
            provenanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            provenanceDataGridViewTextBoxColumn.Name = "provenanceDataGridViewTextBoxColumn";
            provenanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // conditionnementDataGridViewTextBoxColumn
            // 
            conditionnementDataGridViewTextBoxColumn.DataPropertyName = "Conditionnement";
            conditionnementDataGridViewTextBoxColumn.HeaderText = "Conditionnement";
            conditionnementDataGridViewTextBoxColumn.MinimumWidth = 6;
            conditionnementDataGridViewTextBoxColumn.Name = "conditionnementDataGridViewTextBoxColumn";
            conditionnementDataGridViewTextBoxColumn.Width = 125;
            // 
            // seuilStockDataGridViewTextBoxColumn
            // 
            seuilStockDataGridViewTextBoxColumn.DataPropertyName = "SeuilStock";
            seuilStockDataGridViewTextBoxColumn.HeaderText = "SeuilStock";
            seuilStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            seuilStockDataGridViewTextBoxColumn.Name = "seuilStockDataGridViewTextBoxColumn";
            seuilStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockMaxiDataGridViewTextBoxColumn
            // 
            stockMaxiDataGridViewTextBoxColumn.DataPropertyName = "StockMaxi";
            stockMaxiDataGridViewTextBoxColumn.HeaderText = "StockMaxi";
            stockMaxiDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockMaxiDataGridViewTextBoxColumn.Name = "stockMaxiDataGridViewTextBoxColumn";
            stockMaxiDataGridViewTextBoxColumn.Width = 125;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { supprimerToolStripMenuItem, toolStripSeparator1, ajouterAuBonToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 62);
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Image = Properties.Resources.delete;
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(181, 26);
            supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // ajouterAuBonToolStripMenuItem
            // 
            ajouterAuBonToolStripMenuItem.Image = Properties.Resources.boncommande;
            ajouterAuBonToolStripMenuItem.Name = "ajouterAuBonToolStripMenuItem";
            ajouterAuBonToolStripMenuItem.Size = new Size(181, 26);
            ajouterAuBonToolStripMenuItem.Text = "Ajouter au Bon";
            ajouterAuBonToolStripMenuItem.Click += ajouterAuBonToolStripMenuItem_Click;
            // 
            // produitBindingSource
            // 
            produitBindingSource.DataSource = typeof(Models.Produit);
            // 
            // btnAddProduit
            // 
            btnAddProduit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddProduit.FlatStyle = FlatStyle.Flat;
            btnAddProduit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddProduit.Image = Properties.Resources.savebottletiny;
            btnAddProduit.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddProduit.Location = new Point(41, 491);
            btnAddProduit.Margin = new Padding(3, 4, 3, 4);
            btnAddProduit.Name = "btnAddProduit";
            btnAddProduit.Size = new Size(227, 72);
            btnAddProduit.TabIndex = 9;
            btnAddProduit.Text = "Nouveau";
            btnAddProduit.UseVisualStyleBackColor = true;
            btnAddProduit.Click += btnajouterproduit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(624, 80);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 17;
            label1.Text = "Rechercher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(259, 122);
            label3.Name = "label3";
            label3.Size = new Size(225, 31);
            label3.TabIndex = 18;
            label3.Text = "Listing des produits";
            // 
            // btnFermer
            // 
            btnFermer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFermer.Image = Properties.Resources.Btn_Delete_Item_Normal;
            btnFermer.ImageAlign = ContentAlignment.MiddleLeft;
            btnFermer.Location = new Point(744, 491);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(227, 72);
            btnFermer.TabIndex = 19;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // txtCodBarre
            // 
            txtCodBarre.Location = new Point(83, 84);
            txtCodBarre.Name = "txtCodBarre";
            txtCodBarre.Size = new Size(141, 27);
            txtCodBarre.TabIndex = 23;
            txtCodBarre.KeyDown += txtCodBarre_KeyDown;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 87);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 22;
            label13.Text = "codbarre";
            // 
            // FrmProduit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 600);
            Controls.Add(txtCodBarre);
            Controls.Add(label13);
            Controls.Add(btnFermer);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(txtRechercher);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnValiderBonDeCommande);
            Controls.Add(btnmodifierproduit);
            Controls.Add(btnAddProduit);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProduit";
            Text = "FrmProduit";
            Load += FrmProduit_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PctBoxBon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnmodifierproduit;
        private Button btnValiderBonDeCommande;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtRechercher;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Button btnAddProduit;
        private Label label1;
        private TextBox txtSearchByMolecule;
        private Label label5;
        private ComboBox comboCategorie;
        private Label label4;
        private Label label3;
        private BindingSource produitBindingSource;
        private Label lbResult;
        private Label label6;
        private Button btnFermer;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCreationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn provenanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn conditionnementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn seuilStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockMaxiDataGridViewTextBoxColumn;
        private TextBox txtCodBarre;
        private Label label13;
        private ToolTip toolTip1;
        private Label labBonCommande;
        private PictureBox PctBoxBon;
        private CheckBox chkActiverBonCoùmmande;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ajouterAuBonToolStripMenuItem;
    }
}