//210229040_SalihCanTuran

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace araç_yedek_parça
{
    public partial class Satıcı : Form
    {
        //kullanıcı adını string ifadede taşıma için
        public static string[] girişyapan { get; set; } = new string[2];
        public Satıcı()
        {
            InitializeComponent();
        }

        public void Satıcı_Load(object sender, EventArgs e)
        {
            //kullanıcı adını sekmeye taşımak için
            label2.Text = girişyapan[0];


           
        }

        private void Talep_güncelleme_buton_Click(object sender, EventArgs e)
        {
            //üst üste eklemeyi engellemek için box'ı temizliyoruz.
            listBox1.Items.Clear();

            //sepeti okuyup listeliyoruz.
            string sepet_dosyası = "sepet.txt";
            List<car> sepet_listesi = new List<car>();
            dealer.sepet_listeleme_reader(sepet_dosyası, sepet_listesi);

            //sepeti list.box'a ekliyoruz.
            foreach (var item in sepet_listesi)
            {

                listBox1.Items.Add(item.user_name + " " + item.Marka + " " + item.Model + " " + item.Paket + " " + item.Yedek_parça + " " + item.adet);



            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Talep_onaylama_buton_Click(object sender, EventArgs e)
        {
            // Seçilen ürünü al
            string secilenUrun = listBox1.SelectedItem?.ToString();
            //stringi ifadeyi parçala
            string[] urunBilgileri = secilenUrun.Split(' ');


            // Sepet dosyasını oku
            string sepet_dosyası = "sepet.txt";
            List<car> sepet_listesi = new List<car>();
            dealer.sepet_listeleme_reader(sepet_dosyası, sepet_listesi);

            // Ürün bilgilerine göre sepet listesindeki öğeyi bul
            var silinecekUrun = sepet_listesi.Find(item => item.user_name == urunBilgileri[0] && item.Marka == urunBilgileri[1] && item.Model == urunBilgileri[2] && item.Paket == urunBilgileri[3] && item.Yedek_parça == urunBilgileri[4] && item.adet == urunBilgileri[5]);




            if (silinecekUrun != null)
            {
                sepet_listesi.Remove(silinecekUrun);

                car.sepet_güncelleme(sepet_dosyası, sepet_listesi);

                //geçmiş talepler listesine durumu yazdır.
                string dosya_yolu = @"geçmiş_talepler.txt";
                FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"Username:{silinecekUrun.user_name}\nselected Brand:{silinecekUrun.Marka}\nselected Model:{silinecekUrun.Model}\nselected Packet:{silinecekUrun.Paket}\nselected Spare Part:{silinecekUrun.Yedek_parça}\nselected Quantity:{silinecekUrun.adet}\nCase:{silinecekUrun.durum = "Approved"}\n*****");
                sw.Flush();
                sw.Close();
                fs.Close();

                //envante güncelleme işlemleri!!!
                string sepet_dosyası2 = "arabalar.txt";
                List<car> sepet_listesi2 = new List<car>();
                car.car_reader(sepet_dosyası2, sepet_listesi2);

                //silinecek ürünü kaldır.
                car güncellenecek = sepet_listesi2.Find(item => item.Marka == silinecekUrun.Marka && silinecekUrun.Model == item.Model && item.Paket == silinecekUrun.Paket && item.Yedek_parça == silinecekUrun.Yedek_parça);
                sepet_listesi2.Remove(güncellenecek);

                //ilglili matematiksel işlemler
                int yeni_adet = int.Parse(güncellenecek.adet) - int.Parse(silinecekUrun.adet);
                güncellenecek.adet = yeni_adet.ToString();

                //listeyi güncelle
                sepet_listesi2.Add(güncellenecek);
                car.arac_güncelleme(sepet_dosyası2,sepet_listesi2);



            }
            else
            {
                MessageBox.Show("Selected Product was not found in your cart");
            }
            
        }


        private void Talep_iptal_buton_Click(object sender, EventArgs e)
        {

            // Seçilen ürünü al
            string secilenUrun = listBox1.SelectedItem?.ToString();

            string[] urunBilgileri = secilenUrun.Split(' ');



            // Sepet dosyasını oku
            string sepet_dosyası = "sepet.txt";
            List<car> sepet_listesi = new List<car>();
            dealer.sepet_listeleme_reader(sepet_dosyası, sepet_listesi);



            // Ürün bilgilerine göre sepet listesindeki öğeyi bul(!!!-> değiştirmeyi dene find ile
            var silinecekUrun = sepet_listesi.Find(item => item.user_name == urunBilgileri[0] && item.Marka == urunBilgileri[1] && item.Model == urunBilgileri[2] && item.Paket == urunBilgileri[3] && item.Yedek_parça == urunBilgileri[4] && item.adet == urunBilgileri[5]);


            if (silinecekUrun != null)
            {
                sepet_listesi.Remove(silinecekUrun);

                car.sepet_güncelleme(sepet_dosyası, sepet_listesi);


                string dosya_yolu = @"geçmiş_talepler.txt";
                FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"Username:{silinecekUrun.user_name}\nselected Brand:{silinecekUrun.Marka}\nselected Model:{silinecekUrun.Model}\nselected Packet:{silinecekUrun.Paket}\nselected Spare Part:{silinecekUrun.Yedek_parça}\nselected Quantity:{silinecekUrun.adet}\nCase:{silinecekUrun.durum = "Cancelled"}\n*****");
                sw.Flush();
                sw.Close();
                fs.Close();





            }
            else
            {
                MessageBox.Show("The specified product was not found in your cart.");
            }

        }

        private void müşteri_bilgi_TextChanged(object sender, EventArgs e)
        {

        }

        public void bilgi_gör_Click(object sender, EventArgs e)
        {
            string userName = müşteri_bilgi.Text;


            string kayıtlıKullanıcıDosyası = "müşteri.txt";
            List<user> kayıtlılar = new List<user>();
            dealer.Reader_kişi_bilgisi(kayıtlıKullanıcıDosyası, kayıtlılar);
            foreach (var item in kayıtlılar)
            {
                if (item.user_name != userName)
                {
                    continue;

                }

                if (item.user_name == userName)

                {


                    MessageBox.Show($"Username:{item.user_name}\n:Password:{item.user_password}\nName:{item.Name}\nEmail:{item.user_email}\nPhone:{item.user_phone} ");


                    break;
                }

                MessageBox.Show("There is no such user in the system");
            }
        }

        public void hesap_sil_Click(object sender, EventArgs e)
        {
            //listeleme işlemi yapıyoruz
            string eski_liste = "satıcı.txt";
            List<user> liste = new List<user>();
            dealer.Reader_kişi_bilgisi(eski_liste, liste);

            //silinecek satıcıyı ayıklıyoruz.
            var yeniListe = liste.Where(item => item.user_name != girişyapan[0]).ToList();

            //yeni listeyi dosyaya yazdırarak güncelliyoruz.
            string yeni_liste = "satıcı.txt";
            dealer.kişi_dosyası_güncelleme(yeni_liste, yeniListe);

            //ana sayfaya atıyoruz.
            Form1 giriş = new Form1();
            this.Hide();
            giriş.ShowDialog();
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

      

        public void label7_Click(object sender, EventArgs e)
        {

        }

        public void araç_ekleme_Click(object sender, EventArgs e)
        {

            //ekleyeceğimiz araç için yeni bir nesne oluşturuyoruz.
            car yeni_araba = new car();

            //text değerleri değişkenlere atıyoruz.
            yeni_araba.Marka = Marka_text.Text;
            yeni_araba.Model = Model_text.Text;
            yeni_araba.Paket = Paket_text.Text;
            yeni_araba.Yedek_parça = Yedek_parça_text.Text;
            yeni_araba.adet = Adet_text.Text;

            //kontrol yapısına sokuyoruz
            if (yeni_araba.adet != null && yeni_araba.Yedek_parça != null && yeni_araba.Paket != null && yeni_araba.Model != null && yeni_araba.Marka != null)
            {
                string dosya_yolu = @"arabalar.txt";
                FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"Brand:{yeni_araba.Marka}\nModel:{yeni_araba.Model}\nPacket:{yeni_araba.Paket}\nSpare Part:{yeni_araba.Yedek_parça}\nQuantity:{yeni_araba.adet}\n*****");
                sw.Flush();
                sw.Close();
                fs.Close();

                MessageBox.Show("Your vehicle registration has been completed successfully.");
            }
            else
            {
                MessageBox.Show("Please fill in the missing information");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }



        public void araç_sil_Click(object sender, EventArgs e)
        {
            //kontol amaçlı text ifadeleri string değişkene atadım.
            string marka = markambox.Text;
            string modelim = modelimbox.Text;
            string paketim = paketimbox.Text;
            string yedek = parçambox.Text;

            //araç dosyasını okuyup listeye attım
            string eski_liste = "arabalar.txt";
            List<car> liste = new List<car>();
            car.car_reader(eski_liste, liste);

            string sepetcik = "sepet.txt";
            List <car> sepet=new List<car>();
            dealer.sepet_listeleme_reader2(sepetcik, sepet);

            car kontrol = sepet.Find(item=> item.Marka==marka&&item.Model==modelim&&item.Paket==paketim&&item.Yedek_parça==yedek);

            if (kontrol!=null)
            {
                MessageBox.Show("Please consider the discount first.");
            }

            else
            {
                //listede ilgili aracı arayıp buldum ve listeden sildim.
                car silinen = liste.Find(item => item.Marka == marka && item.Model == modelim && item.Paket == paketim && item.Yedek_parça == yedek);
                liste.Remove(silinen);

                //listeyi güncelledik
                string yeni_liste = "arabalar.txt";
                car.arac_güncelleme(yeni_liste, liste);
                MessageBox.Show("The vehicle was successfully deleted");
            }
           

          

        }










        private void markambox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void modelimbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void paketimbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void parçambox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void adetimbox_TextChanged(object sender, EventArgs e)
        {

        }

       

       

        public void update_buton_Click(object sender, EventArgs e)
        {
            
            string sepet_dosyası2 = "arabalar.txt";
            List<car> sepet_listesi2 = new List<car>();
            car.car_reader(sepet_dosyası2, sepet_listesi2);

            car güncellenecek = sepet_listesi2.Find(item => item.Marka == textBox2.Text.ToString() && textBox3.Text.ToString() == item.Model && item.Paket == textBox4.Text.ToString() && item.Yedek_parça == textBox5.Text.ToString());
           
            if (güncellenecek==null)
            {
                MessageBox.Show("The vehicle is not listed or pay attention to the letter case");
            }
            else
            {
                
                sepet_listesi2.Remove(güncellenecek);

                //adet güncelleme işlemleri
                güncellenecek.adet = textBox1.Text;
                sepet_listesi2.Add(güncellenecek);
                car.arac_güncelleme(sepet_dosyası2, sepet_listesi2);
                MessageBox.Show("update successful");
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Satıcı_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 giriş = new Form1();
            this.Hide();
            giriş.ShowDialog();
        }
    }
}


