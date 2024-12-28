namespace WinForms.UserControls
{
    partial class UCPrikaziKlijente
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
            this.dgvOsobe = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOsobe
            // 
            this.dgvOsobe.AllowUserToAddRows = false;
            this.dgvOsobe.AllowUserToDeleteRows = false;
            this.dgvOsobe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOsobe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOsobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsobe.Location = new System.Drawing.Point(0, 0);
            this.dgvOsobe.Name = "dgvOsobe";
            this.dgvOsobe.ReadOnly = true;
            this.dgvOsobe.RowTemplate.Height = 25;
            this.dgvOsobe.Size = new System.Drawing.Size(602, 426);
            this.dgvOsobe.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(608, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prikazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UCPrikaziOsobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOsobe);
            this.Name = "UCPrikaziOsobe";
            this.Size = new System.Drawing.Size(730, 429);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvOsobe;
        private Button button1;
    }
}
