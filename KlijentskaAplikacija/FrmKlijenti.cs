using Domen;
using KlijentskaAplikacija.UIKontroler;

//using PoslovnaLogika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Utils;

namespace WinForms
{
    public partial class FrmKlijenti : Form
    {
        private BindingList<Klijent> klijenti = new BindingList<Klijent>();

        private Kontroler kon = Kontroler.Instance;
        public FrmKlijenti()
        {
            InitializeComponent();
            cmbGrad.DataSource = kon.VratiMesta();
            cmbGrad.DisplayMember = "Naziv";

            dgvOsobe.DataSource = klijenti;
            dgvOsobe.Columns["id"].Visible = false;


            dgvOsobe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIme.Text)
                    || string.IsNullOrEmpty(txtPrezime.Text))
                {
                    MessageBox.Show("Nisu uneti svi podaci!");
                    return;
                }

                Klijent k = new();
                k.Ime = txtIme.Text;
                k.Prezime = txtPrezime.Text;
                k.BrTelefona = txtBrojTelefona.Text;
                k.Mesto = (Mesto)cmbGrad.SelectedItem;

                DialogResult result = MessageBox.Show("Da li ste sigurni da zelite da sacuvate?",
                    "Sacuvaj klijenta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    klijenti.Add(k);
                }
                else
                {
                    MessageBox.Show("Nije sacuvano!");
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            if (dgvOsobe.SelectedRows.Count > 0)
            {
                Klijent k = (Klijent)dgvOsobe.SelectedRows[0].DataBoundItem;
                klijenti.Remove(k);
            }
            MessageBox.Show("Niste odabrali red!");
        }

        private void btnDodajGrad_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajGrad_Click_1(object sender, EventArgs e)
        {
            GradDialog dialog = new GradDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Grad nije uspesno dodat!");
                // azuriranje cmb da ukljuci i dodati grad
                cmbGrad.DataSource = null;
                cmbGrad.DataSource = kon.VratiMesta();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kon.SacuvajSveKlijente(klijenti.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvOsobe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
