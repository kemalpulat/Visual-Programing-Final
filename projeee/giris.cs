using System.Windows.Forms;

namespace projeee
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        kontrol g = new kontrol();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (g.giris(textBox1.Text, textBox2.Text) == 1)
            {
                MessageBox.Show("giri� ba�ar�l�", "kullan�c� giri�i", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anasayfa an = new anasayfa();
                an.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("giri� yap�lamad�", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            kay�t k = new kay�t();
            k.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            unut un = new unut();
            un.Show();
        }
    }
}