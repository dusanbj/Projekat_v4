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

namespace WinForms
{
    public partial class GradDialog : Form
    {
        public GradDialog()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text) || string.IsNullOrEmpty(txtPtt.Text))
            {
                MessageBox.Show("Nisu uneti svi podaci!");
            }
            else
            {
                Mesto m = new Mesto();
                m.Ptt = long.Parse(txtPtt.Text);
                m.Naziv = txtNaziv.Text;
                Kontroler.Instance.dodajMesto(m);

                DialogResult = DialogResult.OK;
            }
            
        }
    }
}
