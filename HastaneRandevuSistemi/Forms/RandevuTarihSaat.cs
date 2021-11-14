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
    public partial class RandevuTarihSaat : Form
    {
        public RandevuTarihSaat()
        {
            InitializeComponent();
        }

        Data.SqlMethods SqlMethods = new Data.SqlMethods(Program.connectionString);
        Business.RandevuTarihSaatBusiness randevuTarihSaatBusiness = new Business.RandevuTarihSaatBusiness();

        private void RandevuTarihSaat_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = System.DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            string sqlCommandText = "Select Saat from Randevular where Tarih='"+dateTimePicker1.Value.ToString("yyyyMMdd")+"' and doktor_adiSoyadi='"+Business.RandevuMenuBusiness.doktorAdiSoyadi+"'";
            SqlMethods.CheckAppointment(sqlCommandText, "Saat", panel1);
            randevuTarihSaatBusiness.ButtonDisabled(btnRandevuAl);
        }

        private void btn900_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn900);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn915_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn915);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn930_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn930);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn945_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn945);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1000);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1015_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1015);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1030_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1030);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1045_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1045);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1100_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1100);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1115_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1115);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1130_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1130);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1145_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1145);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1330_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1330);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1345_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1345);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1400_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1400);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1415_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1415);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1430_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1430);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1445_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1445);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1500_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1500);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1515_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1515);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1530_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1530);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btn1545_Click(object sender, EventArgs e)
        {
            randevuTarihSaatBusiness.ClickAppointmentTime(btn1545);
            randevuTarihSaatBusiness.ButtonEnabled(btnRandevuAl);
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            string sqlCommandText = "Insert into Randevular (hastane,bolum,doktor_adiSoyadi,Tarih,Saat,hasta_id) values ('"+Business.RandevuMenuBusiness.hastaneAdi+"','"+Business.RandevuMenuBusiness.bolum+"','" + Business.RandevuMenuBusiness.doktorAdiSoyadi + "','" + dateTimePicker1.Value.ToString("yyyyMMdd") + "','" + randevuTarihSaatBusiness.timeText + "'," + Data.SqlMethods.hastaId + ")";
            SqlMethods.AddData(sqlCommandText);
            MessageBox.Show("Randevu oluşturulmuştur.");
            new RandevuMenu().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RandevuMenu().Show();
            this.Hide();
        }

        private void yaklaşanRandevularımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new YaklasanRandevular().Show();
            this.Hide();
        }
    }
}
