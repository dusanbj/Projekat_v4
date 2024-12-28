namespace WinForms.UserControls
{
    partial class UCDodajKlijenta
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
            btnDodajGrad = new Button();
            btn = new Button();
            cmbGrad = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtBrojTelefona = new TextBox();
            label2 = new Label();
            txtPrezime = new TextBox();
            label1 = new Label();
            txtIme = new TextBox();
            SuspendLayout();
            // 
            // btnDodajGrad
            // 
            btnDodajGrad.Anchor = AnchorStyles.None;
            btnDodajGrad.Location = new Point(265, 153);
            btnDodajGrad.Name = "btnDodajGrad";
            btnDodajGrad.Size = new Size(38, 23);
            btnDodajGrad.TabIndex = 11;
            btnDodajGrad.Text = "+";
            btnDodajGrad.UseVisualStyleBackColor = true;
            btnDodajGrad.Click += btnDodajGrad_Click;
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.None;
            btn.Location = new Point(28, 254);
            btn.Name = "btn";
            btn.Size = new Size(295, 29);
            btn.TabIndex = 10;
            btn.Text = "Dodaj";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click_1;
            // 
            // cmbGrad
            // 
            cmbGrad.Anchor = AnchorStyles.None;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(107, 153);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(152, 23);
            cmbGrad.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(66, 154);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "Grad:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(24, 108);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 5;
            label3.Text = "Broj telefona:";
            label3.Click += label3_Click;
            // 
            // txtBrojTelefona
            // 
            txtBrojTelefona.Anchor = AnchorStyles.None;
            txtBrojTelefona.Location = new Point(107, 105);
            txtBrojTelefona.Name = "txtBrojTelefona";
            txtBrojTelefona.Size = new Size(196, 23);
            txtBrojTelefona.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(49, 68);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Anchor = AnchorStyles.None;
            txtPrezime.Location = new Point(107, 63);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(196, 23);
            txtPrezime.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(71, 24);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Anchor = AnchorStyles.None;
            txtIme.Location = new Point(107, 19);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(196, 23);
            txtIme.TabIndex = 0;
            // 
            // UCDodajKlijenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDodajGrad);
            Controls.Add(btn);
            Controls.Add(txtIme);
            Controls.Add(cmbGrad);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtPrezime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBrojTelefona);
            Name = "UCDodajKlijenta";
            Size = new Size(335, 308);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodajGrad;
        private Button btn;
        private ComboBox cmbGrad;
        private Label label4;
        private Label label3;
        private TextBox txtBrojTelefona;
        private Label label2;
        private TextBox txtPrezime;
        private Label label1;
        private TextBox txtIme;
    }
}
