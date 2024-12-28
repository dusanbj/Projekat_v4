namespace WinForms
{
    partial class FrmGlavna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            klijentToolStripMenuItem = new ToolStripMenuItem();
            dodajKlijentaToolStripMenuItem = new ToolStripMenuItem();
            radSaKlijentimaToolStripMenuItem = new ToolStripMenuItem();
            prikaziKlijenteToolStripMenuItem = new ToolStripMenuItem();
            reversToolStripMenuItem = new ToolStripMenuItem();
            dodajReversToolStripMenuItem = new ToolStripMenuItem();
            robaToolStripMenuItem = new ToolStripMenuItem();
            dodajRobuToolStripMenuItem = new ToolStripMenuItem();
            pretraziRobuToolStripMenuItem = new ToolStripMenuItem();
            strucnaSpremaToolStripMenuItem = new ToolStripMenuItem();
            pnlMain = new Panel();
            radSaRobomToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { klijentToolStripMenuItem, reversToolStripMenuItem, robaToolStripMenuItem, strucnaSpremaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // klijentToolStripMenuItem
            // 
            klijentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajKlijentaToolStripMenuItem, radSaKlijentimaToolStripMenuItem, prikaziKlijenteToolStripMenuItem });
            klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            klijentToolStripMenuItem.Size = new Size(52, 20);
            klijentToolStripMenuItem.Text = "Klijent";
            // 
            // dodajKlijentaToolStripMenuItem
            // 
            dodajKlijentaToolStripMenuItem.Name = "dodajKlijentaToolStripMenuItem";
            dodajKlijentaToolStripMenuItem.Size = new Size(180, 22);
            dodajKlijentaToolStripMenuItem.Text = "Dodaj klijenta";
            dodajKlijentaToolStripMenuItem.Click += dodajKlijentaToolStripMenuItem_Click_1;
            // 
            // radSaKlijentimaToolStripMenuItem
            // 
            radSaKlijentimaToolStripMenuItem.Name = "radSaKlijentimaToolStripMenuItem";
            radSaKlijentimaToolStripMenuItem.Size = new Size(180, 22);
            radSaKlijentimaToolStripMenuItem.Text = "Rad sa klijentima";
            radSaKlijentimaToolStripMenuItem.Click += radSaKlijentimaToolStripMenuItem_Click;
            // 
            // prikaziKlijenteToolStripMenuItem
            // 
            prikaziKlijenteToolStripMenuItem.Name = "prikaziKlijenteToolStripMenuItem";
            prikaziKlijenteToolStripMenuItem.Size = new Size(180, 22);
            prikaziKlijenteToolStripMenuItem.Text = "Prikazi klijente";
            prikaziKlijenteToolStripMenuItem.Click += prikaziKlijenteToolStripMenuItem_Click;
            // 
            // reversToolStripMenuItem
            // 
            reversToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajReversToolStripMenuItem });
            reversToolStripMenuItem.Name = "reversToolStripMenuItem";
            reversToolStripMenuItem.Size = new Size(53, 20);
            reversToolStripMenuItem.Text = "Revers";
            // 
            // dodajReversToolStripMenuItem
            // 
            dodajReversToolStripMenuItem.Name = "dodajReversToolStripMenuItem";
            dodajReversToolStripMenuItem.Size = new Size(139, 22);
            dodajReversToolStripMenuItem.Text = "Dodaj revers";
            // 
            // robaToolStripMenuItem
            // 
            robaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajRobuToolStripMenuItem, radSaRobomToolStripMenuItem, pretraziRobuToolStripMenuItem });
            robaToolStripMenuItem.Name = "robaToolStripMenuItem";
            robaToolStripMenuItem.Size = new Size(46, 20);
            robaToolStripMenuItem.Text = "Roba";
            // 
            // dodajRobuToolStripMenuItem
            // 
            dodajRobuToolStripMenuItem.Name = "dodajRobuToolStripMenuItem";
            dodajRobuToolStripMenuItem.Size = new Size(180, 22);
            dodajRobuToolStripMenuItem.Text = "Dodaj robu";
            dodajRobuToolStripMenuItem.Click += dodajRobuToolStripMenuItem_Click;
            // 
            // pretraziRobuToolStripMenuItem
            // 
            pretraziRobuToolStripMenuItem.Name = "pretraziRobuToolStripMenuItem";
            pretraziRobuToolStripMenuItem.Size = new Size(180, 22);
            pretraziRobuToolStripMenuItem.Text = "Prikazi robu";
            pretraziRobuToolStripMenuItem.Click += pretraziRobuToolStripMenuItem_Click;
            // 
            // strucnaSpremaToolStripMenuItem
            // 
            strucnaSpremaToolStripMenuItem.Name = "strucnaSpremaToolStripMenuItem";
            strucnaSpremaToolStripMenuItem.Size = new Size(102, 20);
            strucnaSpremaToolStripMenuItem.Text = "Strucna Sprema";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ActiveCaption;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 24);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 426);
            pnlMain.TabIndex = 1;
            // 
            // radSaRobomToolStripMenuItem
            // 
            radSaRobomToolStripMenuItem.Name = "radSaRobomToolStripMenuItem";
            radSaRobomToolStripMenuItem.Size = new Size(180, 22);
            radSaRobomToolStripMenuItem.Text = "Rad sa robom";
            radSaRobomToolStripMenuItem.Click += radSaRobomToolStripMenuItem_Click;
            // 
            // FrmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmGlavna";
            Text = "Program";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem klijentToolStripMenuItem;
        private ToolStripMenuItem dodajKlijentaToolStripMenuItem;
        private ToolStripMenuItem radSaKlijentimaToolStripMenuItem;
        private Panel pnlMain;
        private ToolStripMenuItem prikaziKlijenteToolStripMenuItem;
        private ToolStripMenuItem reversToolStripMenuItem;
        private ToolStripMenuItem dodajReversToolStripMenuItem;
        private ToolStripMenuItem robaToolStripMenuItem;
        private ToolStripMenuItem dodajRobuToolStripMenuItem;
        private ToolStripMenuItem pretraziRobuToolStripMenuItem;
        private ToolStripMenuItem strucnaSpremaToolStripMenuItem;
        private ToolStripMenuItem radSaRobomToolStripMenuItem;
    }
}
