using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi.Business
{
    class RandevuMenuBusiness
    {
        public static string il;
        public static string ilce;
        public static string hastaneAdi;
        public static string bolum;
        public static string doktorAdiSoyadi;
        public void cmbTextClear(ComboBox cmb1)
        {
            cmb1.Text = null;
        }
        public void cmbTextClear(ComboBox cmb1,ComboBox cmb2)
        {
            cmb1.Text = null;
            cmb2.Text = null;
        }

        public void cmbTextClear(ComboBox cmb1, ComboBox cmb2, ComboBox cmb3)
        {
            cmb1.Text = null;
            cmb2.Text = null;
            cmb3.Text = null;
        }

        public void cmbTextClear(ComboBox cmb1, ComboBox cmb2, ComboBox cmb3, ComboBox cmb4)
        {
            cmb1.Text = null;
            cmb2.Text = null;
            cmb3.Text = null;
            cmb4.Text = null;
        }

        public void SaveTheInfos(string cmbilText, string cmbilceText, string cmbHastaneText, string cmbBolumText, string cmbDoktorText)
        {
           RandevuMenuBusiness.il = cmbilText;
           RandevuMenuBusiness.ilce = cmbilceText;
           RandevuMenuBusiness.hastaneAdi = cmbHastaneText;
           RandevuMenuBusiness.bolum = cmbBolumText;
           RandevuMenuBusiness.doktorAdiSoyadi = cmbDoktorText;
        }

    }
}
