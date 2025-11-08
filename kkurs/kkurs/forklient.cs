using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace kkurs
{
    public partial class forklient : Form
    {
        ws01Entities conn = new ws01Entities();
        public forklient(int idClient)
        {
            InitializeComponent();
            var filter = from c in conn.Credits
                         where (c.ID_klienta == idClient)
                         join s in conn.Sotrudnik on c.ID__sotrudnika equals s.ID_sotrudnika
                         join k in conn.Klient on c.ID_klienta equals k.ID_klienta
                         select new { c.Sum_Credita, c.Procent_credita, c.Date_Oformleniya, s.FIO_sotrudnika };
            dataGridView1.DataSource = filter.ToList();
            dataGridView1.Columns[0].HeaderText = "Сумма кредита";
            dataGridView1.Columns[1].HeaderText = "Процент кредита";
            dataGridView1.Columns[2].HeaderText = "Дата оформления";
            dataGridView1.Columns[3].HeaderText = "ФИО сотрудника";
            labelName.Text = "ФИО: " + conn.Klient.SingleOrDefault(a=>a.ID_klienta == idClient).FIO_klienta;
            labelSnils.Text = "СНИЛС: " + conn.Klient.SingleOrDefault(a => a.ID_klienta == idClient).Snils;
            labelPassport.Text = "Паспорт: " + conn.Klient.SingleOrDefault(a => a.ID_klienta == idClient).Passport;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
