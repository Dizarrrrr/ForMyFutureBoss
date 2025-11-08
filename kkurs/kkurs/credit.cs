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
    public partial class credit : Form
    {
        int id;
        ws01Entities conn = new ws01Entities();
        public credit(int idsotr)
        {
            InitializeComponent();
            id = idsotr;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=WSS\SQLEXPRESS;Database=ws01;User ID=ws01;Password=123qweR%";

            string select = "SELECT * FROM Credits";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(select, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;



            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка подключения");
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=WSS\SQLEXPRESS;Database=ws01;User ID=ws01;Password=123qweR%";
            SqlConnection connection = new SqlConnection(connectionString);

            int idep = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            string delete = "DELETE FROM Credits WHERE ID_credita = " + idep;
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(delete, connection);
                int num = command.ExecuteNonQuery();
                MessageBox.Show("Удалено " + num + " записей");
            }
            catch
            {
                MessageBox.Show("Ошибка подключения");
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addcredit ad = new addcredit(id);
            ad.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 ex = new Form1();
            ex.Show();
            this.Hide();
        }

        private void credit_Load(object sender, EventArgs e)
        {

        }
    }
}
