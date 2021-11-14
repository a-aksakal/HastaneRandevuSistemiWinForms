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
    public partial class RandevuMenu : Form
    {
        public RandevuMenu()
        {
            InitializeComponent();
        }

        static Business.RandevuMenuBusiness randevuMenuBusiness = new Business.RandevuMenuBusiness();
        Data.SqlMethods sqlMethods = new Data.SqlMethods(Program.connectionString);
        RandevuTarihSaat randevuTarihSaat = new RandevuTarihSaat();
        YaklasanRandevular yaklasanRandevular = new YaklasanRandevular();


        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlCommandText = "select ilce from iller inner join ilceler on iller.id = ilceler.sehir where iller.sehir = '" + cmbil.Text + "'";
            sqlMethods.FillCombobox(sqlCommandText, cmbilce, "ilce");
            randevuMenuBusiness.cmbTextClear(cmbBolum, cmbHastane, cmbDoktor);
        }

        private void RandevuMenu_Load(object sender, EventArgs e)
        {
            string sqlCommandText = "select sehir from iller";
            sqlMethods.FillCombobox(sqlCommandText, cmbil, "sehir");
            string sqlCommandText2 = "select bolum_adi from Bolumler";
            sqlMethods.FillCombobox(sqlCommandText2, cmbBolum, "bolum_adi");

        }

        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlCommandText = "select distinct hastane from ilceler inner join TRHastaneler on ilceler.ilce = TRHastaneler.ilce_adi where ilceler.ilce = '" + cmbilce.Text + "'";
            sqlMethods.FillCombobox(sqlCommandText, cmbHastane, "hastane");
            randevuMenuBusiness.cmbTextClear(cmbBolum, cmbHastane, cmbDoktor);
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlCommandText2 = "select bolum_id from Bolumler where bolum_adi= '" + cmbBolum.Text + "'";
            sqlMethods.NameConvertToBolumId(sqlCommandText2, "bolum_id");
            string sqlCommandText = "select doktor_adiSoyadi from Doktorlar inner join TRHastaneler on Doktorlar.hastane_id = TRHastaneler.id inner join Bolumler on Doktorlar.bolum_id = Bolumler.bolum_id where Doktorlar.hastane_id=" + Data.SqlMethods.hastaneId + " and Doktorlar.bolum_id=" + Data.SqlMethods.bolumId + "";
            sqlMethods.FillCombobox(sqlCommandText, cmbDoktor, "doktor_adiSoyadi");
            randevuMenuBusiness.cmbTextClear(cmbDoktor);
        }

        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlCommandText = "select bolum_adi from bolumler";
            string sqlCommandText2 = "Select id from TRHastaneler where hastane= '" + cmbHastane.Text + "'";
            sqlMethods.NameConvertToHastaneId(sqlCommandText2, "id");
            sqlMethods.FillCombobox(sqlCommandText, cmbBolum, "bolum_adi");
            randevuMenuBusiness.cmbTextClear(cmbBolum, cmbDoktor);

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yaklaşanRandevularımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnileri_Click(object sender, EventArgs e)
        {
            randevuMenuBusiness.SaveTheInfos(cmbil.Text, cmbilce.Text, cmbHastane.Text, cmbBolum.Text, cmbDoktor.Text);
            randevuTarihSaat.Show();
            this.Hide();
        }

        private void yaklaşanRandevularımToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            yaklasanRandevular.Show();
            this.Hide();
        }
    }
}
