namespace KlijentskaAplikacija.UserControls
{
    partial class UCDodajRobu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNaziv = new TextBox();
            txtOpis = new TextBox();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 55);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Naziv:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 102);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Opis:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(111, 47);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(141, 23);
            txtNaziv.TabIndex = 2;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(111, 94);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(141, 23);
            txtOpis.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(141, 143);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // UCDodajRobu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDodaj);
            Controls.Add(txtOpis);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCDodajRobu";
            Size = new Size(345, 207);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNaziv;
        private TextBox txtOpis;
        private Button btnDodaj;
    }
}
