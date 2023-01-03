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
                MessageBox.Show("giriþ baþarýlý", "kullanýcý giriþi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anasayfa an = new anasayfa();
                an.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("giriþ yapýlamadý", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            kayýt k = new kayýt();
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