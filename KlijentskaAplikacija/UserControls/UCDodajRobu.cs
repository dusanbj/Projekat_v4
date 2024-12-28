using Domen;
using KlijentskaAplikacija.UIKontroler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace KlijentskaAplikacija.UserControls
{
    public partial class UCDodajRobu : UserControl
    {
        private readonly FrmMode mode;
        public UCDodajRobu(FrmMode mode)
        {
            InitializeComponent();
            this.mode = mode;
            if(mode == FrmMode.Add)
            {
                btnDodaj.Visible = true;
                btnDodaj.Enabled = true;
                btnDodaj.Text = "Dodaj";
            } 
            else if(mode == FrmMode.Details)
            {
                btnDodaj.Visible = false;
                txtNaziv.Enabled = false;
                txtOpis.Enabled = false;
            }
            else if( mode == FrmMode.Edit)
            {
                btnDodaj.Text = "Izmeni";
                btnDodaj.Visible = true;
                btnDodaj.Enabled = true;
            }
        }

        private bool Validacija()
        {
            if (string.IsNullOrEmpty(txtNaziv.Text) || string.IsNullOrEmpty(txtOpis.Text))                  
            {
                MessageBox.Show("Nisu uneti svi podaci!");
                return false;
            }
            return true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.Validacija())
            {
                Roba r = new();
                r.Naziv = txtNaziv.Text;
                r.Opis = txtOpis.Text;
                Kontroler.Instance.dodajRobu(r);
            }
        }
    }
}
