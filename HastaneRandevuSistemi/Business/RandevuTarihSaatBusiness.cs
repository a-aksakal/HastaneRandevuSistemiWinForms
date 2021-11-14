using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HastaneRandevuSistemi.Business
{
    class RandevuTarihSaatBusiness
    {
        public string timeText;
        public void ClickAppointmentTime(Button button)
        {
            timeText = button.Text;

        }
        public void ButtonEnabled(Button button)
        {
            button.Enabled = true;
            button.BackColor = Color.LimeGreen;
        }

        public void ButtonDisabled(Button button)
        {
            button.Enabled = false;
            button.BackColor = Color.Gray;
        }
    }
}
