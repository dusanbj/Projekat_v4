namespace KlijentskaAplikacija
{
    partial class FrmRoba
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
            btnDodaj = new Button();
            label2 = new Label();
            txtPrezime = new TextBox();
            label1 = new Label();
            txtIme = new TextBox();
            panel1 = new Panel();
            dgvRoba = new DataGridView();
            pnlOsoba.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoba).BeginInit();
            SuspendLayout();
            // 
            // pnlOsoba
            // 
            pnlOsoba.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlOsoba.BackColor = SystemColors.ActiveCaption;
            pnlOsoba.Controls.Add(btnDodaj);
            pnlOsoba.Controls.Add(label2);
            pnlOsoba.Controls.Add(txtPrezime);
            pnlOsoba.Controls.Add(label1);
            pnlOsoba.Controls.Add(txtIme);
            pnlOsoba.Location = new Point(26, 12);
            pnlOsoba.Name = "pnlOsoba";
            pnlOsoba.Size = new Size(364, 560);
            pnlOsoba.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(28, 130);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(308, 29);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 88);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Opis:";
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
            label1.Location = new Point(95, 44);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Naziv:";
            label1.Click += label1_Click;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(140, 41);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(196, 23);
            txtIme.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvRoba);
            panel1.Location = new Point(418, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 560);
            panel1.TabIndex = 2;
            // 
            // dgvRoba
            // 
            dgvRoba.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoba.Dock = DockStyle.Fill;
            dgvRoba.Location = new Point(0, 0);
            dgvRoba.Name = "dgvRoba";
            dgvRoba.ReadOnly = true;
            dgvRoba.RowTemplate.Height = 25;
            dgvRoba.Size = new Size(575, 560);
            dgvRoba.TabIndex = 0;
            // 
            // FrmRoba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 584);
            Controls.Add(panel1);
            Controls.Add(pnlOsoba);
            Name = "FrmRoba";
            Text = "FrmRoba";
            pnlOsoba.ResumeLayout(false);
            pnlOsoba.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoba).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOsoba;
        private Button btnDodaj;
        private Label label2;
        private TextBox txtPrezime;
        private Label label1;
        private TextBox txtIme;
        private Panel panel1;
        private DataGridView dgvRoba;
    }
}