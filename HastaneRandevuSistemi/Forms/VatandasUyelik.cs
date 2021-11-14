using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuSistemi.Forms;

namespace HastaneRandevuSistemi.Forms
{
    public partial class VatandasUyelik : Form
    {
        public VatandasUyelik()
        {
            InitializeComponent();
        }
        Data.SqlMethods sqlMethods = new Data.SqlMethods(Program.connectionString);

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlCommandText = "Select * From Hastauyelik where hasta_nicki='" + txtKullaniciAd.Text + "'";
            string sqlAddData = "Insert into Hastauyelik (hasta_adiSoyadi,hasta_nicki,hasta_parola) values ('" + txtAd.Text + " " + txtSoyad.Text + "','" + txtKullaniciAd.Text + "','" + txtSifre.Text + "')";
            sqlMethods.SignUp(sqlCommandText,sqlAddData);
            MessageBox.Show("Üyelik oluşturulmuştur.");
            new VatandasGiris().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new VatandasGiris().Show();
            this.Hide();
            
        }

        private void VatandasUyelik_Load(object sender, EventArgs e)
        {

        }
    }
}
