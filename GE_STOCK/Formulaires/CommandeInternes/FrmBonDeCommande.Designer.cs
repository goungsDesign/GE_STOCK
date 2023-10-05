namespace GE_STOCK.Formulaires
{
    partial class FrmBonDeCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBonDeCommande));
            panel5 = new Panel();
            btnquitter = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btnmodifierproduit = new Button();
            btnEnregistrer = new Button();
            label3 = new Label();
            panel2 = new Panel();
            lstProduit = new ListBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            trackBar1 = new TrackBar();
            label5 = new Label();
            txtLibelle = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            detailBonDeCommandeBindingSource = new BindingSource(components);
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailBonDeCommandeBindingSource).BeginInit();
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
            panel5.Size = new Size(800, 63);
            panel5.TabIndex = 10;
            panel5.MouseDown += panel5_MouseDown;
            // 
            // btnquitter
            // 
            btnquitter.Dock = DockStyle.Right;
            btnquitter.FlatAppearance.BorderSize = 0;
            btnquitter.FlatStyle = FlatStyle.Flat;
            btnquitter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnquitter.Location = new Point(708, 0);
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
            label2.Size = new Size(413, 41);
            label2.TabIndex = 1;
            label2.Text = "Edition-Bon( ravitaillement)";
            label2.MouseDown += label2_MouseDown;
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
            panel1.Controls.Add(btnmodifierproduit);
            panel1.Controls.Add(btnEnregistrer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 442);
            panel1.TabIndex = 11;
            // 
            // btnmodifierproduit
            // 
            btnmodifierproduit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnmodifierproduit.FlatStyle = FlatStyle.Flat;
            btnmodifierproduit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmodifierproduit.Location = new Point(544, 361);
            btnmodifierproduit.Margin = new Padding(3, 4, 3, 4);
            btnmodifierproduit.Name = "btnmodifierproduit";
            btnmodifierproduit.Size = new Size(227, 72);
            btnmodifierproduit.TabIndex = 20;
            btnmodifierproduit.Text = "Modifier";
            btnmodifierproduit.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnregistrer.Location = new Point(306, 361);
            btnEnregistrer.Margin = new Padding(3, 4, 3, 4);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(227, 72);
            btnEnregistrer.TabIndex = 19;
            btnEnregistrer.Text = "Valider";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(213, 8);
            label3.Name = "label3";
            label3.Size = new Size(384, 31);
            label3.TabIndex = 22;
            label3.Text = "Information Bon de ravitaillement";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lstProduit);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(trackBar1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtLibelle);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(26, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 326);
            panel2.TabIndex = 21;
            // 
            // lstProduit
            // 
            lstProduit.FormattingEnabled = true;
            lstProduit.ItemHeight = 20;
            lstProduit.Location = new Point(225, 153);
            lstProduit.Name = "lstProduit";
            lstProduit.Size = new Size(471, 164);
            lstProduit.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(225, 119);
            label6.Name = "label6";
            label6.Size = new Size(220, 31);
            label6.TabIndex = 23;
            label6.Text = "Liste des produit(s)";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(601, 76);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Est livrée?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(202, 67);
            trackBar1.Maximum = 3;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(393, 56);
            trackBar1.TabIndex = 16;
            trackBar1.TickStyle = TickStyle.TopLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 80);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 7;
            label5.Text = "Priorité de livraison";
            // 
            // txtLibelle
            // 
            txtLibelle.Location = new Point(222, 22);
            txtLibelle.Name = "txtLibelle";
            txtLibelle.Size = new Size(474, 27);
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
            label4.Location = new Point(166, 25);
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.approvisionnement1;
            pictureBox1.Location = new Point(9, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 192);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // detailBonDeCommandeBindingSource
            // 
            detailBonDeCommandeBindingSource.DataSource = typeof(Models.DetailBonDeCommande);
            // 
            // FrmBonDeCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBonDeCommande";
            Text = "FrmBonDeCommande";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailBonDeCommandeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Button btnquitter;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private TextBox txtLibelle;
        private TextBox txtId;
        private Label label4;
        private Label label1;
        private Label label3;
        private TrackBar trackBar1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Button btnmodifierproduit;
        private Button btnEnregistrer;
        private Label label6;
        private ListBox lstProduit;
        private BindingSource detailBonDeCommandeBindingSource;
    }
}