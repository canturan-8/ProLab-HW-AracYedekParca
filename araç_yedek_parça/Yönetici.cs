//210229040_SalihCanTuran

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araç_yedek_parça
{
    public partial class Yönetici : Form
    {
        public Yönetici()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void müşteri_silme_buton_Click(object sender, EventArgs e)
        {
            //satıcıları satıcı.txt den okuyup listeledim
            string eski_liste = "müşteri.txt";
            List<user> liste = new List<user>();
            admin.Reader_kişi_bilgisi(eski_liste, liste);

            //silinecek satıcıyı ayıkladım ve diğerlerini yeni bir liste yaptım.
            var yeniListe = liste.Where(item => item.user_name != müşteri_isim.Text).ToList();

            //yeni listeyi dosyaya yazdırdım.
            string yeni_liste = "müşteri.txt";
            admin.kişi_dosyası_güncelleme(yeni_liste, yeniListe);
            MessageBox.Show("Customer deleted successfully");
        }

        private void müşteri_isim_TextChanged(object sender, EventArgs e)
        {

        }

        private void satıcı_silme_buton_Click(object sender, EventArgs e)
        {
            //satıcıları satıcı.txt den okuyup listeledim
            string eski_liste = "satıcı.txt";
            List<user> liste = new List<user>();
            admin.Reader_kişi_bilgisi(eski_liste, liste);

            //silinecek satıcıyı ayıkladım ve diğerlerini yeni bir liste yaptım.
            var yeniListe = liste.Where(item => item.user_name != satıcı_isim.Text).ToList();

            //yeni listeyi dosyaya yazdırdım.
            string yeni_liste = "satıcı.txt";
            admin.kişi_dosyası_güncelleme(yeni_liste, yeniListe);
            MessageBox.Show("Seller deleted successfully");
        }




 

        private void satıcı_isim_TextChanged(object sender, EventArgs e)
        {

        }

        private void araç_silme_buton_Click(object sender, EventArgs e)
        {
            //kontol amaçlı text ifadeleri string değişkene atadım.
            string marka = marka_text.Text;
            string modelim = Model_text.Text;
            string paketim = paket_text.Text;
            string yedek = parça_text.Text;

            //araç dosyasını okuyup listeye attım
            string eski_liste = "arabalar.txt";
            List<car> liste = new List<car>();
            car.car_reader(eski_liste, liste);

            //listede ilgili aracı arayıp buldum ve listeden sildim.
            car silinen = liste.Find(item => item.Marka == marka && item.Model == modelim && item.Paket == paketim && item.Yedek_parça == yedek);
            liste.Remove(silinen);

            //listeyi güncelledim ve dosyaya attım araçları
            string yeni_liste = "arabalar.txt";
            car.arac_güncelleme(yeni_liste, liste);
            MessageBox.Show("The vehicle was successfully deleted");

        }

        private void paket_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Model_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void marka_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void parça_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Yönetici_Load(object sender, EventArgs e)
        {

        }

        private void müşteri_listele_Click(object sender, EventArgs e)
        {
            //listeyi öncekine eklemesin diye temizliyoruz her click'de
            listBox1.Items.Clear();
            string liste = "müşteri.txt";
            List<user> kayıtlılar = new List<user>();
            admin.Reader_kişi_bilgisi(liste, kayıtlılar);
            foreach (var item in kayıtlılar)
            {
                listBox1.Items.Add(item.user_name + "//" + item.user_name + "//" + item.user_password + "//" + item.user_phone + "//" + item.user_email);
            }
        }

        private void araç_listele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string liste = "arabalar.txt";
            List<car> kayıtlılar = new List<car>();
            car.car_reader(liste,kayıtlılar);
            foreach (var item in kayıtlılar)
            {
                listBox1.Items.Add(item.user_name + "//" + item.Marka + "//" + item.Model + "//" + item.Paket + "//" + item.Yedek_parça + "//" + item.adet);
            }
        }

        private void satıcı_listele_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            string liste = "satıcı.txt";
            List<user> kayıtlılar = new List<user>();
            admin.Reader_kişi_bilgisi(liste, kayıtlılar);
            foreach (var item in kayıtlılar)
            {
                listBox1.Items.Add(item.user_name + "//" + item.Name + "//" + item.user_password + "//" + item.user_phone + "//" + item.user_email);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Yönetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 giriş = new Form1();
            this.Hide();
            giriş.ShowDialog();
        }
    }
}
