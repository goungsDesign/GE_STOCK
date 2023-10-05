namespace GE_STOCK.Formulaires
{
    partial class Frm_users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_users));
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            groupBox1 = new GroupBox();
            btnquitter = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            btnajouterproduit = new Button();
            btnmodifierproduit = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            panel5.TabIndex = 8;
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
            label2.Size = new Size(260, 32);
            label2.TabIndex = 1;
            label2.Text = " Formulaire des Users";
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
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(32, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(737, 139);
            panel4.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(681, 108);
            dataGridView1.TabIndex = 5;
            // 
            // btnajouterproduit
            // 
            btnajouterproduit.FlatStyle = FlatStyle.Flat;
            btnajouterproduit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnajouterproduit.Location = new Point(76, 335);
            btnajouterproduit.Name = "btnajouterproduit";
            btnajouterproduit.Size = new Size(199, 54);
            btnajouterproduit.TabIndex = 10;
            btnajouterproduit.Text = "Ajouter";
            btnajouterproduit.UseVisualStyleBackColor = true;
            // 
            // btnmodifierproduit
            // 
            btnmodifierproduit.FlatStyle = FlatStyle.Flat;
            btnmodifierproduit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmodifierproduit.Location = new Point(306, 335);
            btnmodifierproduit.Name = "btnmodifierproduit";
            btnmodifierproduit.Size = new Size(199, 54);
            btnmodifierproduit.TabIndex = 18;
            btnmodifierproduit.Text = "Modifier";
            btnmodifierproduit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(570, 335);
            button2.Name = "button2";
            button2.Size = new Size(199, 54);
            button2.TabIndex = 19;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(379, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 19);
            textBox1.TabIndex = 20;
            textBox1.Text = "Rechercher";
            // 
            // textBox2
            // 
            textBox2.AutoCompleteCustomSource.AddRange(new string[] { "Id", "Nom", "Prenom", "Adresse" });
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(595, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 19);
            textBox2.TabIndex = 21;
            // 
            // Frm_users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(btnmodifierproduit);
            Controls.Add(btnajouterproduit);
            Controls.Add(panel4);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_users";
            Text = "Frm_users";
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
        private Panel panel4;
        private DataGridView dataGridView1;
        private Button btnajouterproduit;
        private Button btnmodifierproduit;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}