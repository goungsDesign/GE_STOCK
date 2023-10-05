namespace GE_STOCK.Formulaires.Inventaires
{
    partial class FrmInventaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventaire));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel5 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            ComboTri = new ComboBox();
            txtQtyRecherchee = new NumericUpDown();
            btnOk = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboProvenance = new ComboBox();
            label7 = new Label();
            btnokId = new Button();
            txtId = new TextBox();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lbResult = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            Id_Produit = new DataGridViewTextBoxColumn();
            CodeBarre = new DataGridViewTextBoxColumn();
            Produits = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Molecules = new DataGridViewTextBoxColumn();
            Conditionnment = new DataGridViewTextBoxColumn();
            AL_Maxi = new DataGridViewTextBoxColumn();
            AL_Secu = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnFermer = new Button();
            btnOkProvenances = new Button();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQtyRecherchee).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel5.Size = new Size(1157, 63);
            panel5.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(309, 8);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(344, 41);
            label2.TabIndex = 1;
            label2.Text = "Gestion des inventaires";
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(12, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(1133, 108);
            panel2.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(ComboTri);
            groupBox1.Controls.Add(txtQtyRecherchee);
            groupBox1.Controls.Add(btnOk);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(676, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 75);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Par quantité";
            // 
            // ComboTri
            // 
            ComboTri.FormattingEnabled = true;
            ComboTri.Items.AddRange(new object[] { ">", ">=", "<", "<=", "==" });
            ComboTri.Location = new Point(39, 31);
            ComboTri.Name = "ComboTri";
            ComboTri.Size = new Size(63, 28);
            ComboTri.TabIndex = 45;
            // 
            // txtQtyRecherchee
            // 
            txtQtyRecherchee.Location = new Point(108, 32);
            txtQtyRecherchee.Name = "txtQtyRecherchee";
            txtQtyRecherchee.Size = new Size(109, 27);
            txtQtyRecherchee.TabIndex = 41;
            // 
            // btnOk
            // 
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(223, 27);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(62, 33);
            btnOk.TabIndex = 40;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "Qty";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnOkProvenances);
            groupBox2.Controls.Add(comboProvenance);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnokId);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(3, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(667, 75);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Critères spécifiques";
            // 
            // comboProvenance
            // 
            comboProvenance.FormattingEnabled = true;
            comboProvenance.Location = new Point(403, 31);
            comboProvenance.Name = "comboProvenance";
            comboProvenance.Size = new Size(189, 28);
            comboProvenance.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 33);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 43;
            label7.Text = "Provenances:";
            // 
            // btnokId
            // 
            btnokId.FlatStyle = FlatStyle.Flat;
            btnokId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnokId.Location = new Point(238, 27);
            btnokId.Margin = new Padding(3, 4, 3, 4);
            btnokId.Name = "btnokId";
            btnokId.Size = new Size(62, 33);
            btnokId.TabIndex = 41;
            btnokId.Text = "Ok";
            btnokId.UseVisualStyleBackColor = true;
            btnokId.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(74, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(158, 27);
            txtId.TabIndex = 5;
            txtId.Validated += txtId_Validated;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 35);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Produit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(267, 68);
            label3.Name = "label3";
            label3.Size = new Size(248, 31);
            label3.TabIndex = 33;
            label3.Text = "Paramètres recherche";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbResult);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 238);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 356);
            panel1.TabIndex = 34;
            // 
            // lbResult
            // 
            lbResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.Location = new Point(115, 318);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(21, 20);
            lbResult.TabIndex = 40;
            lbResult.Text = "//";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(23, 318);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 39;
            label10.Text = "Résultat(s):";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_Produit, CodeBarre, Produits, Qty, Molecules, Conditionnment, AL_Maxi, AL_Secu });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(26, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1070, 278);
            dataGridView1.TabIndex = 0;
            // 
            // Id_Produit
            // 
            Id_Produit.HeaderText = "Id_Produit";
            Id_Produit.MinimumWidth = 6;
            Id_Produit.Name = "Id_Produit";
            Id_Produit.ReadOnly = true;
            Id_Produit.Width = 125;
            // 
            // CodeBarre
            // 
            CodeBarre.HeaderText = "CodeBarre";
            CodeBarre.MinimumWidth = 6;
            CodeBarre.Name = "CodeBarre";
            CodeBarre.Width = 125;
            // 
            // Produits
            // 
            Produits.HeaderText = "Produits";
            Produits.MinimumWidth = 6;
            Produits.Name = "Produits";
            Produits.ReadOnly = true;
            Produits.Width = 125;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.Width = 125;
            // 
            // Molecules
            // 
            Molecules.HeaderText = "Molécules";
            Molecules.MinimumWidth = 6;
            Molecules.Name = "Molecules";
            Molecules.ReadOnly = true;
            Molecules.Width = 125;
            // 
            // Conditionnment
            // 
            Conditionnment.HeaderText = "Conditionnement";
            Conditionnment.MinimumWidth = 6;
            Conditionnment.Name = "Conditionnment";
            Conditionnment.ReadOnly = true;
            Conditionnment.Width = 125;
            // 
            // AL_Maxi
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            AL_Maxi.DefaultCellStyle = dataGridViewCellStyle2;
            AL_Maxi.HeaderText = "AL_Maxi";
            AL_Maxi.MinimumWidth = 6;
            AL_Maxi.Name = "AL_Maxi";
            AL_Maxi.ReadOnly = true;
            AL_Maxi.Width = 125;
            // 
            // AL_Secu
            // 
            dataGridViewCellStyle3.BackColor = Color.Silver;
            AL_Secu.DefaultCellStyle = dataGridViewCellStyle3;
            AL_Secu.HeaderText = "AL_Sécu";
            AL_Secu.MinimumWidth = 6;
            AL_Secu.Name = "AL_Secu";
            AL_Secu.ReadOnly = true;
            AL_Secu.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(327, 216);
            label4.Name = "label4";
            label4.Size = new Size(225, 31);
            label4.TabIndex = 35;
            label4.Text = "Listing des produits";
            // 
            // btnFermer
            // 
            btnFermer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFermer.Location = new Point(918, 601);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(227, 72);
            btnFermer.TabIndex = 38;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // btnOkProvenances
            // 
            btnOkProvenances.FlatStyle = FlatStyle.Flat;
            btnOkProvenances.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOkProvenances.Location = new Point(598, 28);
            btnOkProvenances.Margin = new Padding(3, 4, 3, 4);
            btnOkProvenances.Name = "btnOkProvenances";
            btnOkProvenances.Size = new Size(62, 33);
            btnOkProvenances.TabIndex = 45;
            btnOkProvenances.Text = "Ok";
            btnOkProvenances.UseVisualStyleBackColor = true;
            // 
            // FrmInventaire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 678);
            Controls.Add(btnFermer);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInventaire";
            Text = "FrmInventaire";
            Load += FrmInventaire_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQtyRecherchee).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel2;
        private GroupBox groupBox2;
        private Button btnokId;
        private TextBox txtId;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Label lbResult;
        private Label label10;
        private DataGridView dataGridView1;
        private Label label7;
        private ComboBox comboProvenance;
        private Label label4;
        private DataGridViewTextBoxColumn Id_Produit;
        private DataGridViewTextBoxColumn CodeBarre;
        private DataGridViewTextBoxColumn Produits;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Molecules;
        private DataGridViewTextBoxColumn Conditionnment;
        private DataGridViewTextBoxColumn AL_Maxi;
        private DataGridViewTextBoxColumn AL_Secu;
        private Button btnFermer;
        private GroupBox groupBox1;
        private ComboBox ComboTri;
        private NumericUpDown txtQtyRecherchee;
        private Button btnOk;
        private Label label1;
        private Button btnOkProvenances;
    }
}