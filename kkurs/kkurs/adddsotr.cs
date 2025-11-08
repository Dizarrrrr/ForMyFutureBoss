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
    public partial class adddsotr : Form
    {
        ws01Entities conn = new ws01Entities();
        public adddsotr()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sotr sot = new sotr();
            sot.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string Name = textBox1.Text;
            string YYYY = textBox2.Text;
            string Passport = textBox3.Text;
            string Dolgnost = textBox4.Text;
            string otdel = textBox5.Text;
            int zp = Convert.ToInt32(textBox6.Text);
            string login = textBox7.Text;
            string password = textBox8.Text;

            Sotrudnik item = new Sotrudnik
            {
                FIO_sotrudnika = Name,
                YYYY_MM_DD = YYYY,
                Passport__Seria__Num_ = Passport,
                dolgnost = Dolgnost,
                otdel = otdel,
                Zarplata = zp,
                Login = login,
                Password = password
            };
            conn.Sotrudnik.Add(item);
            conn.SaveChanges();

            sotr sot = new sotr();
            sot.Show();
            this.Hide();
        }

        private void adddsotr_Load(object sender, EventArgs e)
        {

        }
    }
}
