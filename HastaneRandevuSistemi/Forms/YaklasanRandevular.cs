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
    public partial class YaklasanRandevular : Form
    {
        public YaklasanRandevular()
        {
            InitializeComponent();
        }
        Data.SqlMethods sqlMethods = new Data.SqlMethods(Program.connectionString);

        private void YaklasanRandevular_Load(object sender, EventArgs e)
        {
            string sqlCommandText="select * from Randevular where hasta_id="+Data.SqlMethods.hastaId+"";
            sqlMethods.SelectSpecialData(sqlCommandText);
            dataGridView1.DataSource = sqlMethods.sqlDt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text =dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            sqlMethods.DeleteData("Randevular","id",id);
            MessageBox.Show("Randevunuz iptal edilmiştir. İyi Günler!");
        }

        private void yeniRandevuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RandevuMenu().Show();
            this.Hide();
        }
    }
}
