namespace GE_STOCK.Formulaires.Approvisionnements
{
    partial class FrmApprParticulier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApprParticulier));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel5 = new Panel();
            btnquitter = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btnNouveau = new Button();
            lbResult = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            btnFermer = new Button();
            BtnEnregistrer = new Button();
            label9 = new Label();
            panel3 = new Panel();
            txtPlace = new TextBox();
            btnAdd = new Button();
            label11 = new Label();
            txtDateExp = new DateTimePicker();
            label7 = new Label();
            txtQty = new NumericUpDown();
            label6 = new Label();
            txtLibelleProduit = new TextBox();
            txtIdProduit = new TextBox();
            label8 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            txtEmail = new TextBox();
            label5 = new Label();
            txtTel = new TextBox();
            label4 = new Label();
            txtNomprenom = new TextBox();
            label1 = new Label();
            stockBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produitIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codBarreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomFournisseurDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telFournisseurDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailFournisseurDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateExpirationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emplacementDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQty).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockBindingSource).BeginInit();
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
            panel5.Size = new Size(757, 63);
            panel5.TabIndex = 11;
            // 
            // btnquitter
            // 
            btnquitter.Dock = DockStyle.Right;
            btnquitter.FlatAppearance.BorderSize = 0;
            btnquitter.FlatStyle = FlatStyle.Flat;
            btnquitter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnquitter.Location = new Point(665, 0);
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
            label2.Location = new Point(200, 8);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(410, 41);
            label2.TabIndex = 1;
            label2.Text = "Edition-Approvisionnement";
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
            panel1.Controls.Add(btnNouveau);
            panel1.Controls.Add(lbResult);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnFermer);
            panel1.Controls.Add(BtnEnregistrer);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 644);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // btnNouveau
            // 
            btnNouveau.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNouveau.FlatStyle = FlatStyle.Flat;
            btnNouveau.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNouveau.Location = new Point(46, 558);
            btnNouveau.Margin = new Padding(3, 4, 3, 4);
            btnNouveau.Name = "btnNouveau";
            btnNouveau.Size = new Size(227, 72);
            btnNouveau.TabIndex = 39;
            btnNouveau.Text = "Nouveau";
            btnNouveau.UseVisualStyleBackColor = true;
            btnNouveau.Click += btnNouveau_Click;
            // 
            // lbResult
            // 
            lbResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.Location = new Point(107, 527);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(21, 20);
            lbResult.TabIndex = 38;
            lbResult.Text = "//";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(11, 527);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 37;
            label10.Text = "Résultat(s):";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, produitIdDataGridViewTextBoxColumn, codBarreDataGridViewTextBoxColumn, produitDataGridViewTextBoxColumn, nomFournisseurDataGridViewTextBoxColumn, telFournisseurDataGridViewTextBoxColumn, emailFournisseurDataGridViewTextBoxColumn, dateExpirationDataGridViewTextBoxColumn, emplacementDataGridViewTextBoxColumn });
            dataGridView1.DataSource = stockBindingSource;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(11, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(728, 221);
            dataGridView1.TabIndex = 36;
            // 
            // btnFermer
            // 
            btnFermer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFermer.Location = new Point(512, 558);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(227, 72);
            btnFermer.TabIndex = 35;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnEnregistrer.FlatStyle = FlatStyle.Flat;
            BtnEnregistrer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEnregistrer.Location = new Point(279, 558);
            BtnEnregistrer.Margin = new Padding(3, 4, 3, 4);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(227, 72);
            BtnEnregistrer.TabIndex = 34;
            BtnEnregistrer.Text = "Enrégistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(161, 167);
            label9.Name = "label9";
            label9.Size = new Size(309, 31);
            label9.TabIndex = 33;
            label9.Text = "Produit(s) approvisionné(s)";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtPlace);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtDateExp);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtQty);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtLibelleProduit);
            panel3.Controls.Add(txtIdProduit);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(11, 186);
            panel3.Name = "panel3";
            panel3.Size = new Size(728, 97);
            panel3.TabIndex = 32;
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(514, 55);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(105, 27);
            txtPlace.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Enabled = false;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(637, 19);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 68);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(464, 59);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 40;
            label11.Text = "Place";
            // 
            // txtDateExp
            // 
            txtDateExp.Format = DateTimePickerFormat.Short;
            txtDateExp.Location = new Point(335, 55);
            txtDateExp.Name = "txtDateExp";
            txtDateExp.ShowCheckBox = true;
            txtDateExp.Size = new Size(123, 27);
            txtDateExp.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(260, 60);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "Date exp";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(153, 58);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(101, 27);
            txtQty.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 63);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 4;
            label6.Text = "QTY";
            // 
            // txtLibelleProduit
            // 
            txtLibelleProduit.Location = new Point(260, 19);
            txtLibelleProduit.Name = "txtLibelleProduit";
            txtLibelleProduit.ReadOnly = true;
            txtLibelleProduit.Size = new Size(362, 27);
            txtLibelleProduit.TabIndex = 3;
            // 
            // txtIdProduit
            // 
            txtIdProduit.Location = new Point(153, 19);
            txtIdProduit.Name = "txtIdProduit";
            txtIdProduit.Size = new Size(101, 27);
            txtIdProduit.TabIndex = 2;
            txtIdProduit.Validated += txtIdProduit_Validated;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(87, 26);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 1;
            label8.Text = "Produit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(161, 8);
            label3.Name = "label3";
            label3.Size = new Size(271, 31);
            label3.TabIndex = 31;
            label3.Text = "Information fournisseur";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtTel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtNomprenom);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(11, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 125);
            panel2.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(153, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(469, 27);
            txtEmail.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 88);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(153, 52);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(469, 27);
            txtTel.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 59);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 3;
            label4.Text = "Tel";
            // 
            // txtNomprenom
            // 
            txtNomprenom.Location = new Point(153, 19);
            txtNomprenom.Name = "txtNomprenom";
            txtNomprenom.Size = new Size(469, 27);
            txtNomprenom.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Nom et prénoms";
            // 
            // stockBindingSource
            // 
            stockBindingSource.DataSource = typeof(Models.Stock);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // produitIdDataGridViewTextBoxColumn
            // 
            produitIdDataGridViewTextBoxColumn.DataPropertyName = "ProduitId";
            produitIdDataGridViewTextBoxColumn.HeaderText = "ProduitId";
            produitIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            produitIdDataGridViewTextBoxColumn.Name = "produitIdDataGridViewTextBoxColumn";
            produitIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // codBarreDataGridViewTextBoxColumn
            // 
            codBarreDataGridViewTextBoxColumn.DataPropertyName = "CodBarre";
            codBarreDataGridViewTextBoxColumn.HeaderText = "CodBarre";
            codBarreDataGridViewTextBoxColumn.MinimumWidth = 6;
            codBarreDataGridViewTextBoxColumn.Name = "codBarreDataGridViewTextBoxColumn";
            codBarreDataGridViewTextBoxColumn.ReadOnly = true;
            codBarreDataGridViewTextBoxColumn.Width = 125;
            // 
            // produitDataGridViewTextBoxColumn
            // 
            produitDataGridViewTextBoxColumn.DataPropertyName = "Produit";
            produitDataGridViewTextBoxColumn.HeaderText = "Produit";
            produitDataGridViewTextBoxColumn.MinimumWidth = 6;
            produitDataGridViewTextBoxColumn.Name = "produitDataGridViewTextBoxColumn";
            produitDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomFournisseurDataGridViewTextBoxColumn
            // 
            nomFournisseurDataGridViewTextBoxColumn.DataPropertyName = "NomFournisseur";
            nomFournisseurDataGridViewTextBoxColumn.HeaderText = "NomFournisseur";
            nomFournisseurDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomFournisseurDataGridViewTextBoxColumn.Name = "nomFournisseurDataGridViewTextBoxColumn";
            nomFournisseurDataGridViewTextBoxColumn.Width = 125;
            // 
            // telFournisseurDataGridViewTextBoxColumn
            // 
            telFournisseurDataGridViewTextBoxColumn.DataPropertyName = "TelFournisseur";
            telFournisseurDataGridViewTextBoxColumn.HeaderText = "TelFournisseur";
            telFournisseurDataGridViewTextBoxColumn.MinimumWidth = 6;
            telFournisseurDataGridViewTextBoxColumn.Name = "telFournisseurDataGridViewTextBoxColumn";
            telFournisseurDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailFournisseurDataGridViewTextBoxColumn
            // 
            emailFournisseurDataGridViewTextBoxColumn.DataPropertyName = "EmailFournisseur";
            emailFournisseurDataGridViewTextBoxColumn.HeaderText = "EmailFournisseur";
            emailFournisseurDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailFournisseurDataGridViewTextBoxColumn.Name = "emailFournisseurDataGridViewTextBoxColumn";
            emailFournisseurDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateExpirationDataGridViewTextBoxColumn
            // 
            dateExpirationDataGridViewTextBoxColumn.DataPropertyName = "DateExpiration";
            dateExpirationDataGridViewTextBoxColumn.HeaderText = "DateExpiration";
            dateExpirationDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateExpirationDataGridViewTextBoxColumn.Name = "dateExpirationDataGridViewTextBoxColumn";
            dateExpirationDataGridViewTextBoxColumn.Width = 125;
            // 
            // emplacementDataGridViewTextBoxColumn
            // 
            emplacementDataGridViewTextBoxColumn.DataPropertyName = "Emplacement";
            emplacementDataGridViewTextBoxColumn.HeaderText = "Emplacement";
            emplacementDataGridViewTextBoxColumn.MinimumWidth = 6;
            emplacementDataGridViewTextBoxColumn.Name = "emplacementDataGridViewTextBoxColumn";
            emplacementDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmApprParticulier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 707);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmApprParticulier";
            Text = "FrmApprParticulier";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQty).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Button btnquitter;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtTel;
        private Label label4;
        private TextBox txtNomprenom;
        private Label label1;
        private Label label9;
        private Panel panel3;
        private Label label7;
        private NumericUpDown txtQty;
        private Label label6;
        private TextBox txtLibelleProduit;
        private TextBox txtIdProduit;
        private Label label8;
        private DateTimePicker txtDateExp;
        private Button BtnEnregistrer;
        private DataGridView dataGridView1;
        private Button btnFermer;
        private Label lbResult;
        private Label label10;
        private Button btnAdd;
        private Button btnNouveau;
        private TextBox txtPlace;
        private Label label11;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produitIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codBarreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomFournisseurDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telFournisseurDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailFournisseurDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateExpirationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emplacementDataGridViewTextBoxColumn;
        private BindingSource stockBindingSource;
    }
}