namespace GE_STOCK.Formulaires
{
    partial class FrmAddProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProduit));
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            groupBox1 = new GroupBox();
            btnquitter = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label10 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            listBoxMolecules = new ListBox();
            btnAddMolecule = new Button();
            txtAdMolecule = new TextBox();
            label12 = new Label();
            comboCategorie = new ComboBox();
            label11 = new Label();
            txtStockMaxi = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            comboConditionnement = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            txtStockSecurite = new NumericUpDown();
            comboProvenance = new ComboBox();
            txtLibelle = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnFiche = new Button();
            btnmodifierproduit = new Button();
            btnEnregistrer = new Button();
            label13 = new Label();
            textBox1 = new TextBox();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtStockMaxi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStockSecurite).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btnquitter);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(799, 63);
            panel5.TabIndex = 9;
            panel5.MouseDown += panel5_MouseDown;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(groupBox1);
            panel6.Location = new Point(0, 95);
            panel6.Margin = new Padding(5);
            panel6.Name = "panel6";
            panel6.Size = new Size(1295, 575);
            panel6.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Location = new Point(544, 19);
            panel7.Margin = new Padding(5);
            panel7.Name = "panel7";
            panel7.Size = new Size(751, 633);
            panel7.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(-10, 19);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(450, 633);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion commande";
            // 
            // btnquitter
            // 
            btnquitter.Dock = DockStyle.Right;
            btnquitter.FlatAppearance.BorderSize = 0;
            btnquitter.FlatStyle = FlatStyle.Flat;
            btnquitter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnquitter.Location = new Point(707, 0);
            btnquitter.Margin = new Padding(5);
            btnquitter.Name = "btnquitter";
            btnquitter.Size = new Size(90, 61);
            btnquitter.TabIndex = 2;
            btnquitter.Text = "X";
            btnquitter.UseVisualStyleBackColor = true;
            btnquitter.Click += btnquitter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(258, 6);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(234, 41);
            label2.TabIndex = 1;
            label2.Text = "Edition produit";
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
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 493);
            panel1.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(183, 329);
            label10.Name = "label10";
            label10.Size = new Size(94, 31);
            label10.TabIndex = 22;
            label10.Text = "Actions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(182, 1);
            label3.Name = "label3";
            label3.Size = new Size(240, 31);
            label3.TabIndex = 19;
            label3.Text = "Information produits";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(listBoxMolecules);
            panel2.Controls.Add(btnAddMolecule);
            panel2.Controls.Add(txtAdMolecule);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(comboCategorie);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtStockMaxi);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboConditionnement);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtStockSecurite);
            panel2.Controls.Add(comboProvenance);
            panel2.Controls.Add(txtLibelle);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(24, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 307);
            panel2.TabIndex = 20;
            // 
            // listBoxMolecules
            // 
            listBoxMolecules.FormattingEnabled = true;
            listBoxMolecules.ItemHeight = 20;
            listBoxMolecules.Location = new Point(423, 124);
            listBoxMolecules.Name = "listBoxMolecules";
            listBoxMolecules.Size = new Size(273, 84);
            listBoxMolecules.TabIndex = 19;
            // 
            // btnAddMolecule
            // 
            btnAddMolecule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddMolecule.FlatStyle = FlatStyle.Flat;
            btnAddMolecule.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMolecule.Location = new Point(702, 89);
            btnAddMolecule.Margin = new Padding(3, 4, 3, 4);
            btnAddMolecule.Name = "btnAddMolecule";
            btnAddMolecule.Size = new Size(38, 39);
            btnAddMolecule.TabIndex = 15;
            btnAddMolecule.Text = "+";
            btnAddMolecule.TextAlign = ContentAlignment.TopCenter;
            btnAddMolecule.UseVisualStyleBackColor = true;
            btnAddMolecule.Click += btnAddMolecule_Click;
            // 
            // txtAdMolecule
            // 
            txtAdMolecule.Location = new Point(422, 94);
            txtAdMolecule.Name = "txtAdMolecule";
            txtAdMolecule.Size = new Size(274, 27);
            txtAdMolecule.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(423, 71);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 17;
            label12.Text = "Molécules";
            // 
            // comboCategorie
            // 
            comboCategorie.FormattingEnabled = true;
            comboCategorie.Location = new Point(97, 266);
            comboCategorie.Name = "comboCategorie";
            comboCategorie.Size = new Size(181, 28);
            comboCategorie.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 274);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 15;
            label11.Text = "Catégorie";
            // 
            // txtStockMaxi
            // 
            txtStockMaxi.Location = new Point(620, 266);
            txtStockMaxi.Name = "txtStockMaxi";
            txtStockMaxi.Size = new Size(76, 27);
            txtStockMaxi.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(529, 273);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 13;
            label9.Text = "Stock maxi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(341, 273);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 12;
            label8.Text = "Stock sécurité";
            // 
            // comboConditionnement
            // 
            comboConditionnement.FormattingEnabled = true;
            comboConditionnement.Items.AddRange(new object[] { "Comprimés", "Gellules", "Sirop", "Poudre/suspension", "Poudre/suspension" });
            comboConditionnement.Location = new Point(498, 223);
            comboConditionnement.Name = "comboConditionnement";
            comboConditionnement.Size = new Size(198, 28);
            comboConditionnement.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(368, 231);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 10;
            label7.Text = "Conditionnement";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 236);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 9;
            label6.Text = "Provenance";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(7, 94);
            txtDescription.MaxLength = 1500;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(390, 114);
            txtDescription.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 71);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 7;
            label5.Text = "Description";
            // 
            // txtStockSecurite
            // 
            txtStockSecurite.Location = new Point(447, 266);
            txtStockSecurite.Name = "txtStockSecurite";
            txtStockSecurite.Size = new Size(76, 27);
            txtStockSecurite.TabIndex = 6;
            // 
            // comboProvenance
            // 
            comboProvenance.FormattingEnabled = true;
            comboProvenance.Location = new Point(97, 228);
            comboProvenance.Name = "comboProvenance";
            comboProvenance.Size = new Size(181, 28);
            comboProvenance.TabIndex = 5;
            // 
            // txtLibelle
            // 
            txtLibelle.Location = new Point(422, 22);
            txtLibelle.Name = "txtLibelle";
            txtLibelle.Size = new Size(318, 27);
            txtLibelle.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(36, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(111, 27);
            txtId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 25);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 1;
            label4.Text = "Libellé";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 25);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnFiche);
            panel3.Controls.Add(btnmodifierproduit);
            panel3.Controls.Add(btnEnregistrer);
            panel3.Location = new Point(23, 354);
            panel3.Name = "panel3";
            panel3.Size = new Size(746, 125);
            panel3.TabIndex = 21;
            // 
            // btnFiche
            // 
            btnFiche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnFiche.FlatStyle = FlatStyle.Flat;
            btnFiche.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiche.Location = new Point(501, 26);
            btnFiche.Margin = new Padding(3, 4, 3, 4);
            btnFiche.Name = "btnFiche";
            btnFiche.Size = new Size(227, 72);
            btnFiche.TabIndex = 14;
            btnFiche.Text = "Fiche";
            btnFiche.UseVisualStyleBackColor = true;
            // 
            // btnmodifierproduit
            // 
            btnmodifierproduit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnmodifierproduit.FlatStyle = FlatStyle.Flat;
            btnmodifierproduit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmodifierproduit.Location = new Point(264, 26);
            btnmodifierproduit.Margin = new Padding(3, 4, 3, 4);
            btnmodifierproduit.Name = "btnmodifierproduit";
            btnmodifierproduit.Size = new Size(227, 72);
            btnmodifierproduit.TabIndex = 12;
            btnmodifierproduit.Text = "Modifier";
            btnmodifierproduit.UseVisualStyleBackColor = true;
            btnmodifierproduit.Click += btnmodifierproduit_Click;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnregistrer.Location = new Point(26, 26);
            btnEnregistrer.Margin = new Padding(3, 4, 3, 4);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(227, 72);
            btnEnregistrer.TabIndex = 11;
            btnEnregistrer.Text = "Enrégistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(150, 25);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 20;
            label13.Text = "codbarre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 27);
            textBox1.TabIndex = 21;
            // 
            // FrmAddProduit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 556);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddProduit";
            Text = "FrmAddProduit";
            Load += FrmAddProduit_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtStockMaxi).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStockSecurite).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private GroupBox groupBox1;
        private Button btnquitter;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private TextBox txtLibelle;
        private TextBox txtId;
        private Label label4;
        private Label label1;
        private Label label5;
        private NumericUpDown txtStockSecurite;
        private ComboBox comboProvenance;
        private Label label9;
        private Label label8;
        private ComboBox comboConditionnement;
        private Label label7;
        private Label label6;
        private TextBox txtDescription;
        private Label label10;
        private NumericUpDown txtStockMaxi;
        private Panel panel3;
        private Button btnmodifierproduit;
        private Button btnEnregistrer;
        private Button btnFiche;
        private ComboBox comboCategorie;
        private Label label11;
        private Label label12;
        private Button btnAddMolecule;
        private TextBox txtAdMolecule;
        private ListBox listBoxMolecules;
        private TextBox textBox1;
        private Label label13;
    }
}