namespace GE_STOCK.Formulaires
{
    partial class FrmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnexion));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            groupBox1 = new GroupBox();
            btnquitter = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            txtNom = new TextBox();
            panel8 = new Panel();
            txtmotdepasse = new TextBox();
            panel9 = new Panel();
            btnConnecter = new Button();
            label1 = new Label();
            label3 = new Label();
            btnAnnuler = new Button();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 2);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 2);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 357);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(643, 2);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 357);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.ForestGreen;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 359);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(646, 2);
            panel4.TabIndex = 1;
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
            panel5.Location = new Point(3, 2);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(640, 66);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(groupBox1);
            panel6.Location = new Point(0, 71);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(1133, 431);
            panel6.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Location = new Point(476, 14);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(657, 475);
            panel7.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(-9, 14);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(394, 475);
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
            btnquitter.Location = new Point(559, 0);
            btnquitter.Margin = new Padding(4);
            btnquitter.Name = "btnquitter";
            btnquitter.Size = new Size(79, 64);
            btnquitter.TabIndex = 2;
            btnquitter.Text = "X";
            btnquitter.UseVisualStyleBackColor = true;
            btnquitter.Click += btnquitter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(147, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(258, 41);
            label2.TabIndex = 1;
            label2.Text = " Authentification";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // txtNom
            // 
            txtNom.BackColor = SystemColors.MenuBar;
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNom.Location = new Point(82, 126);
            txtNom.Margin = new Padding(4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(416, 29);
            txtNom.TabIndex = 8;
            txtNom.TextChanged += txtNom_TextChanged;
            txtNom.Enter += txtNom_Enter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(82, 122);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(416, 1);
            panel8.TabIndex = 9;
            // 
            // txtmotdepasse
            // 
            txtmotdepasse.BackColor = SystemColors.MenuBar;
            txtmotdepasse.BorderStyle = BorderStyle.FixedSingle;
            txtmotdepasse.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtmotdepasse.Location = new Point(82, 194);
            txtmotdepasse.Margin = new Padding(4);
            txtmotdepasse.Name = "txtmotdepasse";
            txtmotdepasse.PasswordChar = '*';
            txtmotdepasse.Size = new Size(416, 29);
            txtmotdepasse.TabIndex = 10;
            txtmotdepasse.TextChanged += textBox2_TextChanged;
            txtmotdepasse.Leave += txtmotdepasse_Leave;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(82, 217);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(416, 1);
            panel9.TabIndex = 10;
            // 
            // btnConnecter
            // 
            btnConnecter.DialogResult = DialogResult.OK;
            btnConnecter.Location = new Point(82, 262);
            btnConnecter.Margin = new Padding(4);
            btnConnecter.Name = "btnConnecter";
            btnConnecter.Size = new Size(174, 51);
            btnConnecter.TabIndex = 11;
            btnConnecter.Text = "Se connecter";
            btnConnecter.UseVisualStyleBackColor = true;
            btnConnecter.Click += btnConnecter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 94);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 12;
            label1.Text = "Nom utilisateur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 166);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 13;
            label3.Text = "Mot de passe";
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(264, 262);
            btnAnnuler.Margin = new Padding(4);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(174, 51);
            btnAnnuler.TabIndex = 14;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmConnexion
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 361);
            Controls.Add(btnAnnuler);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnConnecter);
            Controls.Add(panel9);
            Controls.Add(txtmotdepasse);
            Controls.Add(panel8);
            Controls.Add(txtNom);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmConnexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConnexion";
            Leave += FrmConnexion_Leave;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private GroupBox groupBox1;
        private Button btnquitter;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox txtNom;
        private Panel panel8;
        private TextBox txtmotdepasse;
        private Panel panel9;
        private Button btnConnecter;
        private Label label1;
        private Label label3;
        private Button btnAnnuler;
    }
}