using Domen;
using KlijentskaAplikacija.UIKontroler;

//using PoslovnaLogika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.UserControls
{
    public partial class UCPrikaziKlijente : UserControl
    {
        //private Kontroler k = new Kontroler();
        public UCPrikaziKlijente()
        {
            InitializeComponent();
            dgvOsobe.DataSource = Kontroler.Instance.VratiKlijente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvOsobe.SelectedRows.Count > 0)
            {
                Klijent odabranaOsoba = (Klijent)dgvOsobe.SelectedRows[0].DataBoundItem;

                //vrati osobu iz baze
                //Osoba o = k.VratiOsobu(odabranaOsoba.Id);
                // instanciranje forme
            //formi treba proslediti o
            }

        }
    }
}
