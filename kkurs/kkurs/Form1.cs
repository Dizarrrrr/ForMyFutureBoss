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
    public partial class Form1 : Form
    {
        private string hintLogin = "Логин", hintPassword = "Пароль";
        ws01Entities conn = new ws01Entities();
        public Form1()
        {
            InitializeComponent();
            radioButtonKlient.Checked = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == hintLogin)
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == hintPassword)
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = hintLogin;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = hintPassword;
                textBox2.PasswordChar = '\0';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userCadr = "credit";
            string cadrPassword = "456";
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(radioButtonKlient.Checked && username != userCadr)
            {
                if(conn.Klient.Any(a=>a.Login == username && a.Password == password))
                {
                    int idKlient = conn.Klient.SingleOrDefault(l=>l.Login == username).ID_klienta;
                    forklient kl = new forklient(idKlient);
                    kl.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Вы ввели неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (radioButtonSotrudnik.Checked && username != userCadr)
            {
                if(conn.Sotrudnik.Any(a => a.Login == username && a.Password == password))
                {
                    int idsotr = conn.Sotrudnik.SingleOrDefault(l => l.Login == username).ID_sotrudnika;
                    credit credit = new credit(idsotr);
                    credit.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Вы ввели неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (username == "credit" && password == "456")
            {

                sotr otdel = new sotr();
                otdel.Show();
                this.Hide();
            }

        }

    }
}
