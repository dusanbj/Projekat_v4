using Domen;
using KlijentskaAplikacija;
using KlijentskaAplikacija.UserControls;
using WinForms.UserControls;

namespace WinForms
{
    public partial class FrmGlavna : Form
    {
        private Zaposleni dbUser;

        public FrmGlavna(Zaposleni dbUser)
        {
            InitializeComponent();
            this.dbUser = dbUser;
            this.Text = $"Admin: {dbUser.Ime} {dbUser.Prezime}";

        }

        private void radSaKlijentimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKlijenti frmOsobe = new FrmKlijenti();
            frmOsobe.ShowDialog();
        }

        private void dodajKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodajKlijentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var uc = new UCDodajKlijenta(Utils.FrmMode.Add);
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void prikaziKlijenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var uc = new UCPrikaziKlijente();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dodajRobuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var uc = new UCDodajRobu(Utils.FrmMode.Add);
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void pretraziRobuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoba frmRoba = new FrmRoba();
            frmRoba.ShowDialog();
        }

        private void radSaRobomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
