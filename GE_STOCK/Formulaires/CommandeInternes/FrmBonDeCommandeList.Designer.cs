namespace GE_STOCK.Formulaires
{
    partial class FrmBonDeCommandeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBonDeCommandeList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel5 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            txtNo = new TextBox();
            label13 = new Label();
            label1 = new Label();
            txtRechercher = new TextBox();
            panel1 = new Panel();
            panel4 = new Panel();
            labRésultat = new Label();
            label9 = new Label();
            labResultDetailBon = new Label();
            groupBox1 = new GroupBox();
            btnSearchBon = new Button();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            listBoxDetailBondeCommande = new ListBox();
            label7 = new Label();
            labBonCommande = new Label();
            PctBoxBon = new PictureBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estLivreeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            prioriteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailBonDeCommandesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            annulerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            servirToolStripMenuItem = new ToolStripMenuItem();
            bonDeCommandeBindingSource = new BindingSource(components);
            label3 = new Label();
            btnFermer = new Button();
            button1 = new Button();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctBoxBon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bonDeCommandeBindingSource).BeginInit();
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
            panel5.Size = new Size(994, 69);
            panel5.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(174, 11);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(592, 41);
            label2.TabIndex = 1;
            label2.Text = " Formulaire recherche Bon de commande";
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
            // txtNo
            // 
            txtNo.Location = new Point(49, 87);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(141, 27);
            txtNo.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 90);
            label13.Name = "label13";
            label13.Size = new Size(29, 20);
            label13.TabIndex = 27;
            label13.Text = "No";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(539, 83);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 26;
            label1.Text = "Rechercher";
            // 
            // txtRechercher
            // 
            txtRechercher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRechercher.AutoCompleteCustomSource.AddRange(new string[] { "Id", "Nom", "Prenom", "Adresse" });
            txtRechercher.BorderStyle = BorderStyle.FixedSingle;
            txtRechercher.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRechercher.Location = new Point(652, 84);
            txtRechercher.Margin = new Padding(3, 4, 3, 4);
            txtRechercher.Name = "txtRechercher";
            txtRechercher.Size = new Size(320, 27);
            txtRechercher.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(12, 117);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 4);
            panel1.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(labRésultat);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(labResultDetailBon);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(listBoxDetailBondeCommande);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(labBonCommande);
            panel4.Controls.Add(PctBoxBon);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(19, 153);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(959, 318);
            panel4.TabIndex = 29;
            // 
            // labRésultat
            // 
            labRésultat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labRésultat.AutoSize = true;
            labRésultat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labRésultat.Location = new Point(90, 275);
            labRésultat.Name = "labRésultat";
            labRésultat.Size = new Size(28, 28);
            labRésultat.TabIndex = 35;
            labRésultat.Text = "//";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 275);
            label9.Name = "label9";
            label9.Size = new Size(85, 28);
            label9.TabIndex = 34;
            label9.Text = "Résultat:";
            // 
            // labResultDetailBon
            // 
            labResultDetailBon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labResultDetailBon.AutoSize = true;
            labResultDetailBon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labResultDetailBon.Location = new Point(662, 275);
            labResultDetailBon.Name = "labResultDetailBon";
            labResultDetailBon.Size = new Size(28, 28);
            labResultDetailBon.TabIndex = 24;
            labResultDetailBon.Text = "//";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearchBon);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(8, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 59);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Période";
            // 
            // btnSearchBon
            // 
            btnSearchBon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearchBon.FlatStyle = FlatStyle.Flat;
            btnSearchBon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchBon.Image = Properties.Resources.Btn_Search_XGreen_Normal;
            btnSearchBon.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchBon.Location = new Point(398, 22);
            btnSearchBon.Margin = new Padding(3, 4, 3, 4);
            btnSearchBon.Name = "btnSearchBon";
            btnSearchBon.Size = new Size(95, 33);
            btnSearchBon.TabIndex = 23;
            btnSearchBon.Text = "Search";
            btnSearchBon.TextAlign = ContentAlignment.MiddleRight;
            btnSearchBon.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(256, 24);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 27);
            dateTimePicker2.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(215, 22);
            label8.Name = "label8";
            label8.Size = new Size(38, 28);
            label8.TabIndex = 21;
            label8.Text = "Fin";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(78, 24);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(131, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 24);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 19;
            label4.Text = "Début";
            // 
            // listBoxDetailBondeCommande
            // 
            listBoxDetailBondeCommande.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxDetailBondeCommande.FormattingEnabled = true;
            listBoxDetailBondeCommande.ItemHeight = 20;
            listBoxDetailBondeCommande.Location = new Point(662, 81);
            listBoxDetailBondeCommande.Name = "listBoxDetailBondeCommande";
            listBoxDetailBondeCommande.Size = new Size(292, 184);
            listBoxDetailBondeCommande.TabIndex = 32;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(872, 46);
            label7.Name = "label7";
            label7.Size = new Size(80, 31);
            label7.TabIndex = 31;
            label7.Text = "Détail";
            // 
            // labBonCommande
            // 
            labBonCommande.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labBonCommande.Location = new Point(1467, 527);
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
            PctBoxBon.Location = new Point(1421, 522);
            PctBoxBon.Name = "PctBoxBon";
            PctBoxBon.Size = new Size(40, 28);
            PctBoxBon.SizeMode = PictureBoxSizeMode.StretchImage;
            PctBoxBon.TabIndex = 25;
            PctBoxBon.TabStop = false;
            PctBoxBon.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1290, 44);
            label5.Name = "label5";
            label5.Size = new Size(216, 28);
            label5.TabIndex = 21;
            label5.Text = "Recherche Mol.similaire";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, nomDataGridViewTextBoxColumn, estLivreeDataGridViewCheckBoxColumn, prioriteDataGridViewTextBoxColumn, detailBonDeCommandesDataGridViewTextBoxColumn });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.DataSource = bonDeCommandeBindingSource;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(8, 81);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(648, 184);
            dataGridView1.TabIndex = 5;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // estLivreeDataGridViewCheckBoxColumn
            // 
            estLivreeDataGridViewCheckBoxColumn.DataPropertyName = "EstLivree";
            estLivreeDataGridViewCheckBoxColumn.HeaderText = "EstLivree";
            estLivreeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            estLivreeDataGridViewCheckBoxColumn.Name = "estLivreeDataGridViewCheckBoxColumn";
            estLivreeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // prioriteDataGridViewTextBoxColumn
            // 
            prioriteDataGridViewTextBoxColumn.DataPropertyName = "Priorite";
            prioriteDataGridViewTextBoxColumn.HeaderText = "Priorite";
            prioriteDataGridViewTextBoxColumn.MinimumWidth = 6;
            prioriteDataGridViewTextBoxColumn.Name = "prioriteDataGridViewTextBoxColumn";
            prioriteDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailBonDeCommandesDataGridViewTextBoxColumn
            // 
            detailBonDeCommandesDataGridViewTextBoxColumn.DataPropertyName = "DetailBonDeCommandes";
            detailBonDeCommandesDataGridViewTextBoxColumn.HeaderText = "DetailBonDeCommandes";
            detailBonDeCommandesDataGridViewTextBoxColumn.MinimumWidth = 6;
            detailBonDeCommandesDataGridViewTextBoxColumn.Name = "detailBonDeCommandesDataGridViewTextBoxColumn";
            detailBonDeCommandesDataGridViewTextBoxColumn.Width = 125;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { annulerToolStripMenuItem, toolStripSeparator1, servirToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 86);
            // 
            // annulerToolStripMenuItem
            // 
            annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            annulerToolStripMenuItem.Size = new Size(210, 24);
            annulerToolStripMenuItem.Text = "Annuler";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(207, 6);
            // 
            // servirToolStripMenuItem
            // 
            servirToolStripMenuItem.Name = "servirToolStripMenuItem";
            servirToolStripMenuItem.Size = new Size(210, 24);
            servirToolStripMenuItem.Text = "Servir";
            servirToolStripMenuItem.Click += servirToolStripMenuItem_Click;
            // 
            // bonDeCommandeBindingSource
            // 
            bonDeCommandeBindingSource.DataSource = typeof(Models.BonDeCommande);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(274, 136);
            label3.Name = "label3";
            label3.Size = new Size(345, 31);
            label3.TabIndex = 30;
            label3.Text = "Listing des Bon de commandes";
            // 
            // btnFermer
            // 
            btnFermer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFermer.Image = Properties.Resources.Btn_Delete_Item_Normal;
            btnFermer.ImageAlign = ContentAlignment.MiddleLeft;
            btnFermer.Location = new Point(752, 476);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(227, 72);
            btnFermer.TabIndex = 31;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(519, 476);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(227, 72);
            button1.TabIndex = 32;
            button1.Text = "Imprimer";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmBonDeCommandeList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 554);
            Controls.Add(button1);
            Controls.Add(btnFermer);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(txtNo);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(txtRechercher);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBonDeCommandeList";
            Text = "FrmBonDeCommandeList";
            Load += FrmBonDeCommandeList_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PctBoxBon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bonDeCommandeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox txtNo;
        private Label label13;
        private Label label1;
        private TextBox txtRechercher;
        private Panel panel1;
        private Panel panel4;
        private Label labBonCommande;
        private PictureBox PctBoxBon;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label3;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private ListBox listBoxDetailBondeCommande;
        private Label label7;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn estLivreeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn prioriteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detailBonDeCommandesDataGridViewTextBoxColumn;
        private BindingSource bonDeCommandeBindingSource;
        private Button btnSearchBon;
        private Label labRésultat;
        private Label label9;
        private Label labResultDetailBon;
        private Button btnFermer;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem annulerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem servirToolStripMenuItem;
    }
}