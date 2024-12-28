using Domen;
using KlijentskaAplikacija.UIKontroler;
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

namespace WinForms.UserControls
{
    public partial class UCDodajKlijenta : UserControl
    {
        private readonly FrmMode mode;

        private Kontroler kontroler = Kontroler.Instance;

        public UCDodajKlijenta(FrmMode mode)
        {
            InitializeComponent();
            this.mode = mode;
            if (mode == FrmMode.Add)
            {
                btn.Text = "Dodaj klijenta";
            }
            if (mode == FrmMode.Details)
            {
                btn.Visible = false;
                txtIme.Enabled = false;
                txtPrezime.Enabled = false;
                cmbGrad.Enabled = false;

            }
            else if (mode == FrmMode.Edit)
            {
                btn.Text = "Izmeni";
            }
            cmbGrad.DataSource = Kontroler.Instance.VratiMesta();

        }

        private bool Validacija()
        {
            if (string.IsNullOrEmpty(txtIme.Text)
                                || string.IsNullOrEmpty(txtPrezime.Text)
                                || string.IsNullOrEmpty(txtBrojTelefona.Text))
            {
                MessageBox.Show("Nisu uneti svi podaci!");
                return false;
            }
            return true;
        }

        private Klijent ProcitajPodatkeSaForme()
        {
            Klijent k = new();
            k.Ime = txtIme.Text;
            k.Prezime = txtPrezime.Text;
            k.BrTelefona = txtBrojTelefona.Text;
            k.Mesto = (Mesto)cmbGrad.SelectedItem;
            return k;
        }

        private void btn_Click(object sender, EventArgs e)
        {



        }

        private void btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!Validacija()) return;

                Klijent k = ProcitajPodatkeSaForme();
                if (mode == FrmMode.Add)
                {
                    kontroler.dodajKlijenta(k);
                    MessageBox.Show("Osoba je uspesno sacuvana!");
                }
                else
                {
                    //k.UpdatePerson(o);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajGrad_Click(object sender, EventArgs e)
        {
            GradDialog gradDialog = new GradDialog();
            gradDialog.ShowDialog();
        }
    }
}
