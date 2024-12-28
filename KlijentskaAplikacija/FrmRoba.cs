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

namespace KlijentskaAplikacija
{
    public partial class FrmRoba : Form
    {
        BindingList<Roba> roba = new BindingList<Roba>();
        public FrmRoba()
        {
            InitializeComponent();
            dgvRoba.DataSource = Kontroler.Instance.vratiRobu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
