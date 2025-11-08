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
    public partial class addcredit : Form
    {
        ws01Entities conn = new ws01Entities();
        private int id;
        public addcredit(int idSotr)
        {
            InitializeComponent();
            id = idSotr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            credit sot = new credit(id);
            sot.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now.Date;
            Credits item = new Credits
            {
                ID_klienta = Convert.ToInt32(textBox1.Text),
                Sum_Credita = Convert.ToInt32(textBox3.Text),
                Procent_credita = textBox4.Text,
                Date_Oformleniya = date.ToShortDateString(),
                ID__sotrudnika = id
            };
            conn.Credits.Add(item);
            conn.SaveChanges();

            credit sot = new credit(id);
            sot.Show();
            this.Hide();
        }

        private void addcredit_Load(object sender, EventArgs e)
        {

        }
    }
}
