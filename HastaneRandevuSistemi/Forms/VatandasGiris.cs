using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi.Forms
{
    public partial class VatandasGiris : Form
    {
        public VatandasGiris()
        {
            InitializeComponent();
        }
        Data.SqlMethods sqlMethods = new Data.SqlMethods(Program.connectionString);
        RandevuMenu randevuMenu = new RandevuMenu();
        VatandasUyelik vatandasUyelik = new VatandasUyelik();
        //Business.RandevuMenuBusiness randevuMenuBusiness = new Business.RandevuMenuBusiness();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Hastauyelik where hasta_nicki='"+txtKullaniciAdi.Text+"' AND hasta_parola='"+txtSifre.Text+"'";
            sqlMethods.LoginCheck(sorgu,randevuMenu,this);
            string sqlCommandText = "Select hasta_id from Hastauyelik where hasta_nicki= '" + txtKullaniciAdi.Text + "'";
            sqlMethods.KullaniciAdiConvertToId(sqlCommandText,"hasta_id");
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vatandasUyelik.Show();
            this.Hide();
        }

        private void VatandasGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
