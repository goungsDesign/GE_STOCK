namespace GE_STOCK.Formulaires
{
    partial class Frmvente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmvente));
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            groupBox1 = new GroupBox();
            btnquitter = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            txtNom = new TextBox();
            panel8 = new Panel();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 66);
            panel5.TabIndex = 9;
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
            btnquitter.Location = new Point(719, 0);
            btnquitter.Margin = new Padding(4);
            btnquitter.Name = "btnquitter";
            btnquitter.Size = new Size(79, 64);
            btnquitter.TabIndex = 2;
            btnquitter.Text = "X";
            btnquitter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(400, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 1;
            label2.Text = " Vente";
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(174, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 19);
            textBox1.TabIndex = 17;
            textBox1.Text = "Type de vente";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(25, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 19);
            textBox2.TabIndex = 18;
            textBox2.Text = "Vente";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(292, 177);
            panel4.Name = "panel4";
            panel4.Size = new Size(475, 139);
            panel4.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(424, 108);
            dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(573, 362);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(214, 28);
            button1.TabIndex = 20;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtNom
            // 
            txtNom.BackColor = SystemColors.MenuBar;
            txtNom.BorderStyle = BorderStyle.None;
            txtNom.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNom.Location = new Point(25, 72);
            txtNom.Margin = new Padding(4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(174, 17);
            txtNom.TabIndex = 21;
            txtNom.Text = "Nom du Caissier";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(174, 79);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(236, 10);
            panel8.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(5, 154);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 17);
            textBox3.TabIndex = 23;
            textBox3.Text = "Date du vente";
            // 
            // button2
            // 
            button2.Location = new Point(496, 79);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(121, 28);
            button2.TabIndex = 24;
            button2.Text = "Mettre en attente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(646, 79);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(121, 28);
            button3.TabIndex = 25;
            button3.Text = "Rappeler un ticket";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuBar;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(5, 216);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 17);
            textBox4.TabIndex = 26;
            textBox4.Text = "Heure du vente";
            // 
            // Frmvente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(panel8);
            Controls.Add(txtNom);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmvente";
            Text = "Frmvente";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private GroupBox groupBox1;
        private Button btnquitter;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtNom;
        private Panel panel8;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
    }
}