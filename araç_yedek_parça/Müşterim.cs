//210229040_SalihCanTuran

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace araç_yedek_parça
{
    public partial class Müşterim : Form
    {

        //isim taşımak için tanımlanan dizi
        public static string[] girişyapan { get; set; } = new string[2];
        public Müşterim()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        public void Müşterim_Load(object sender, EventArgs e)
        {

            string sepet_dosyası2 = "arabalar.txt";
            List<car> sepet_listesi2 = new List<car>();
            customer.car_reader(sepet_dosyası2, sepet_listesi2);
            car.arac_güncelleme(sepet_dosyası2, sepet_listesi2);


            label1.Text = girişyapan[0];
            string kayıtlıKullanıcıDosyası = "arabalar.txt";
            List<car> Araç_listesi = new List<car>();
            customer.car_reader(kayıtlıKullanıcıDosyası, Araç_listesi);



            // Distinct kullanarak yinelenen markaları filtreledim
            var distinctMarkalar = Araç_listesi
                .Select(arac => arac.Marka)
                .Distinct();

            foreach (var marka in distinctMarkalar)
            {
                comboBox_marka.Items.Add(marka);
            }
            comboBox_marka.SelectedIndexChanged += comboBox_marka_SelectedIndexChanged;

        }

        public void comboBox_marka_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Seçilen markayı al
            string seçilen_Marka = comboBox_marka.SelectedItem.ToString();

            // Araç listesini tekrar oku
            string kayıtlıKullanıcıDosyası = "arabalar.txt";
            List<car> Araç_listesi = new List<car>();
            customer.car_reader(kayıtlıKullanıcıDosyası, Araç_listesi);

            // Seçilen markaya ait modelleri filtrele
            var distinctModeller = Araç_listesi
                .Where(arac => arac.Marka == seçilen_Marka)
                .Select(arac => arac.Model)
                .Distinct();

            // ComboBox_Model'i temizle
            comboBox_Model.Items.Clear();

            // Filtrelenmiş modelleri ComboBox_Model'e ekle
            foreach (var model in distinctModeller)
            {
                comboBox_Model.Items.Add(model);
            }
        }
    

        public void comboBox_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seçilen_Model = comboBox_Model.SelectedItem.ToString();

            // Araç listesini tekrar oku
            string kayıtlıKullanıcıDosyası = "arabalar.txt";
            List<car> Araç_listesi = new List<car>();
            customer.car_reader(kayıtlıKullanıcıDosyası, Araç_listesi);

            // Seçilen markaya ait modelleri filtrele
            var distinctPaket = Araç_listesi
                .Where(arac => arac.Model == seçilen_Model)
                .Select(arac => arac.Paket)
                .Distinct();

            // ComboBox_Model'i temizle
            comboBox_paket.Items.Clear();

            // Filtrelenmiş modelleri ComboBox_Model'e ekle
            foreach (var paket in distinctPaket)
            {
                comboBox_paket.Items.Add(paket);
            }

        }

    

        public void comboBox_paket_SelectedIndexChanged(object sender, EventArgs e)
        {

            string seçilen_Paket = comboBox_paket.SelectedItem.ToString();

            // Araç listesini tekrar oku
            string kayıtlıKullanıcıDosyası = "arabalar.txt";
            List<car> Araç_listesi = new List<car>();
            customer.car_reader(kayıtlıKullanıcıDosyası, Araç_listesi);

            // Seçilen markaya ait modelleri filtrele
            var distinctParça = Araç_listesi
                .Where(arac => arac.Paket == seçilen_Paket)
                .Select(arac => arac.Yedek_parça)
                .Distinct();

            // ComboBox_Model'i temizle
            comboBox_Parça.Items.Clear();

            // Filtrelenmiş modelleri ComboBox_Model'e ekle
            foreach (var parça in distinctParça)
            {
                comboBox_Parça.Items.Add(parça);
            }

        }

        public void comboBox_Parça_SelectedIndexChanged(object sender, EventArgs e)
        {

            string seçilen_parça = comboBox_Parça.SelectedItem.ToString();
            string seçilen_Paket = comboBox_paket.SelectedItem.ToString();

            // Araç listesini tekrar oku
            string kayıtlıKullanıcıDosyası = "arabalar.txt";
            List<car> Araç_listesi = new List<car>();
            customer.car_reader(kayıtlıKullanıcıDosyası, Araç_listesi);

            // Seçilen markaya ait modelleri filtrele
            var distinctAdet = Araç_listesi
                .Where(arac => arac.Yedek_parça == seçilen_parça && seçilen_Paket==arac.Paket)
                .Select(arac => arac.adet)
                .Distinct();
            
            // ComboBox_Model'i temizle
            comboBox_adet.Items.Clear();

            // Filtrelenmiş modelleri ComboBox_Model'e ekle
            foreach (var adet in distinctAdet)
            {
                comboBox_adet.Items.Add(adet);
            }


        }

        public void comboBox_adet_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void sepete_eklenecek_TextChanged(object sender, EventArgs e)
        {
           
            

        }

        public void sepete_ekle_buton_Click(object sender, EventArgs e)
        {

            string secilenMarka = comboBox_marka.SelectedItem?.ToString();
            string secilenModel = comboBox_Model.SelectedItem?.ToString();
            string secilenPaket = comboBox_paket.SelectedItem?.ToString();
            string secilenParca = comboBox_Parça.SelectedItem?.ToString();
            string sepete_eklecek_adet=sepete_eklenecek.Text;
            string user = girişyapan[0];

            string mevcut=comboBox_adet.SelectedItem?.ToString();
            int sayı_mevcut = int.Parse(mevcut);
            int sayı_sepete_eklenecek_adet=int.Parse(sepete_eklecek_adet);

            //stok kontrolü yapıyoruz
            if (sayı_sepete_eklenecek_adet>sayı_mevcut)
            {
                MessageBox.Show("We don't have that many parts in stock");
            }
            if (sayı_sepete_eklenecek_adet < sayı_mevcut)
            {
                int sayı_yeni_stok_miktarı = sayı_mevcut - sayı_sepete_eklenecek_adet;
                string yeni_stok_miktarı=sayı_yeni_stok_miktarı.ToString();

                string dosya_yolu = @"sepet.txt";
                FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"Username:{user}\nselected Brand:{secilenMarka}\nselected Model:{secilenModel}\nselected Packet:{secilenPaket}\nselected Spare Part:{secilenParca}\nselected Quantity:{sepete_eklecek_adet}\n*****");
                sw.Flush();
                sw.Close();
                fs.Close();

            }


            


        }

        public void sepet_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            sepet_listesi_box.Items.Clear();
            string sepet_dosyası = "sepet.txt";
            List<car> sepet_listesi = new List<car>();
            customer.sepet_listeleme_reader(sepet_dosyası, sepet_listesi);
            foreach (var item in sepet_listesi)
            {
                if (item.user_name == girişyapan[0] )
                {
                    sepet_listesi_box.Items.Add(item.Marka + " " + item.Model + " " + item.Paket + " " + item.Yedek_parça + " " + item.adet);

                }
             
            }

        }

        private void Hesap_sil_Click(object sender, EventArgs e)
        {
           
            string eski_liste = "müşteri.txt";
            List<user> liste = new List<user>();
            customer.Reader_kişi_bilgisi(eski_liste, liste);

            var yeniListe = liste.Where(item => item.user_name != girişyapan[0]).ToList();

            string yeni_liste = "müşteri.txt";
            customer.kişi_dosyası_güncelleme(yeni_liste, yeniListe);

            Form1 giriş = new Form1();
            this.Hide();
            giriş.ShowDialog();

        }

        private void sepetten_sil_Click(object sender, EventArgs e)
        {
            // Seçilen ürünü al
            string secilenUrun = sepet_listesi_box.SelectedItem?.ToString();

            string[] urunBilgileri = secilenUrun.Split(' ');

         

            // Sepet dosyasını oku
            string sepet_dosyası = "sepet.txt";
            List<car> sepet_listesi = new List<car>();
            customer.sepet_listeleme_reader(sepet_dosyası, sepet_listesi);

            // Ürün bilgilerine göre sepet listesindeki öğeyi bul(!!!-> değiştirmeyi dene find ile
            var silinecekUrun = sepet_listesi.Find(item => item.Marka == urunBilgileri[0] && item.Model == urunBilgileri[1] && item.Paket == urunBilgileri[2] && item.Yedek_parça == urunBilgileri[3] && item.adet == urunBilgileri[4]);

            if (silinecekUrun != null)
            {
                sepet_listesi.Remove(silinecekUrun);

                car.sepet_güncelleme(sepet_dosyası, sepet_listesi);

              
            }
            else
            {
                MessageBox.Show("The specified product was not found in your cart.");
            }
        }

        public void Geçmiş_talepleri_güncelle_buton_Click(object sender, EventArgs e)
        {
            Geçmiş_talepler_box.Items.Clear();
            sepet_listesi_box.Items.Clear();

            string geçmiş_sepet_dosyası = "geçmiş_talepler.txt";
            List<car> sepet_listesi = new List<car>();
            customer.sepet_listeleme_reader2(geçmiş_sepet_dosyası, sepet_listesi);

            foreach (var item in sepet_listesi)
            {
                if (item.user_name == girişyapan[0])
                {
                    Geçmiş_talepler_box.Items.Add(item.Marka + " " + item.Model + " " + item.Paket + " " + item.Yedek_parça + " " + item.adet + " " +item.durum);

                }

            }
        }

        public void Geçmiş_talepler_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Müşterim_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Müşterim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 giriş = new Form1();
            this.Hide();
            giriş.ShowDialog();
        }
    }
}
