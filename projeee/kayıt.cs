using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeee
{
    public partial class kayıt : Form
    {
        public kayıt()
        {
            InitializeComponent();
        }

        string con = "Server=localhost;Database=proje;Uid=root;Pwd='';";
        private void kayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglan = new MySqlConnection(con);
                string sorgu = "Insert into kullanici values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Eklendi.","BANDIRMA SÜRÜCÜ KURSU",MessageBoxButtons.OK,MessageBoxIcon.Information);
                giris g = new giris();
                g.Show();
                this.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
