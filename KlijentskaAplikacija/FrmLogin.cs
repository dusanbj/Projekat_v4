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

namespace WinForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private bool Validacija()
        {
            txtUsername.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
            bool isValid = true;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.BackColor = Color.Salmon;
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BackColor = Color.Salmon;
                isValid = false;
            }
            return isValid;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (!Validacija()) return;
            Zaposleni u = new Zaposleni()
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
            };
            try
            {
                //Kontroler k = new Kontroler();
                //User dbUser = k.Login(u);
                Kontroler kontroler = Kontroler.Instance;
                kontroler.PoveziSe();
                Zaposleni user = kontroler.Login(u);
                MessageBox.Show("Uspesno povezivanje sa serverom!");


                FrmGlavna glavna = new FrmGlavna(user);
                this.Visible = false;
                glavna.ShowDialog();
                this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
