namespace WinForms
{
    partial class FrmKlijenti
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
            pnlOsoba = new Panel();
            btnDodajGrad = new Button();
            btnDodaj = new Button();
            cmbGrad = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtBrojTelefona = new TextBox();
            label2 = new Label();
            txtPrezime = new TextBox();
            label1 = new Label();
            txtIme = new TextBox();
            pnlTabela = new Panel();
            dgvOsobe = new DataGridView();
            btnIzbaci = new Button();
            button1 = new Button();
            pnlOsoba.SuspendLayout();
            pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOsobe).BeginInit();
            SuspendLayout();
            // 
            // pnlOsoba
            // 
            pnlOsoba.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlOsoba.BackColor = SystemColors.ActiveCaption;
            pnlOsoba.Controls.Add(btnDodajGrad);
            pnlOsoba.Controls.Add(btnDodaj);
            pnlOsoba.Controls.Add(cmbGrad);
            pnlOsoba.Controls.Add(label4);
            pnlOsoba.Controls.Add(label3);
            pnlOsoba.Controls.Add(txtBrojTelefona);
            pnlOsoba.Controls.Add(label2);
            pnlOsoba.Controls.Add(txtPrezime);
            pnlOsoba.Controls.Add(label1);
            pnlOsoba.Controls.Add(txtIme);
            pnlOsoba.Location = new Point(124, 60);
            pnlOsoba.Name = "pnlOsoba";
            pnlOsoba.Size = new Size(365, 420);
            pnlOsoba.TabIndex = 0;
            // 
            // btnDodajGrad
            // 
            btnDodajGrad.Location = new Point(298, 175);
            btnDodajGrad.Name = "btnDodajGrad";
            btnDodajGrad.Size = new Size(38, 23);
            btnDodajGrad.TabIndex = 11;
            btnDodajGrad.Text = "+";
            btnDodajGrad.UseVisualStyleBackColor = true;
            btnDodajGrad.Click += btnDodajGrad_Click_1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(61, 276);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(295, 29);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cmbGrad
            // 
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(140, 175);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(152, 23);
            cmbGrad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 176);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "Grad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 132);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 5;
            label3.Text = "Broj telefona:";
            // 
            // txtBrojTelefona
            // 
            txtBrojTelefona.Location = new Point(140, 127);
            txtBrojTelefona.Name = "txtBrojTelefona";
            txtBrojTelefona.Size = new Size(196, 23);
            txtBrojTelefona.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 90);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(140, 85);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(196, 23);
            txtPrezime.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 46);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(140, 41);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(196, 23);
            txtIme.TabIndex = 0;
            // 
            // pnlTabela
            // 
            pnlTabela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTabela.Controls.Add(dgvOsobe);
            pnlTabela.Location = new Point(511, 60);
            pnlTabela.Name = "pnlTabela";
            pnlTabela.Size = new Size(485, 420);
            pnlTabela.TabIndex = 1;
            // 
            // dgvOsobe
            // 
            dgvOsobe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOsobe.Dock = DockStyle.Fill;
            dgvOsobe.Location = new Point(0, 0);
            dgvOsobe.Name = "dgvOsobe";
            dgvOsobe.Size = new Size(485, 420);
            dgvOsobe.TabIndex = 0;
            dgvOsobe.CellContentClick += dgvOsobe_CellContentClick;
            // 
            // btnIzbaci
            // 
            btnIzbaci.Location = new Point(884, 31);
            btnIzbaci.Name = "btnIzbaci";
            btnIzbaci.Size = new Size(112, 23);
            btnIzbaci.TabIndex = 2;
            btnIzbaci.Text = "Izbaci";
            btnIzbaci.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(884, 486);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 3;
            button1.Text = "Sacuvaj sve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmKlijenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 591);
            Controls.Add(button1);
            Controls.Add(btnIzbaci);
            Controls.Add(pnlTabela);
            Controls.Add(pnlOsoba);
            Name = "FrmKlijenti";
            Text = "Rad sa klijentima";
            pnlOsoba.ResumeLayout(false);
            pnlOsoba.PerformLayout();
            pnlTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOsobe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOsoba;
        private Button btnDodajGrad;
        private Button btnDodaj;
        private ComboBox cmbGrad;
        private Label label4;
        private Label label3;
        private TextBox txtBrojTelefona;
        private Label label2;
        private TextBox txtPrezime;
        private Label label1;
        private TextBox txtIme;
        private Panel pnlTabela;
        private DataGridView dgvOsobe;
        private Button btnIzbaci;
        private Button button1;
    }
}